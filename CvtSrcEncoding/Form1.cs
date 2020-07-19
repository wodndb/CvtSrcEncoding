using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CvtSrcEncoding
{
    public partial class Form1 : Form
    {
        private const string dirSelectDialogue = "Select the directory that includes files what you want convert endcodings";

        private string[] fileExtensionList = { "*.h", "*.cpp", "*.cs", "*.txt" };

        public enum EncodingType
        {
            Default,
            ASCII,
            UTF7,
            UTF8,
            Unicode,
            BigEndianUnicode,
            UTF32
        }

        public Encoding GetEncoding(EncodingType type)
        {
            switch (type)
            {
                case EncodingType.Default:
                    return Encoding.Default;
                case EncodingType.ASCII:
                    return Encoding.ASCII;
                case EncodingType.UTF7:
                    return Encoding.UTF7;
                case EncodingType.UTF8:
                    return Encoding.UTF8;
                case EncodingType.Unicode:
                    return Encoding.Unicode;
                case EncodingType.BigEndianUnicode:
                    return Encoding.BigEndianUnicode;
                case EncodingType.UTF32:
                    return Encoding.UTF32;
            }

            return Encoding.Default;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mComboBoxEncodingOption.DataSource = Enum.GetValues(typeof(EncodingType));
            mComboBoxEncodingOption.SelectedIndex = 0;
            mComboBoxFileExtensionOption.DataSource = fileExtensionList;
            mComboBoxFileExtensionOption.SelectedIndex = 0;
        }

        private void mButtonSelectDirectory_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.Description = dirSelectDialogue;
            dialog.ShowDialog();
            mTextBoxDirectoryPath.Text = dialog.SelectedPath;
        }

        /// <summary>
        /// ref: https://stackoverflow.com/questions/279673/save-all-files-in-visual-studio-project-as-utf-8
        /// </summary>
        private void mButtonConvert_Click(object sender, EventArgs e)
        {
            var fileExtension = mComboBoxFileExtensionOption.SelectedItem as string;

            if(mTextBoxDirectoryPath.Text.Length == 0)
            {
                MessageBox.Show("Directory path is empty");
                return;
            }
            if(!Directory.Exists(mTextBoxDirectoryPath.Text))
            {
                MessageBox.Show("Directory is not exist");
                return;
            }
            if (fileExtension.Length == 0)
            {
                MessageBox.Show("File extension options is empty");
                return;
            }

            var dirFiles = new DirectoryInfo(mTextBoxDirectoryPath.Text).GetFiles(fileExtension, SearchOption.AllDirectories);
            var dirFilesLen = dirFiles.Length;

            if(dirFilesLen == 0)
            {
                MessageBox.Show("Files are not exist. Please set file extension option properly. (e.g. *.cs)");
                return;
            }

            var idx = mComboBoxEncodingOption.SelectedIndex;
            EncodingType encodingType = (EncodingType) idx;

            mToolStripProgressBar.Maximum = dirFilesLen;
            for (int i = 0; i < dirFilesLen; i++)
            {
                string s = File.ReadAllText(dirFiles[i].FullName);
                File.WriteAllText(dirFiles[i].FullName, s, GetEncoding(encodingType));
                mTooltipStatusLableProgressStatus.Text = $"({i + 1}/{dirFilesLen})";
                mToolStripProgressBar.Value = i + 1;
            }

            MessageBox.Show($"{dirFilesLen} files are converted to {encodingType}");

            mTooltipStatusLableProgressStatus.Text = "Finished";
        }
    }
}
