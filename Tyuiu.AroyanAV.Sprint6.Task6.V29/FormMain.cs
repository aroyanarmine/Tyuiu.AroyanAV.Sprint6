using Tyuiu.AroyanAV.Sprint6.Task6.V29.Lib;
namespace Tyuiu.AroyanAV.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        private object openFileDialog_AAV;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog_AAV.ShowDialog();
            path = openFileDialog_AAV.FileName;
            textBoxInput_AAV.Text = File.ReadAllText(path);
            groupBoxInput_AAV.Text = groupBoxInput_AAV.Text + " " + path;
            buttonStart_AAV.Enabled = true;
        }

        private void buttonStart_AAV_Click(object sender, EventArgs e)
        {
            textBoxOutput_AAV.Text = ds.CollectTextFromFile(path);
        }

        private void buttonHelp_AVV_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void textBoxInput_AAV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

