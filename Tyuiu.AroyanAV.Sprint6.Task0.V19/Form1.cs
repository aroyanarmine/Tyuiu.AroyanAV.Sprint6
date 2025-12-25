using System;
using System.Globalization;
using System.Windows.Forms;

namespace Tyuiu.AroyanAV.Sprint6.Task0.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxVarX_AAV.Text = "3";
        }

        private void buttonDone_AAV_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBoxVarX_AAV.Text, out int x))
            {
                
                double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
                y = Math.Round(y, 3); 

                textBoxResult_AAV.Text = y.ToString("F3", CultureInfo.InvariantCulture);
            }
            else
            {
                
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxVarX_AAV.Focus();
            }
        }

        private void buttonHelp_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
