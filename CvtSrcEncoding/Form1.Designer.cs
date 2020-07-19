namespace CvtSrcEncoding
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mTextBoxDirectoryPath = new System.Windows.Forms.TextBox();
            this.mButtonSelectDirectory = new System.Windows.Forms.Button();
            this.mLabelDirectoryPath = new System.Windows.Forms.Label();
            this.mLabelEncodingOption = new System.Windows.Forms.Label();
            this.mButtonConvert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mToolStripStatusProgressTitleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mTooltipStatusLableProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.mComboBoxEncodingOption = new System.Windows.Forms.ComboBox();
            this.mComboBoxFileExtensionOption = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTextBoxDirectoryPath
            // 
            this.mTextBoxDirectoryPath.Location = new System.Drawing.Point(82, 13);
            this.mTextBoxDirectoryPath.Name = "mTextBoxDirectoryPath";
            this.mTextBoxDirectoryPath.Size = new System.Drawing.Size(401, 21);
            this.mTextBoxDirectoryPath.TabIndex = 0;
            // 
            // mButtonSelectDirectory
            // 
            this.mButtonSelectDirectory.Location = new System.Drawing.Point(497, 12);
            this.mButtonSelectDirectory.Name = "mButtonSelectDirectory";
            this.mButtonSelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.mButtonSelectDirectory.TabIndex = 1;
            this.mButtonSelectDirectory.Text = "Select";
            this.mButtonSelectDirectory.UseVisualStyleBackColor = true;
            this.mButtonSelectDirectory.Click += new System.EventHandler(this.mButtonSelectDirectory_Click);
            // 
            // mLabelDirectoryPath
            // 
            this.mLabelDirectoryPath.AutoSize = true;
            this.mLabelDirectoryPath.Location = new System.Drawing.Point(13, 18);
            this.mLabelDirectoryPath.Name = "mLabelDirectoryPath";
            this.mLabelDirectoryPath.Size = new System.Drawing.Size(63, 12);
            this.mLabelDirectoryPath.TabIndex = 2;
            this.mLabelDirectoryPath.Text = "Directory :";
            // 
            // mLabelEncodingOption
            // 
            this.mLabelEncodingOption.AutoSize = true;
            this.mLabelEncodingOption.Location = new System.Drawing.Point(13, 51);
            this.mLabelEncodingOption.Name = "mLabelEncodingOption";
            this.mLabelEncodingOption.Size = new System.Drawing.Size(70, 12);
            this.mLabelEncodingOption.TabIndex = 3;
            this.mLabelEncodingOption.Text = "Encoding : ";
            // 
            // mButtonConvert
            // 
            this.mButtonConvert.Location = new System.Drawing.Point(497, 47);
            this.mButtonConvert.Name = "mButtonConvert";
            this.mButtonConvert.Size = new System.Drawing.Size(75, 23);
            this.mButtonConvert.TabIndex = 5;
            this.mButtonConvert.Text = "Convert";
            this.mButtonConvert.UseVisualStyleBackColor = true;
            this.mButtonConvert.Click += new System.EventHandler(this.mButtonConvert_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripStatusProgressTitleLabel,
            this.mToolStripProgressBar,
            this.toolStripStatusLabel2,
            this.mTooltipStatusLableProgressStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 79);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mToolStripStatusProgressTitleLabel
            // 
            this.mToolStripStatusProgressTitleLabel.Name = "mToolStripStatusProgressTitleLabel";
            this.mToolStripStatusProgressTitleLabel.Size = new System.Drawing.Size(63, 17);
            this.mToolStripStatusProgressTitleLabel.Text = "Progress : ";
            // 
            // mToolStripProgressBar
            // 
            this.mToolStripProgressBar.Name = "mToolStripProgressBar";
            this.mToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "/";
            // 
            // mTooltipStatusLableProgressStatus
            // 
            this.mTooltipStatusLableProgressStatus.Name = "mTooltipStatusLableProgressStatus";
            this.mTooltipStatusLableProgressStatus.Size = new System.Drawing.Size(48, 17);
            this.mTooltipStatusLableProgressStatus.Text = "(Target)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Extension : ";
            // 
            // mComboBoxEncodingOption
            // 
            this.mComboBoxEncodingOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mComboBoxEncodingOption.FormattingEnabled = true;
            this.mComboBoxEncodingOption.Location = new System.Drawing.Point(89, 47);
            this.mComboBoxEncodingOption.Name = "mComboBoxEncodingOption";
            this.mComboBoxEncodingOption.Size = new System.Drawing.Size(120, 20);
            this.mComboBoxEncodingOption.TabIndex = 4;
            // 
            // mComboBoxFileExtensionOption
            // 
            this.mComboBoxFileExtensionOption.FormattingEnabled = true;
            this.mComboBoxFileExtensionOption.Location = new System.Drawing.Point(328, 48);
            this.mComboBoxFileExtensionOption.Name = "mComboBoxFileExtensionOption";
            this.mComboBoxFileExtensionOption.Size = new System.Drawing.Size(100, 20);
            this.mComboBoxFileExtensionOption.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 101);
            this.Controls.Add(this.mComboBoxFileExtensionOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mButtonConvert);
            this.Controls.Add(this.mComboBoxEncodingOption);
            this.Controls.Add(this.mLabelEncodingOption);
            this.Controls.Add(this.mLabelDirectoryPath);
            this.Controls.Add(this.mButtonSelectDirectory);
            this.Controls.Add(this.mTextBoxDirectoryPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convert Encoding of Source Codes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mTextBoxDirectoryPath;
        private System.Windows.Forms.Button mButtonSelectDirectory;
        private System.Windows.Forms.Label mLabelDirectoryPath;
        private System.Windows.Forms.Label mLabelEncodingOption;
        private System.Windows.Forms.Button mButtonConvert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mToolStripStatusProgressTitleLabel;
        private System.Windows.Forms.ToolStripProgressBar mToolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel mTooltipStatusLableProgressStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mComboBoxEncodingOption;
        private System.Windows.Forms.ComboBox mComboBoxFileExtensionOption;
    }
}

