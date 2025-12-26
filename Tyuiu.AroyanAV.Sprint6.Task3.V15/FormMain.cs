using Tyuiu.AroyanAV.Sprint6.Task3.V15.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExecute_AAV_Click(object sender, EventArgs e)
        {
            var ds = new DataService();
            var initialMatrix = new int[5, 5]
            {
        { 33, 28, 31, 19, 4 },
        { 1, 32, -3, -17, -12 },
        { 24, -19, 26, 31, -3 },
        { 30, -16, 29, 28, 8 },
        { 30, 5, 11, 7, 32 }
            };

            var sortedMatrix = ds.Calculate(initialMatrix);


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = sortedMatrix[i, j].ToString();
                }
            }


            int zeroCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (sortedMatrix[i, j] == 0)
                        zeroCount++;
                }
            }

            // Выводим результат в TextBox (если он есть)
            textBoxResult_AAV.Text = zeroCount.ToString();
        }
    }
}
