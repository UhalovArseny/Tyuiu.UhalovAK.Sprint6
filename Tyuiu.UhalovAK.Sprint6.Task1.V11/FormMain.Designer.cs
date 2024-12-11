namespace Tyuiu.UhalovAK.Sprint6.Task1.V11
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
            labelif = new Label();
            groupBox1 = new GroupBox();
            textBoxStartStep_UAK = new TextBox();
            textBoxStopStep_UAK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxResult_UAK = new TextBox();
            buttonStudent_UAK = new Button();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelif
            // 
            labelif.AutoSize = true;
            labelif.Location = new Point(12, 9);
            labelif.Name = "labelif";
            labelif.Size = new Size(53, 15);
            labelif.TabIndex = 0;
            labelif.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 115);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Протабулировать функцию F(x) на заданном диапозоне.";
            // 
            // textBoxStartStep_UAK
            // 
            textBoxStartStep_UAK.Location = new Point(12, 377);
            textBoxStartStep_UAK.Name = "textBoxStartStep_UAK";
            textBoxStartStep_UAK.Size = new Size(100, 23);
            textBoxStartStep_UAK.TabIndex = 2;
            // 
            // textBoxStopStep_UAK
            // 
            textBoxStopStep_UAK.Location = new Point(133, 377);
            textBoxStopStep_UAK.Name = "textBoxStopStep_UAK";
            textBoxStopStep_UAK.Size = new Size(100, 23);
            textBoxStopStep_UAK.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 359);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 359);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Конец шага";
            // 
            // textBoxResult_UAK
            // 
            textBoxResult_UAK.Location = new Point(465, 30);
            textBoxResult_UAK.Multiline = true;
            textBoxResult_UAK.Name = "textBoxResult_UAK";
            textBoxResult_UAK.Size = new Size(207, 370);
            textBoxResult_UAK.TabIndex = 6;
            // 
            // buttonStudent_UAK
            // 
            buttonStudent_UAK.Location = new Point(239, 359);
            buttonStudent_UAK.Name = "buttonStudent_UAK";
            buttonStudent_UAK.Size = new Size(51, 41);
            buttonStudent_UAK.TabIndex = 7;
            buttonStudent_UAK.Text = "?";
            buttonStudent_UAK.UseVisualStyleBackColor = true;
            buttonStudent_UAK.Click += buttonStudent_UAK_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(296, 359);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 8;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Результат";
            // 
            // FormMain
            // 
            ClientSize = new Size(684, 431);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(buttonStudent_UAK);
            Controls.Add(textBoxResult_UAK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStopStep_UAK);
            Controls.Add(textBoxStartStep_UAK);
            Controls.Add(groupBox1);
            Controls.Add(labelif);
            Name = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
