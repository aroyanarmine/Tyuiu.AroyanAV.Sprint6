using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AroyanAV.Sprint6.Task7.V5.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private int[,] inputMatrix;
        private string loadedFilePath = "";
        public FormMain()
        {
            InitializeComponent();

            openFileDialog_AAV.Filter = "CSV-файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_AAV.Filter = "CSV-файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog_AAV.FileName = "OutPutFileTask7.csv";

            // Настройка ToolTips (как в видео)
            toolTip_AAV.SetToolTip(buttonOpen_AAV, "Загрузить матрицу из файла");
            toolTip_AAV.SetToolTip(buttonExecute_AAV, "Обработать: последний столбец <2 → 2");
            toolTip_AAV.SetToolTip(buttonSave_AAV, "Сохранить результат");
            toolTip_AAV.SetToolTip(buttonHelp_AAV, "О программе");

            // Отключение кнопок до загрузки
            buttonExecute_AAV.Enabled = false;
            buttonSave_AAV.Enabled = false;
        }

        private void buttonOpen_AAV_Click(object sender, EventArgs e)
        {
            if (openFileDialog_AAV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    loadedFilePath = openFileDialog_AAV.FileName;
                    inputMatrix = ds.LoadMatrix(loadedFilePath, out int rows, out int cols);

                    // Настройка DataGridView
                    dataGridViewIn_AAV.ColumnCount = cols;
                    dataGridViewIn_AAV.RowCount = rows;
                    dataGridViewOut_AAV.ColumnCount = cols;
                    dataGridViewOut_AAV.RowCount = rows;

                    // Ширина столбцов
                    for (int i = 0; i < cols; i++)
                    {
                        dataGridViewIn_AAV.Columns[i].Width = 40;
                        dataGridViewOut_AAV.Columns[i].Width = 40;
                    }

                    // Заполнение входной матрицы
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            dataGridViewIn_AAV.Rows[r].Cells[c].Value = inputMatrix[r, c];
                        }
                    }

                    // Обновление заголовков групп
                    groupBoxInput_AAV.Text = $"Ввод: {Path.GetFileName(loadedFilePath)}";
                    groupBoxOutput_AAV.Text = "Вывод";

                    buttonExecute_AAV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExecute_AAV_Click(object sender, EventArgs e)
        {
            if (inputMatrix == null)
            {
                MessageBox.Show("Сначала загрузите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int[,] resultMatrix = ds.ProcessMatrix(inputMatrix);

                // Заполнение выходной матрицы
                for (int r = 0; r < resultMatrix.GetLength(0); r++)
                {
                    for (int c = 0; c < resultMatrix.GetLength(1); c++)
                    {
                        dataGridViewOut_AAV.Rows[r].Cells[c].Value = resultMatrix[r, c];
                    }
                }

                groupBoxOutput_AAV.Text = "Вывод: обработано";
                buttonSave_AAV.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_AAV_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_AAV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сбор данных из dataGridViewOut
                    int rows = dataGridViewOut_AAV.RowCount;
                    int cols = dataGridViewOut_AAV.ColumnCount;
                    int[,] resultMatrix = new int[rows, cols];

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            var cellValue = dataGridViewOut_AAV.Rows[r].Cells[c].Value;
                            resultMatrix[r, c] = cellValue != null ? Convert.ToInt32(cellValue) : 0;
                        }
                    }

                    ds.SaveMatrixToFile(resultMatrix, saveFileDialog_AAV.FileName);
                    MessageBox.Show("Файл успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_AAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 7 выполнила студентка группы ИСТНб-25-1 Ароян Армине Вачагановна",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}

