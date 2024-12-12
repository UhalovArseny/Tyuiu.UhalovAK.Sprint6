using Tyuiu.UhalovAK.Sprint6.Task4.V24.Lib;
namespace Tyuiu.UhalovAK.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void groupBoxLeft_SDA_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SDA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SDA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;


                double[] wait = new double[len];
                wait = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_SDA.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_SDA.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_SDA.Text = "";

                chartFunction_SDA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SDA.Series[0].Points.AddXY(startValue, wait[i]);
                    textBoxResult_SDA.AppendText(wait[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ������-24-1 ������ ������� ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V24.txt";
                File.WriteAllText(path, textBoxResult_SDA.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + "�������� �������!\n ������� ��� � �������� ?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}