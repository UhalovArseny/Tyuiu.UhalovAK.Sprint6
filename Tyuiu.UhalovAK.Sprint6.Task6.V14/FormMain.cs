using Tyuiu.UhalovAK.Sprint6.Task6.V14.Lib;

namespace Tyuiu.UhalovAK.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_IPG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IPG.ShowDialog();
            openFilePath = openFileDialogTask_IPG.FileName;
            textBoxInput_IPG.Text = File.ReadAllText(openFilePath);
            groupBoxInput_IPG.Text = groupBoxInput_IPG.Text + " " + openFileDialogTask_IPG.FileName;
            buttonOpenFile_IPG.Enabled = false;
            buttonDone_IPG.Enabled = true;
        }
        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            buttonOpenFile_IPG.Enabled = true;
            buttonDone_IPG.Enabled = false;
            textBoxOutput_IPG.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonHelp_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_LMV_Load(object sender, EventArgs e)
        {
        }
    }
}