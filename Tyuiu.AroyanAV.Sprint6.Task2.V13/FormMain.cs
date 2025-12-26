using Tyuiu.AroyanAV.Sprint6.Task2.V13.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        private object ds;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPerform_AAV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

        private void buttonPerform_AAV_Clicked(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxInputMin_AAV.Text);
                int stopStep = Convert.ToInt32(textBoxInputMax_AAV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arr = new double[len];
                arr = ds.GetMassFunction(startStep, stopStep);

                this.chart_AAV.Titles.Add("Ãðàôèê ôóíêöèè sin(x)");

                this.chart_AAV.ChartAreas[0].AxisX.Title = "Îñü Õ";
                this.chart_AAV.ChartAreas[0].AxisY.Title = "Îñü Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_AAV.Rows.Add(Convert.ToString(startStep), Convert.ToString(arr[i]));

                    this.chart_AAV.Series[0].Points.AddXY(startStep, arr[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÐÏÏÁ-25-1 Ìîë÷àíîâ Èâàí Âëàäèìèðîâè÷ ", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void stopStep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}