using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AroyanAV.Sprint6.Task4.V12.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task4.V12
{
        public partial class FormMain : Form
        {
            private readonly DataService ds = new DataService();

            public FormMain()
            {
                InitializeComponent();
                // По умолчанию: диапазон от -5 до 5
                textBoxStart_AAV.Text = "-5";
                textBoxStop_AAV.Text = "5";
            }

            private void buttonDone_AAV_Click(object sender, EventArgs e)
            {
                try
                {
                    int start = Convert.ToInt32(textBoxStart_AAV.Text);
                    int stop = Convert.ToInt32(textBoxStop_AAV.Text);

                    double[] values = ds.GetMassFunction(start, stop);

                    // Очистка
                    chartFunction_AAV.Series[0].Points.Clear();
                    textBoxResult_AAV.Clear();

                    // Настройка графика
                    chartFunction_AAV.Titles.Clear();
                object value = chartFunction_AAV.Titles.Add("График функции sin(x)");
                    chartFunction_AAV.ChartAreas[0].AxisX.Title = "Ось X";
                    chartFunction_AAV.ChartAreas[0].AxisY.Title = "Ось Y";

                    // Заполнение
                    for (int i = 0; i < values.Length; i++)
                    {
                        int x = start + i;
                        double y = values[i];

                        textBoxResult_AAV.AppendText($"x = {x} → F(x) = {y:F2}\n");
                        chartFunction_AAV.Series[0].Points.AddXY(x, y);
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка: введите целые числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void buttonHelp_AAV_Click(object sender, EventArgs e)
            {
                MessageBox.Show(
                    "Таск 1 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна",
                    "Справка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            private void buttonSave_AAV_Click(object sender, EventArgs e)
            {
                try
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4.txt");
                    File.WriteAllText(path, textBoxResult_AAV.Text);

                    if (MessageBox.Show(
                        $"Файл сохранён: {path}\nОткрыть в Блокноте?",
                        "Успех",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start("notepad.exe", path);
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
