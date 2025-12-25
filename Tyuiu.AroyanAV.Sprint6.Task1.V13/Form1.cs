using System;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.AroyanAV.Sprint6.Task1.V13
{
    public partial class Form1 : Form
    {
        private object textBoxResult_AAV;

        public Form1()
        {
            InitializeComponent();

            // Установим начальные значения (по умолчанию [-5; 5])
            textBoxstart_AAV.Text = "-5";
            textBoxend_AAV.Text = "5";
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        // ✅ Обработчик нажатия кнопки "Вычислить"
        private void buttonCalculate_Click_AAV(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxstart_AAV.Text);
                int end = Convert.ToInt32(textBoxend_AAV.Text);

                if (start > end)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var service = new DataService();
                double[] results = service.GetMassFunction(start,
                                                           end);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("|   X   |  F(x)  |");
                sb.AppendLine("+-------+--------+");

                for (int i = 0; i < results.Length; i++)
                {
                    int x = start + i;
                    sb.AppendLine($"| {x,5} | {results[i],6:F2} |");
                }
                sb.AppendLine("+-------+--------+");

                textBoxResult_AAV.text = sb.ToString(); // ← исправлено имя: textBoxResult_AAV
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите целые числа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Обработчик кнопки "Справка" / "О программе"
        private void buttonHelp_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // ✅ Вложенный класс DataService — перенесён вовне partial-класса Form1
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i;
                result[i] = CalculateFunction(x);
            }

            return result;
        }

        private double CalculateFunction(int x)
        {
            double denominator = 4 * x - 0.5;

            if (Math.Abs(denominator) < 1e-9)
            {
                return 0.0;
            }

            double y = (3 * Math.Cos(x)) / denominator + Math.Sin(x) - 5 * x - 2;
            return Math.Round(y, 2);
        }
    }
}

