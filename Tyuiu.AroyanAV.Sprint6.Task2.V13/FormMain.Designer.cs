namespace Tyuiu.AroyanAV.Sprint6.Task2.V13
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            chart_AAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_AAV = new TextBox();
            textBoxresult = new TextBox();
            textBox1 = new TextBox();
            splitter1 = new Splitter();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBoxInputMin_AAV = new TextBox();
            textBoxInputMax_AAV = new TextBox();
            startStep = new TextBox();
            stopStep = new TextBox();
            GetMassFunction = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxtask = new TextBox();
            groupBoxtask = new GroupBox();
            buttonPerform_AAV = new Button();
            buttonQuestion_AAV = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_AAV).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            GetMassFunction.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxtask.SuspendLayout();
            SuspendLayout();
            // 
            // chart_AAV
            // 
            chartArea2.Name = "ChartArea1";
            chart_AAV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_AAV.Legends.Add(legend2);
            chart_AAV.Location = new Point(469, 23);
            chart_AAV.Name = "chart_AAV";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_AAV.Series.Add(series2);
            chart_AAV.Size = new Size(307, 350);
            chart_AAV.TabIndex = 0;
            chart_AAV.Text = "chart1";
            // 
            // dataGridView_AAV
            // 
            dataGridView_AAV.BackColor = SystemColors.WindowFrame;
            dataGridView_AAV.Location = new Point(21, 56);
            dataGridView_AAV.Multiline = true;
            dataGridView_AAV.Name = "dataGridView_AAV";
            dataGridView_AAV.Size = new Size(149, 324);
            dataGridView_AAV.TabIndex = 1;
            // 
            // textBoxresult
            // 
            textBoxresult.BackColor = SystemColors.Menu;
            textBoxresult.BorderStyle = BorderStyle.None;
            textBoxresult.Location = new Point(21, 26);
            textBoxresult.Name = "textBoxresult";
            textBoxresult.Size = new Size(125, 20);
            textBoxresult.TabIndex = 2;
            textBoxresult.Text = "Результат";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 28);
            textBox1.TabIndex = 3;
            textBox1.Text = "Х";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 450);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(31, 73);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(126, 69);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Tag = "";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(66, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 28);
            textBox2.TabIndex = 4;
            textBox2.Text = "F(X)";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(3, 37);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 28);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(66, 37);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 28);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxInputMin_AAV
            // 
            textBoxInputMin_AAV.Location = new Point(34, 77);
            textBoxInputMin_AAV.Multiline = true;
            textBoxInputMin_AAV.Name = "textBoxInputMin_AAV";
            textBoxInputMin_AAV.Size = new Size(95, 28);
            textBoxInputMin_AAV.TabIndex = 7;
            textBoxInputMin_AAV.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxInputMax_AAV
            // 
            textBoxInputMax_AAV.Location = new Point(144, 77);
            textBoxInputMax_AAV.Multiline = true;
            textBoxInputMax_AAV.Name = "textBoxInputMax_AAV";
            textBoxInputMax_AAV.Size = new Size(84, 28);
            textBoxInputMax_AAV.TabIndex = 8;
            textBoxInputMax_AAV.TextAlign = HorizontalAlignment.Center;
            // 
            // startStep
            // 
            startStep.BackColor = SystemColors.Menu;
            startStep.BorderStyle = BorderStyle.None;
            startStep.Location = new Point(22, 40);
            startStep.Multiline = true;
            startStep.Name = "startStep";
            startStep.Size = new Size(107, 28);
            startStep.TabIndex = 9;
            startStep.Text = "Старт шага";
            startStep.TextAlign = HorizontalAlignment.Center;
            // 
            // stopStep
            // 
            stopStep.BackColor = SystemColors.Menu;
            stopStep.BorderStyle = BorderStyle.None;
            stopStep.Location = new Point(135, 43);
            stopStep.Multiline = true;
            stopStep.Name = "stopStep";
            stopStep.Size = new Size(93, 28);
            stopStep.TabIndex = 10;
            stopStep.Text = "Конец шага";
            stopStep.TextAlign = HorizontalAlignment.Center;
            // 
            // GetMassFunction
            // 
            GetMassFunction.Controls.Add(textBoxInputMax_AAV);
            GetMassFunction.Controls.Add(stopStep);
            GetMassFunction.Controls.Add(textBoxInputMin_AAV);
            GetMassFunction.Controls.Add(startStep);
            GetMassFunction.Location = new Point(12, 270);
            GetMassFunction.Name = "GetMassFunction";
            GetMassFunction.Size = new Size(256, 139);
            GetMassFunction.TabIndex = 11;
            GetMassFunction.TabStop = false;
            GetMassFunction.Text = "Ввод данных";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxresult);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(dataGridView_AAV);
            groupBox1.Location = new Point(274, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(189, 386);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxtask
            // 
            textBoxtask.BackColor = SystemColors.Menu;
            textBoxtask.BorderStyle = BorderStyle.None;
            textBoxtask.Location = new Point(6, 26);
            textBoxtask.Multiline = true;
            textBoxtask.Name = "textBoxtask";
            textBoxtask.Size = new Size(246, 93);
            textBoxtask.TabIndex = 13;
            textBoxtask.Text = "Протабулировать функцию на заданном диапозоне. Вывести результат и построить график.";
            // 
            // groupBoxtask
            // 
            groupBoxtask.Controls.Add(textBoxtask);
            groupBoxtask.Location = new Point(10, 23);
            groupBoxtask.Name = "groupBoxtask";
            groupBoxtask.Size = new Size(258, 241);
            groupBoxtask.TabIndex = 14;
            groupBoxtask.TabStop = false;
            groupBoxtask.Text = "Условие";
            // 
            // buttonPerform_AAV
            // 
            buttonPerform_AAV.BackColor = Color.Green;
            buttonPerform_AAV.Cursor = Cursors.SizeAll;
            buttonPerform_AAV.FlatStyle = FlatStyle.Popup;
            buttonPerform_AAV.Location = new Point(644, 395);
            buttonPerform_AAV.Name = "buttonPerform_AAV";
            buttonPerform_AAV.Size = new Size(117, 43);
            buttonPerform_AAV.TabIndex = 15;
            buttonPerform_AAV.Text = "Выполнить";
            buttonPerform_AAV.UseVisualStyleBackColor = false;
            buttonPerform_AAV.Click += buttonPerform_AAV_Click;
            // 
            // buttonQuestion_AAV
            // 
            buttonQuestion_AAV.BackColor = SystemColors.HotTrack;
            buttonQuestion_AAV.FlatStyle = FlatStyle.Popup;
            buttonQuestion_AAV.Location = new Point(526, 395);
            buttonQuestion_AAV.Name = "buttonQuestion_AAV";
            buttonQuestion_AAV.Size = new Size(112, 42);
            buttonQuestion_AAV.TabIndex = 16;
            buttonQuestion_AAV.Text = "Справка";
            buttonQuestion_AAV.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQuestion_AAV);
            Controls.Add(buttonPerform_AAV);
            Controls.Add(groupBoxtask);
            Controls.Add(groupBox1);
            Controls.Add(GetMassFunction);
            Controls.Add(splitter1);
            Controls.Add(chart_AAV);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart_AAV).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            GetMassFunction.ResumeLayout(false);
            GetMassFunction.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxtask.ResumeLayout(false);
            groupBoxtask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AAV;
        private TextBox dataGridView_AAV;
        private TextBox textBoxresult;
        private TextBox textBox1;
        private Splitter splitter1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBoxInputMin_AAV;
        private TextBox textBoxInputMax_AAV;
        private TextBox startStep;
        private TextBox stopStep;
        private GroupBox GetMassFunction;
        private GroupBox groupBox1;
        private TextBox textBoxtask;
        private GroupBox groupBoxtask;
        private Button buttonPerform_AAV;
        private Button buttonQuestion_AAV;
    }
}
