namespace Tyuiu.AroyanAV.Sprint6.Task5.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            chartFunction_AAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_AAV = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            buttonDone_AAV = new Button();
            buttonHelp_AAV = new Button();
            buttonOpen_AAV = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAV).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(chartFunction_AAV);
            panel1.Location = new Point(301, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 514);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(12, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 514);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(buttonOpen_AAV);
            panel3.Controls.Add(buttonHelp_AAV);
            panel3.Controls.Add(buttonDone_AAV);
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(12, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(946, 150);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewResult_AAV);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 508);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // chartFunction_AAV
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_AAV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_AAV.Legends.Add(legend2);
            chartFunction_AAV.Location = new Point(74, 44);
            chartFunction_AAV.Name = "chartFunction_AAV";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_AAV.Series.Add(series2);
            chartFunction_AAV.Size = new Size(478, 428);
            chartFunction_AAV.TabIndex = 0;
            chartFunction_AAV.Text = "chart1";
            // 
            // dataGridViewResult_AAV
            // 
            dataGridViewResult_AAV.BackColor = SystemColors.WindowFrame;
            dataGridViewResult_AAV.Location = new Point(6, 26);
            dataGridViewResult_AAV.Multiline = true;
            dataGridViewResult_AAV.Name = "dataGridViewResult_AAV";
            dataGridViewResult_AAV.Size = new Size(266, 465);
            dataGridViewResult_AAV.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(6, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 137);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(23, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(393, 100);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutFileTask5V10.txt. \r\nВывести в dataGridView. \r\nВывести все числа, не равные 0.\r\nПостроить диаграмму по этим значениям. ";
            // 
            // buttonDone_AAV
            // 
            buttonDone_AAV.BackColor = Color.Green;
            buttonDone_AAV.FlatStyle = FlatStyle.Flat;
            buttonDone_AAV.Location = new Point(525, 51);
            buttonDone_AAV.Name = "buttonDone_AAV";
            buttonDone_AAV.Size = new Size(112, 64);
            buttonDone_AAV.TabIndex = 1;
            buttonDone_AAV.Text = "Выполнить";
            buttonDone_AAV.UseVisualStyleBackColor = false;
            buttonDone_AAV.Click += buttonDone_AAV_Click;
            // 
            // buttonHelp_AAV
            // 
            buttonHelp_AAV.BackColor = SystemColors.Highlight;
            buttonHelp_AAV.FlatStyle = FlatStyle.Flat;
            buttonHelp_AAV.Location = new Point(655, 52);
            buttonHelp_AAV.Name = "buttonHelp_AAV";
            buttonHelp_AAV.Size = new Size(124, 62);
            buttonHelp_AAV.TabIndex = 2;
            buttonHelp_AAV.Text = "Справка";
            buttonHelp_AAV.UseVisualStyleBackColor = false;
            // 
            // buttonOpen_AAV
            // 
            buttonOpen_AAV.BackColor = SystemColors.MenuHighlight;
            buttonOpen_AAV.FlatStyle = FlatStyle.Flat;
            buttonOpen_AAV.Location = new Point(796, 52);
            buttonOpen_AAV.Name = "buttonOpen_AAV";
            buttonOpen_AAV.Size = new Size(128, 63);
            buttonOpen_AAV.TabIndex = 3;
            buttonOpen_AAV.Text = "Открыть файл";
            buttonOpen_AAV.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 652);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAV;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox dataGridViewResult_AAV;
        private Panel panel3;
        private GroupBox groupBox2;
        private Button buttonOpen_AAV;
        private Button buttonHelp_AAV;
        private Button buttonDone_AAV;
        private TextBox textBox1;
    }
}
