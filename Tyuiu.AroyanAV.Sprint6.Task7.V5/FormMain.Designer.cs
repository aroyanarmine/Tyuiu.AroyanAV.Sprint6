namespace Tyuiu.AroyanAV.Sprint6.Task7.V5
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
            panel1 = new Panel();
            groupBoxInput_AAV = new GroupBox();
            dataGridViewIn_AAV = new TextBox();
            panel2 = new Panel();
            groupBoxOutput_AAV = new GroupBox();
            dataGridViewOut_AAV = new TextBox();
            panel3 = new Panel();
            groupBoxtask_AAV = new GroupBox();
            textBoxtask_AAV = new TextBox();
            panel4 = new Panel();
            buttonHelp_AAV = new Button();
            buttonSave_AAV = new Button();
            buttonExecute_AAV = new Button();
            buttonOpen_AAV = new Button();
            openFileDialog_AAV = new OpenFileDialog();
            saveFileDialog_AAV = new SaveFileDialog();
            toolTip_AAV = new ToolTip(components);
            panel1.SuspendLayout();
            groupBoxInput_AAV.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutput_AAV.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxtask_AAV.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxInput_AAV);
            panel1.Location = new Point(12, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 383);
            panel1.TabIndex = 0;
            // 
            // groupBoxInput_AAV
            // 
            groupBoxInput_AAV.Controls.Add(dataGridViewIn_AAV);
            groupBoxInput_AAV.Location = new Point(3, 7);
            groupBoxInput_AAV.Name = "groupBoxInput_AAV";
            groupBoxInput_AAV.Size = new Size(419, 376);
            groupBoxInput_AAV.TabIndex = 3;
            groupBoxInput_AAV.TabStop = false;
            groupBoxInput_AAV.Text = "Ввод";
            // 
            // dataGridViewIn_AAV
            // 
            dataGridViewIn_AAV.BackColor = SystemColors.ScrollBar;
            dataGridViewIn_AAV.Location = new Point(21, 26);
            dataGridViewIn_AAV.Multiline = true;
            dataGridViewIn_AAV.Name = "dataGridViewIn_AAV";
            dataGridViewIn_AAV.Size = new Size(374, 339);
            dataGridViewIn_AAV.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput_AAV);
            panel2.Location = new Point(440, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 383);
            panel2.TabIndex = 1;
            // 
            // groupBoxOutput_AAV
            // 
            groupBoxOutput_AAV.Controls.Add(dataGridViewOut_AAV);
            groupBoxOutput_AAV.Location = new Point(3, 7);
            groupBoxOutput_AAV.Name = "groupBoxOutput_AAV";
            groupBoxOutput_AAV.Size = new Size(404, 373);
            groupBoxOutput_AAV.TabIndex = 4;
            groupBoxOutput_AAV.TabStop = false;
            groupBoxOutput_AAV.Text = "Вывод";
            // 
            // dataGridViewOut_AAV
            // 
            dataGridViewOut_AAV.BackColor = SystemColors.ScrollBar;
            dataGridViewOut_AAV.Location = new Point(24, 28);
            dataGridViewOut_AAV.Multiline = true;
            dataGridViewOut_AAV.Name = "dataGridViewOut_AAV";
            dataGridViewOut_AAV.Size = new Size(374, 339);
            dataGridViewOut_AAV.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxtask_AAV);
            panel3.Location = new Point(12, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(838, 123);
            panel3.TabIndex = 2;
            // 
            // groupBoxtask_AAV
            // 
            groupBoxtask_AAV.Controls.Add(textBoxtask_AAV);
            groupBoxtask_AAV.Location = new Point(0, 0);
            groupBoxtask_AAV.Name = "groupBoxtask_AAV";
            groupBoxtask_AAV.Size = new Size(838, 143);
            groupBoxtask_AAV.TabIndex = 1;
            groupBoxtask_AAV.TabStop = false;
            groupBoxtask_AAV.Text = "Условие";
            // 
            // textBoxtask_AAV
            // 
            textBoxtask_AAV.BackColor = SystemColors.Menu;
            textBoxtask_AAV.BorderStyle = BorderStyle.None;
            textBoxtask_AAV.Location = new Point(82, 24);
            textBoxtask_AAV.Multiline = true;
            textBoxtask_AAV.Name = "textBoxtask_AAV";
            textBoxtask_AAV.Size = new Size(726, 112);
            textBoxtask_AAV.TabIndex = 0;
            textBoxtask_AAV.Text = resources.GetString("textBoxtask_AAV.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonHelp_AAV);
            panel4.Controls.Add(buttonSave_AAV);
            panel4.Controls.Add(buttonExecute_AAV);
            panel4.Controls.Add(buttonOpen_AAV);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 106);
            panel4.TabIndex = 2;
            // 
            // buttonHelp_AAV
            // 
            buttonHelp_AAV.BackColor = SystemColors.ControlLightLight;
            buttonHelp_AAV.Image = (Image)resources.GetObject("buttonHelp_AAV.Image");
            buttonHelp_AAV.Location = new Point(714, 16);
            buttonHelp_AAV.Name = "buttonHelp_AAV";
            buttonHelp_AAV.Size = new Size(94, 72);
            buttonHelp_AAV.TabIndex = 3;
            buttonHelp_AAV.UseVisualStyleBackColor = false;
            buttonHelp_AAV.Click += buttonHelp_AAV_Click;
            // 
            // buttonSave_AAV
            // 
            buttonSave_AAV.BackColor = SystemColors.ControlLightLight;
            buttonSave_AAV.Image = (Image)resources.GetObject("buttonSave_AAV.Image");
            buttonSave_AAV.Location = new Point(251, 16);
            buttonSave_AAV.Name = "buttonSave_AAV";
            buttonSave_AAV.Size = new Size(94, 72);
            buttonSave_AAV.TabIndex = 2;
            buttonSave_AAV.UseVisualStyleBackColor = false;
            buttonSave_AAV.Click += buttonSave_AAV_Click;
            // 
            // buttonExecute_AAV
            // 
            buttonExecute_AAV.BackColor = SystemColors.ControlLightLight;
            buttonExecute_AAV.Image = (Image)resources.GetObject("buttonExecute_AAV.Image");
            buttonExecute_AAV.Location = new Point(136, 16);
            buttonExecute_AAV.Name = "buttonExecute_AAV";
            buttonExecute_AAV.Size = new Size(94, 72);
            buttonExecute_AAV.TabIndex = 1;
            buttonExecute_AAV.UseVisualStyleBackColor = false;
            buttonExecute_AAV.Click += buttonExecute_AAV_Click;
            // 
            // buttonOpen_AAV
            // 
            buttonOpen_AAV.BackColor = SystemColors.ControlLightLight;
            buttonOpen_AAV.Image = (Image)resources.GetObject("buttonOpen_AAV.Image");
            buttonOpen_AAV.Location = new Point(24, 16);
            buttonOpen_AAV.Name = "buttonOpen_AAV";
            buttonOpen_AAV.Size = new Size(97, 72);
            buttonOpen_AAV.TabIndex = 0;
            buttonOpen_AAV.UseVisualStyleBackColor = false;
            buttonOpen_AAV.Click += buttonOpen_AAV_Click;
            // 
            // openFileDialog_AAV
            // 
            openFileDialog_AAV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 653);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 5 | Ароян А.В";
            panel1.ResumeLayout(false);
            groupBoxInput_AAV.ResumeLayout(false);
            groupBoxInput_AAV.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutput_AAV.ResumeLayout(false);
            groupBoxOutput_AAV.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxtask_AAV.ResumeLayout(false);
            groupBoxtask_AAV.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBoxtask_AAV;
        private TextBox textBoxtask_AAV;
        private Panel panel4;
        private TextBox dataGridViewIn_AAV;
        private TextBox dataGridViewOut_AAV;
        private GroupBox groupBoxInput_AAV;
        private GroupBox groupBoxOutput_AAV;
        private Button buttonSave_AAV;
        private Button buttonExecute_AAV;
        private Button buttonOpen_AAV;
        private Button buttonHelp_AAV;
        private OpenFileDialog openFileDialog_AAV;
        private SaveFileDialog saveFileDialog_AAV;
        private ToolTip toolTip_AAV;
    }
}
