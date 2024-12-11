using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.UhalovAK.Sprint6.Task1.V11.Lib;
namespace Tyuiu.UhalovAK.Sprint6.Task1.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_UAK.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_UAK.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] arrayRes = new double[len];
                arrayRes = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_UAK.Text = "";
                textBoxResult_UAK.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_UAK.AppendText("|      X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_UAK.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = string.Format("| {0,6:d}    |  {1, 6:f2}   |", startStep, arrayRes[i]);
                    textBoxResult_UAK.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_UAK.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStudent_UAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-24-1 Ухалов Арсений Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        

        private Label labelif;
        private GroupBox groupBox1;
        private TextBox textBoxStartStep_UAK;
        private TextBox textBoxStopStep_UAK;
        private Label label1;
        private Label label2;
        private TextBox textBoxResult_UAK;
        private Button buttonStudent_UAK;
        private Button button1;
        private Label label3;
    }
}