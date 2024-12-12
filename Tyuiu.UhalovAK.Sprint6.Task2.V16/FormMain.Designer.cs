
namespace Tyuiu.UhalovAK.Sprint6.Task2.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelif = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxStart_UAK = new TextBox();
            textBoxStop_UAK = new TextBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            label3 = new Label();
            dataGridViewOutPut = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            chartOutPut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOutPut).BeginInit();
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
            labelif.Click += labelif_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(12, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 184);
            textBox1.TabIndex = 1;
            textBox1.Text = "Протабулировать фунцкию на заданном диапазоне";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 388);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Старт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 388);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Стоп";
            // 
            // textBoxStart_UAK
            // 
            textBoxStart_UAK.Location = new Point(26, 415);
            textBoxStart_UAK.Name = "textBoxStart_UAK";
            textBoxStart_UAK.Size = new Size(100, 23);
            textBoxStart_UAK.TabIndex = 4;
            // 
            // textBoxStop_UAK
            // 
            textBoxStop_UAK.Location = new Point(187, 415);
            textBoxStop_UAK.Name = "textBoxStop_UAK";
            textBoxStop_UAK.Size = new Size(100, 23);
            textBoxStop_UAK.TabIndex = 5;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(302, 397);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(78, 49);
            buttonInfo.TabIndex = 6;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(386, 397);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(90, 49);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Результат";
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewOutPut.Location = new Point(512, 27);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.RowHeadersVisible = false;
            dataGridViewOutPut.Size = new Size(117, 431);
            dataGridViewOutPut.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // chartOutPut
            // 
            chartArea1.Name = "ChartArea1";
            chartOutPut.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOutPut.Legends.Add(legend1);
            chartOutPut.Location = new Point(652, 46);
            chartOutPut.Name = "chartOutPut";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOutPut.Series.Add(series1);
            chartOutPut.Size = new Size(300, 300);
            chartOutPut.TabIndex = 10;
            chartOutPut.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 470);
            Controls.Add(chartOutPut);
            Controls.Add(dataGridViewOutPut);
            Controls.Add(label3);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxStop_UAK);
            Controls.Add(textBoxStart_UAK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelif);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOutPut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelif;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxStart_UAK;
        private TextBox textBoxStop_UAK;
        private Button buttonInfo;
        private Button buttonDone;
        private Label label3;
        private DataGridView dataGridViewOutPut;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPut;
    }
}
