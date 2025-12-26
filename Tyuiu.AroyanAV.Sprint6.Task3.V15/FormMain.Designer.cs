namespace Tyuiu.AroyanAV.Sprint6.Task3.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewMatrix = new TextBox();
            textBoxResult_AAV = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            buttonExecute_AAV = new Button();
            buttonHelp_AAV = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.BackColor = SystemColors.WindowFrame;
            dataGridViewMatrix.Location = new Point(315, 25);
            dataGridViewMatrix.Multiline = true;
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(238, 413);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // textBoxResult_AAV
            // 
            textBoxResult_AAV.Location = new Point(18, 62);
            textBoxResult_AAV.Name = "textBoxResult_AAV";
            textBoxResult_AAV.Size = new Size(125, 27);
            textBoxResult_AAV.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(18, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Результат";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBoxResult_AAV);
            groupBox1.Location = new Point(559, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 334);
            textBox2.TabIndex = 4;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 426);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // buttonExecute_AAV
            // 
            buttonExecute_AAV.BackColor = Color.LimeGreen;
            buttonExecute_AAV.FlatStyle = FlatStyle.Flat;
            buttonExecute_AAV.Location = new Point(681, 374);
            buttonExecute_AAV.Name = "buttonExecute_AAV";
            buttonExecute_AAV.Size = new Size(107, 52);
            buttonExecute_AAV.TabIndex = 6;
            buttonExecute_AAV.Text = "Выполнить";
            buttonExecute_AAV.UseVisualStyleBackColor = false;
            buttonExecute_AAV.Click += this.buttonExecute_AAV_Click;
            // 
            // buttonHelp_AAV
            // 
            buttonHelp_AAV.BackColor = SystemColors.Highlight;
            buttonHelp_AAV.FlatStyle = FlatStyle.Popup;
            buttonHelp_AAV.Location = new Point(573, 374);
            buttonHelp_AAV.Name = "buttonHelp_AAV";
            buttonHelp_AAV.Size = new Size(102, 52);
            buttonHelp_AAV.TabIndex = 7;
            buttonHelp_AAV.Text = "Справка";
            buttonHelp_AAV.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_AAV);
            Controls.Add(buttonExecute_AAV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewMatrix);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dataGridViewMatrix;
        private TextBox textBoxResult_AAV;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Button buttonExecute_AAV;
        private Button buttonHelp_AAV;
    }
}
