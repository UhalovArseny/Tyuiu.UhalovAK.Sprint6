namespace Tyuiu.UhalovAK.Sprint6.Task0.V6
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
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            labelIF = new Label();
            textBoxVarX_UAK = new TextBox();
            textBoxResult_UAK = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(690, 398);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 40);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(652, 400);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(32, 36);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 161);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вычислить результат по формуле";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelIF
            // 
            labelIF.AutoSize = true;
            labelIF.Location = new Point(36, 17);
            labelIF.Name = "labelIF";
            labelIF.Size = new Size(53, 15);
            labelIF.TabIndex = 0;
            labelIF.Text = "Условие";
            labelIF.UseWaitCursor = true;
            labelIF.Click += labelIF_Click;
            // 
            // textBoxVarX_UAK
            // 
            textBoxVarX_UAK.Location = new Point(36, 354);
            textBoxVarX_UAK.Name = "textBoxVarX_UAK";
            textBoxVarX_UAK.Size = new Size(100, 23);
            textBoxVarX_UAK.TabIndex = 0;
            textBoxVarX_UAK.TextChanged += textBox1_TextChanged;
            // 
            // textBoxResult_UAK
            // 
            textBoxResult_UAK.Location = new Point(673, 354);
            textBoxResult_UAK.Name = "textBoxResult_UAK";
            textBoxResult_UAK.Size = new Size(100, 23);
            textBoxResult_UAK.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(671, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 76);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxResult_UAK);
            Controls.Add(textBoxVarX_UAK);
            Controls.Add(labelIF);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBox1;
        private Label labelIF;
        private TextBox textBoxVarX_UAK;
        private TextBox textBoxResult_UAK;
        private PictureBox pictureBox1;
    }
}
