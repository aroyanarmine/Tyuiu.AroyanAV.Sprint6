namespace Tyuiu.AroyanAV.Sprint6.Task4.V12
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
            textBoxResult_AAV = new Panel();
            vScrollBar1 = new VScrollBar();
            chartFunction_AAV = new Panel();
            textBox4 = new TextBox();
            panel1 = new Panel();
            buttonHelp_AAV = new Button();
            buttonSave_AAV = new Button();
            buttonDone_AAV = new Button();
            groupBox3 = new GroupBox();
            textBoxStop_AAV = new TextBox();
            textBox3 = new TextBox();
            textBoxStart_AAV = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxResult_AAV.SuspendLayout();
            chartFunction_AAV.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult_AAV
            // 
            textBoxResult_AAV.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_AAV.Controls.Add(vScrollBar1);
            textBoxResult_AAV.Location = new Point(12, 240);
            textBoxResult_AAV.Name = "textBoxResult_AAV";
            textBoxResult_AAV.Size = new Size(251, 547);
            textBoxResult_AAV.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(225, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 544);
            vScrollBar1.TabIndex = 0;
            // 
            // chartFunction_AAV
            // 
            chartFunction_AAV.BackColor = SystemColors.ButtonHighlight;
            chartFunction_AAV.Controls.Add(textBox4);
            chartFunction_AAV.Location = new Point(269, 217);
            chartFunction_AAV.Name = "chartFunction_AAV";
            chartFunction_AAV.Size = new Size(699, 573);
            chartFunction_AAV.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.ForeColor = SystemColors.HotTrack;
            textBox4.Location = new Point(264, 14);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 24);
            textBox4.TabIndex = 0;
            textBox4.Text = "График функции";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonHelp_AAV);
            panel1.Controls.Add(buttonSave_AAV);
            panel1.Controls.Add(buttonDone_AAV);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 199);
            panel1.TabIndex = 2;
            // 
            // buttonHelp_AAV
            // 
            buttonHelp_AAV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_AAV.FlatStyle = FlatStyle.Flat;
            buttonHelp_AAV.Location = new Point(798, 113);
            buttonHelp_AAV.Name = "buttonHelp_AAV";
            buttonHelp_AAV.Size = new Size(101, 62);
            buttonHelp_AAV.TabIndex = 7;
            buttonHelp_AAV.Text = "Справка";
            buttonHelp_AAV.UseVisualStyleBackColor = false;
            // 
            // buttonSave_AAV
            // 
            buttonSave_AAV.BackColor = SystemColors.Highlight;
            buttonSave_AAV.FlatStyle = FlatStyle.Flat;
            buttonSave_AAV.Location = new Point(851, 34);
            buttonSave_AAV.Name = "buttonSave_AAV";
            buttonSave_AAV.Size = new Size(101, 62);
            buttonSave_AAV.TabIndex = 6;
            buttonSave_AAV.Text = "Сохранить";
            buttonSave_AAV.UseVisualStyleBackColor = false;
            // 
            // buttonDone_AAV
            // 
            buttonDone_AAV.BackColor = Color.Green;
            buttonDone_AAV.FlatStyle = FlatStyle.Flat;
            buttonDone_AAV.Location = new Point(742, 34);
            buttonDone_AAV.Name = "buttonDone_AAV";
            buttonDone_AAV.Size = new Size(103, 62);
            buttonDone_AAV.TabIndex = 5;
            buttonDone_AAV.Text = "Выполнить";
            buttonDone_AAV.UseVisualStyleBackColor = false;
            buttonDone_AAV.Click += buttonDone_AAV_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStop_AAV);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBoxStart_AAV);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(429, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 125);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBoxStop_AAV
            // 
            textBoxStop_AAV.Location = new Point(157, 66);
            textBoxStop_AAV.Name = "textBoxStop_AAV";
            textBoxStop_AAV.Size = new Size(125, 27);
            textBoxStop_AAV.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(157, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 7;
            textBox3.Text = "Конец шага";
            // 
            // textBoxStart_AAV
            // 
            textBoxStart_AAV.Location = new Point(19, 66);
            textBoxStart_AAV.Name = "textBoxStart_AAV";
            textBoxStart_AAV.Size = new Size(125, 27);
            textBoxStart_AAV.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(19, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 6;
            textBox2.Text = "Старт шага";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(17, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 170);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(16, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 101);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапозоне от -5 до 5. \r\nВывести результат и построить гарфик функциии сохранить файл по нажатию кнопки.";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 576);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 793);
            Controls.Add(textBoxResult_AAV);
            Controls.Add(groupBox1);
            Controls.Add(chartFunction_AAV);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            textBoxResult_AAV.ResumeLayout(false);
            chartFunction_AAV.ResumeLayout(false);
            chartFunction_AAV.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel textBoxResult_AAV;
        private Panel chartFunction_AAV;
        private Panel panel1;
        private VScrollBar vScrollBar1;
        private TextBox textBoxStart_AAV;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Button buttonHelp_AAV;
        private Button buttonSave_AAV;
        private Button buttonDone_AAV;
        private GroupBox groupBox3;
        private TextBox textBoxStop_AAV;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
