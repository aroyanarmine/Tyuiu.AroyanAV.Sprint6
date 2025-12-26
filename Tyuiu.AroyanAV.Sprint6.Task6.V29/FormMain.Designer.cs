namespace Tyuiu.AroyanAV.Sprint6.Task6.V29
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxInput_AAV = new TextBox();
            textBoxOutput_AAV = new TextBox();
            groupBoxInput_AAV = new GroupBox();
            vScrollBar1 = new VScrollBar();
            groupBoxOutput_AAV = new GroupBox();
            vScrollBar2 = new VScrollBar();
            buttonLoad_AAV = new PictureBox();
            buttonStart_AAV = new PictureBox();
            buttonHelp_AVV = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBoxInput_AAV.SuspendLayout();
            groupBoxOutput_AAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonLoad_AAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonStart_AAV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonHelp_AVV).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(19, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(741, 70);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(22, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxInput_AAV
            // 
            textBoxInput_AAV.Location = new Point(22, 234);
            textBoxInput_AAV.Multiline = true;
            textBoxInput_AAV.Name = "textBoxInput_AAV";
            textBoxInput_AAV.Size = new Size(350, 336);
            textBoxInput_AAV.TabIndex = 2;
            textBoxInput_AAV.TextChanged += textBoxInput_AAV_TextChanged;
            // 
            // textBoxOutput_AAV
            // 
            textBoxOutput_AAV.Location = new Point(404, 234);
            textBoxOutput_AAV.Multiline = true;
            textBoxOutput_AAV.Name = "textBoxOutput_AAV";
            textBoxOutput_AAV.Size = new Size(363, 336);
            textBoxOutput_AAV.TabIndex = 3;
            // 
            // groupBoxInput_AAV
            // 
            groupBoxInput_AAV.Controls.Add(vScrollBar1);
            groupBoxInput_AAV.Location = new Point(22, 211);
            groupBoxInput_AAV.Name = "groupBoxInput_AAV";
            groupBoxInput_AAV.Size = new Size(376, 369);
            groupBoxInput_AAV.TabIndex = 4;
            groupBoxInput_AAV.TabStop = false;
            groupBoxInput_AAV.Text = "Ввод";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(350, 11);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 348);
            vScrollBar1.TabIndex = 0;
            // 
            // groupBoxOutput_AAV
            // 
            groupBoxOutput_AAV.Controls.Add(vScrollBar2);
            groupBoxOutput_AAV.Location = new Point(404, 211);
            groupBoxOutput_AAV.Name = "groupBoxOutput_AAV";
            groupBoxOutput_AAV.Size = new Size(384, 369);
            groupBoxOutput_AAV.TabIndex = 5;
            groupBoxOutput_AAV.TabStop = false;
            groupBoxOutput_AAV.Text = "Вывод";
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(358, 11);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(26, 348);
            vScrollBar2.TabIndex = 1;
            // 
            // buttonLoad_AAV
            // 
            buttonLoad_AAV.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad_AAV.Cursor = Cursors.No;
            buttonLoad_AAV.Image = (Image)resources.GetObject("buttonLoad_AAV.Image");
            buttonLoad_AAV.Location = new Point(22, 9);
            buttonLoad_AAV.Name = "buttonLoad_AAV";
            buttonLoad_AAV.Size = new Size(78, 62);
            buttonLoad_AAV.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonLoad_AAV.TabIndex = 6;
            buttonLoad_AAV.TabStop = false;
            toolTip1.SetToolTip(buttonLoad_AAV, "Открыть файл");
            buttonLoad_AAV.Click += pictureBox1_Click;
            // 
            // buttonStart_AAV
            // 
            buttonStart_AAV.BackgroundImageLayout = ImageLayout.Center;
            buttonStart_AAV.Cursor = Cursors.No;
            buttonStart_AAV.Image = (Image)resources.GetObject("buttonStart_AAV.Image");
            buttonStart_AAV.Location = new Point(115, 9);
            buttonStart_AAV.Name = "buttonStart_AAV";
            buttonStart_AAV.Size = new Size(78, 62);
            buttonStart_AAV.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonStart_AAV.TabIndex = 7;
            buttonStart_AAV.TabStop = false;
            toolTip1.SetToolTip(buttonStart_AAV, "Вывести слова в которых встречается i");
            buttonStart_AAV.Click += buttonStart_AAV_Click;
            // 
            // buttonHelp_AVV
            // 
            buttonHelp_AVV.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_AVV.Cursor = Cursors.No;
            buttonHelp_AVV.Image = (Image)resources.GetObject("buttonHelp_AVV.Image");
            buttonHelp_AVV.Location = new Point(689, 9);
            buttonHelp_AVV.Name = "buttonHelp_AVV";
            buttonHelp_AVV.Size = new Size(78, 62);
            buttonHelp_AVV.SizeMode = PictureBoxSizeMode.CenterImage;
            buttonHelp_AVV.TabIndex = 8;
            buttonHelp_AVV.TabStop = false;
            toolTip1.SetToolTip(buttonHelp_AVV, "Сведения о программе");
            buttonHelp_AVV.Click += buttonHelp_AVV_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 582);
            Controls.Add(buttonHelp_AVV);
            Controls.Add(buttonStart_AAV);
            Controls.Add(buttonLoad_AAV);
            Controls.Add(textBoxOutput_AAV);
            Controls.Add(groupBoxOutput_AAV);
            Controls.Add(textBoxInput_AAV);
            Controls.Add(groupBoxInput_AAV);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInput_AAV.ResumeLayout(false);
            groupBoxOutput_AAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonLoad_AAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonStart_AAV).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonHelp_AVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBoxInput_AAV;
        private TextBox textBoxOutput_AAV;
        private GroupBox groupBoxInput_AAV;
        private VScrollBar vScrollBar1;
        private GroupBox groupBoxOutput_AAV;
        private VScrollBar vScrollBar2;
        private PictureBox buttonLoad_AAV;
        private PictureBox buttonStart_AAV;
        private PictureBox buttonHelp_AVV;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
    }
}
