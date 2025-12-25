
namespace Tyuiu.AroyanAV.Sprint6.Task1.V13
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

        private TextBox GetTextBoxtask_AAV()
        {
            return textBoxtask_AAV;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(TextBox textBoxtask_AAV)
        {
            textBoxresult_AAV = new TextBox();
            textBoxresullt_AAV = new TextBox();
            vScrollBarresult = new VScrollBar();
            groupBoxResult_AAV = new GroupBox();
            textBoxtask_AAV = new TextBox();
            groupBoxTask_AAV = new GroupBox();
            textBoxstart_AAV = new TextBox();
            textBoxend_AAV = new TextBox();
            textBoxStaart_AAV = new TextBox();
            textBoxEnnd_AAV = new TextBox();
            groupBoxdata = new GroupBox();
            buttonCalculate = new Button();
            AboutMenuItem = new Button();
            groupBoxResult_AAV.SuspendLayout();
            groupBoxTask_AAV.SuspendLayout();
            groupBoxdata.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxresult_AAV
            // 
            textBoxresult_AAV.BackColor = SystemColors.Menu;
            textBoxresult_AAV.BorderStyle = BorderStyle.None;
            textBoxresult_AAV.Location = new Point(24, 39);
            textBoxresult_AAV.Name = "textBoxresult_AAV";
            textBoxresult_AAV.Size = new Size(125, 20);
            textBoxresult_AAV.TabIndex = 0;
            textBoxresult_AAV.Text = "Результат";
            // 
            // textBoxresullt_AAV
            // 
            textBoxresullt_AAV.Location = new Point(24, 65);
            textBoxresullt_AAV.Multiline = true;
            textBoxresullt_AAV.Name = "textBoxresullt_AAV";
            textBoxresullt_AAV.Size = new Size(216, 305);
            textBoxresullt_AAV.TabIndex = 1;
            // 
            // vScrollBarresult
            // 
            vScrollBarresult.Location = new Point(214, 81);
            vScrollBarresult.Name = "vScrollBarresult";
            vScrollBarresult.Size = new Size(26, 289);
            vScrollBarresult.TabIndex = 2;
            // 
            // groupBoxResult_AAV
            // 
            groupBoxResult_AAV.Controls.Add(textBoxresullt_AAV);
            groupBoxResult_AAV.Controls.Add(vScrollBarresult);
            groupBoxResult_AAV.Controls.Add(textBoxresult_AAV);
            groupBoxResult_AAV.Location = new Point(509, 36);
            groupBoxResult_AAV.Name = "groupBoxResult_AAV";
            groupBoxResult_AAV.Size = new Size(267, 386);
            groupBoxResult_AAV.TabIndex = 3;
            groupBoxResult_AAV.TabStop = false;
            groupBoxResult_AAV.Text = "Вывод данных";
            // 
            // textBoxtask_AAV
            // 
            textBoxtask_AAV.BackColor = SystemColors.Menu;
            textBoxtask_AAV.BorderStyle = BorderStyle.None;
            textBoxtask_AAV.ImeMode = ImeMode.NoControl;
            textBoxtask_AAV.Location = new Point(15, 48);
            textBoxtask_AAV.Multiline = true;
            textBoxtask_AAV.Name = "textBoxtask_AAV";
            textBoxtask_AAV.Size = new Size(412, 87);
            textBoxtask_AAV.TabIndex = 4;
            textBoxtask_AAV.Text = "Протабулировать функцию на заданном диапозоне. Результат вывести в виде таблицы. ";
            textBoxtask_AAV.TextChanged += textBoxtask_AAV_TextChanged;
            // 
            // groupBoxTask_AAV
            // 
            groupBoxTask_AAV.Controls.Add(textBoxtask_AAV);
            groupBoxTask_AAV.Location = new Point(27, 36);
            groupBoxTask_AAV.Name = "groupBoxTask_AAV";
            groupBoxTask_AAV.Size = new Size(463, 207);
            groupBoxTask_AAV.TabIndex = 5;
            groupBoxTask_AAV.TabStop = false;
            groupBoxTask_AAV.Text = "Условие";
            // 
            // textBoxstart_AAV
            // 
            textBoxstart_AAV.Location = new Point(11, 131);
            textBoxstart_AAV.Name = "textBoxstart_AAV";
            textBoxstart_AAV.Size = new Size(98, 27);
            textBoxstart_AAV.TabIndex = 6;
            // 
            // textBoxend_AAV
            // 
            textBoxend_AAV.Location = new Point(131, 131);
            textBoxend_AAV.Name = "textBoxend_AAV";
            textBoxend_AAV.Size = new Size(101, 27);
            textBoxend_AAV.TabIndex = 7;
            // 
            // textBoxStaart_AAV
            // 
            textBoxStaart_AAV.BackColor = SystemColors.Menu;
            textBoxStaart_AAV.BorderStyle = BorderStyle.None;
            textBoxStaart_AAV.Location = new Point(11, 105);
            textBoxStaart_AAV.Name = "textBoxStaart_AAV";
            textBoxStaart_AAV.Size = new Size(125, 20);
            textBoxStaart_AAV.TabIndex = 8;
            textBoxStaart_AAV.Text = "Старт шага";
            // 
            // textBoxEnnd_AAV
            // 
            textBoxEnnd_AAV.BackColor = SystemColors.Menu;
            textBoxEnnd_AAV.BorderStyle = BorderStyle.None;
            textBoxEnnd_AAV.Location = new Point(131, 105);
            textBoxEnnd_AAV.Name = "textBoxEnnd_AAV";
            textBoxEnnd_AAV.Size = new Size(125, 20);
            textBoxEnnd_AAV.TabIndex = 9;
            textBoxEnnd_AAV.Text = "Конец шага";
            // 
            // groupBoxdata
            // 
            groupBoxdata.Controls.Add(AboutMenuItem);
            groupBoxdata.Controls.Add(buttonCalculate);
            groupBoxdata.Controls.Add(textBoxend_AAV);
            groupBoxdata.Controls.Add(textBoxEnnd_AAV);
            groupBoxdata.Controls.Add(textBoxstart_AAV);
            groupBoxdata.Controls.Add(textBoxStaart_AAV);
            groupBoxdata.Location = new Point(27, 249);
            groupBoxdata.Name = "groupBoxdata";
            groupBoxdata.Size = new Size(463, 174);
            groupBoxdata.TabIndex = 10;
            groupBoxdata.TabStop = false;
            groupBoxdata.Text = "Ввод данных";
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.ForestGreen;
            buttonCalculate.Cursor = Cursors.No;
            buttonCalculate.FlatStyle = FlatStyle.Flat;
            buttonCalculate.Location = new Point(339, 105);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(108, 53);
            buttonCalculate.TabIndex = 11;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = false;
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.BackColor = SystemColors.ActiveCaption;
            AboutMenuItem.Cursor = Cursors.No;
            AboutMenuItem.FlatStyle = FlatStyle.Flat;
            AboutMenuItem.Location = new Point(250, 105);
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(83, 53);
            AboutMenuItem.TabIndex = 11;
            AboutMenuItem.Text = "Справка";
            AboutMenuItem.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxdata);
            Controls.Add(groupBoxTask_AAV);
            Controls.Add(groupBoxResult_AAV);
            Name = "Form1";
            Text = "Form1";
            groupBoxResult_AAV.ResumeLayout(false);
            groupBoxResult_AAV.PerformLayout();
            groupBoxTask_AAV.ResumeLayout(false);
            groupBoxTask_AAV.PerformLayout();
            groupBoxdata.ResumeLayout(false);
            groupBoxdata.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxtask_AAV_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxresult_AAV;
        private TextBox textBoxresullt_AAV;
        private VScrollBar vScrollBarresult;
        private GroupBox groupBoxResult_AAV;
        private TextBox textBoxtask_AAV;
        private GroupBox groupBoxTask_AAV;
        private TextBox textBoxstart_AAV;
        private TextBox textBoxend_AAV;
        private TextBox textBoxStaart_AAV;
        private TextBox textBoxEnnd_AAV;
        private GroupBox groupBoxdata;
        private Button buttonCalculate;
        private Button AboutMenuItem;
    }
}
