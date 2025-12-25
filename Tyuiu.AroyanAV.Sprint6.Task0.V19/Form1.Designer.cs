namespace Tyuiu.AroyanAV.Sprint6.Task0.V19
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxVarX_AAV = new TextBox();
            textBoxResult_AAV = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBoxFormul_AAV = new PictureBox();
            groupBoxTask_AAV = new GroupBox();
            groupBoxХ_AAV = new GroupBox();
            groupBoxResualt_AAV = new GroupBox();
            buttonHelp_AAV = new Button();
            buttonDone_AAV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormul_AAV).BeginInit();
            groupBoxTask_AAV.SuspendLayout();
            groupBoxХ_AAV.SuspendLayout();
            groupBoxResualt_AAV.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxVarX_AAV
            // 
            textBoxVarX_AAV.Location = new Point(34, 88);
            textBoxVarX_AAV.Name = "textBoxVarX_AAV";
            textBoxVarX_AAV.Size = new Size(125, 27);
            textBoxVarX_AAV.TabIndex = 0;
            // 
            // textBoxResult_AAV
            // 
            textBoxResult_AAV.Location = new Point(43, 79);
            textBoxResult_AAV.Name = "textBoxResult_AAV";
            textBoxResult_AAV.Size = new Size(125, 27);
            textBoxResult_AAV.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(28, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Результат";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(34, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 3;
            textBox2.Text = "Переменная Х";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(45, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 20);
            textBox3.TabIndex = 4;
            textBox3.Text = "Вычислить выражение по формуле ";
            // 
            // pictureBoxFormul_AAV
            // 
            pictureBoxFormul_AAV.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFormul_AAV.Image = (Image)resources.GetObject("pictureBoxFormul_AAV.Image");
            pictureBoxFormul_AAV.Location = new Point(496, 42);
            pictureBoxFormul_AAV.Name = "pictureBoxFormul_AAV";
            pictureBoxFormul_AAV.Size = new Size(210, 58);
            pictureBoxFormul_AAV.TabIndex = 5;
            pictureBoxFormul_AAV.TabStop = false;
            // 
            // groupBoxTask_AAV
            // 
            groupBoxTask_AAV.Controls.Add(pictureBoxFormul_AAV);
            groupBoxTask_AAV.Controls.Add(textBox3);
            groupBoxTask_AAV.Location = new Point(29, 32);
            groupBoxTask_AAV.Name = "groupBoxTask_AAV";
            groupBoxTask_AAV.Size = new Size(742, 187);
            groupBoxTask_AAV.TabIndex = 6;
            groupBoxTask_AAV.TabStop = false;
            groupBoxTask_AAV.Text = "Условие";
            // 
            // groupBoxХ_AAV
            // 
            groupBoxХ_AAV.Controls.Add(textBox2);
            groupBoxХ_AAV.Controls.Add(textBoxVarX_AAV);
            groupBoxХ_AAV.Location = new Point(29, 234);
            groupBoxХ_AAV.Name = "groupBoxХ_AAV";
            groupBoxХ_AAV.Size = new Size(357, 143);
            groupBoxХ_AAV.TabIndex = 7;
            groupBoxХ_AAV.TabStop = false;
            groupBoxХ_AAV.Text = "Ввод данных";
            // 
            // groupBoxResualt_AAV
            // 
            groupBoxResualt_AAV.Controls.Add(textBox1);
            groupBoxResualt_AAV.Controls.Add(textBoxResult_AAV);
            groupBoxResualt_AAV.Location = new Point(430, 234);
            groupBoxResualt_AAV.Name = "groupBoxResualt_AAV";
            groupBoxResualt_AAV.Size = new Size(341, 143);
            groupBoxResualt_AAV.TabIndex = 8;
            groupBoxResualt_AAV.TabStop = false;
            groupBoxResualt_AAV.Text = "Вывод данных";
            // 
            // buttonHelp_AAV
            // 
            buttonHelp_AAV.Location = new Point(558, 393);
            buttonHelp_AAV.Name = "buttonHelp_AAV";
            buttonHelp_AAV.Size = new Size(40, 36);
            buttonHelp_AAV.TabIndex = 9;
            buttonHelp_AAV.Text = "?";
            buttonHelp_AAV.UseVisualStyleBackColor = true;
            buttonHelp_AAV.Click += buttonHelp_AAV_Click;
            // 
            // buttonDone_AAV
            // 
            buttonDone_AAV.Location = new Point(613, 390);
            buttonDone_AAV.Name = "buttonDone_AAV";
            buttonDone_AAV.Size = new Size(131, 43);
            buttonDone_AAV.TabIndex = 10;
            buttonDone_AAV.Text = "Выполнить";
            buttonDone_AAV.UseVisualStyleBackColor = true;
            buttonDone_AAV.Click += buttonDone_AAV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_AAV);
            Controls.Add(buttonHelp_AAV);
            Controls.Add(groupBoxResualt_AAV);
            Controls.Add(groupBoxХ_AAV);
            Controls.Add(groupBoxTask_AAV);
            Name = "Form1";
            Text = "Спринт 6| Таск 0 |Вариант 19 | Ароян А.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormul_AAV).EndInit();
            groupBoxTask_AAV.ResumeLayout(false);
            groupBoxTask_AAV.PerformLayout();
            groupBoxХ_AAV.ResumeLayout(false);
            groupBoxХ_AAV.PerformLayout();
            groupBoxResualt_AAV.ResumeLayout(false);
            groupBoxResualt_AAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxVarX_AAV;
        private TextBox textBoxResult_AAV;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBoxFormul_AAV;
        private GroupBox groupBoxTask_AAV;
        private GroupBox groupBoxХ_AAV;
        private GroupBox groupBoxResualt_AAV;
        private Button buttonHelp_AAV;
        private Button buttonDone_AAV;
    }
}
