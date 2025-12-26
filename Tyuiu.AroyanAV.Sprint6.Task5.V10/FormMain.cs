using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AroyanAV.Sprint6.Task5.V10.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {

        private readonly DataService ds = new DataService();

        private string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InPutDataFileTask5V10.txt");

        public FormMain()
        {
            InitializeComponent();

            dataGridViewResult_AAV.ColumnCount = 2;
            dataGridViewResult_AAV.Columns[0].HeaderText = "Индекс";
            dataGridViewResult_AAV.Columns[1].HeaderText = "Значение";
            dataGridViewResult_AAV.Columns[0].Width = 20;
            dataGridViewResult_AAV.Columns[1].Width = 50;
        }

        private void buttonDone_AAV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл не найден:\n{path}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] numsMass = ds.LoadFromDataFile(path);

                // Очистка графика
                if (chartFunction_AAV.Series.Count > 0)
                    chartFunction_AAV.Series[0].Points.Clear();

                // Настройка осей
                chartFunction_AAV.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_AAV.ChartAreas[0].AxisY.Title = "Ось Y";

                // Очистка таблицы
                dataGridViewResult_AAV.Rows.Clear();

                // Заполнение
                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_AAV.Rows.Add(i.ToString(), numsMass[i].ToString("F2"));
                    if (chartFunction_AAV.Series.Count > 0)
                        chartFunction_AAV.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_AAV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл не найден:\n{path}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 5 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
