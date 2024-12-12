using Tyuiu.UhalovAK.Sprint6.Task5.V12.Lib;

namespace Tyuiu.UhalovAK.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Пользователь\source\repos\Tyuiu.DudkovIE.Sprint6\Tyuiu.DudkovIE.Sprint6.Task5.V12\bin\Debug\InPutFileTask5V12.txt";
        private void Button_Done_DIE_Click(object sender, EventArgs e)
        {
            DataGridView_Result_DIE.ColumnCount = 2;
            DataGridView_Result_DIE.Columns[0].Width = 20;
            DataGridView_Result_DIE.Columns[1].Width = 50;

            this.Chart_Result_DIE.ChartAreas[0].AxisX.Title = "Ось X";
            this.Chart_Result_DIE.ChartAreas[0].AxisY.Title = "Ось Y";

            Chart_Result_DIE.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                DataGridView_Result_DIE.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                Chart_Result_DIE.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void Button_OpenFile_DIE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-24-1 Ухалов Арсений Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}