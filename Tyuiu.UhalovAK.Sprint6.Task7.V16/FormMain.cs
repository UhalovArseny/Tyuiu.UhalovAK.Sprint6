using Tyuiu.UhalovAK.Sprint6.Task7.V16.Lib;

namespace Tyuiu.UhalovAK.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_BMS.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogMatrix_BMS.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";

        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        //����� ������ ������ �� �����
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            //���������� �� ������ 
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //���������� ���������� ����� � �������� 
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            //�������� ������ ������
            int[,] arrayValues = new int[rows, colums];

            //��������� ������ �������
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_BMS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_BMS_Click(object sender, EventArgs e)
        {
            //�������� ������ ������
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            //�������� ������ � dataGridViewOutMatrix_BMS
            for (int r = 0; r < colums; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_BMS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_BMS.Enabled = true;
        }

        private void buttonOpenFile_BMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BMS.ShowDialog();
            openFilePath = openFileDialogTask_BMS.FileName;

            //�������� ������ ������
            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_BMS.ColumnCount = colums;
            dataGridViewInMatrix_BMS.RowCount = rows;
            dataGridViewOutMatrix_BMS.ColumnCount = colums;
            dataGridViewOutMatrix_BMS.RowCount = rows;

            //������ ������ �������� dataGridViewInMatrix_BMS
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix_BMS.Columns[i].Width = 25;
                dataGridViewOutMatrix_BMS.Columns[i].Width = 25;
            }

            //�������� ������ � dataGridViewInMatrix_BMS
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_BMS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_BMS.Enabled = true;
        }

        private void buttonSaveFile_BMS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BMS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BMS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BMS.ShowDialog();

            string path = saveFileDialogMatrix_BMS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_BMS.RowCount;
            int colums = dataGridViewOutMatrix_BMS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutMatrix_BMS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_BMS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_BMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMS.ToolTipTitle = "������� ����";
        }

        private void buttonDone_BMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMS.ToolTipTitle = "���������";

        }

        private void buttonSaveFile_BMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMS.ToolTipTitle = "��������� � ����";

        }

        private void buttonHelp_BMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BMS.ToolTipTitle = "�������";

        }
    }
}
