namespace mook_FileFinder
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.gbOption1 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnHidden = new System.Windows.Forms.RadioButton();
            this.gbOption2 = new System.Windows.Forms.GroupBox();
            this.rbDire = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.gbOption1.SuspendLayout();
            this.gbOption2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(73, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(645, 25);
            this.txtPath.TabIndex = 0;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(42, 15);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "경로:";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(737, 12);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // gbOption1
            // 
            this.gbOption1.Controls.Add(this.rbtnHidden);
            this.gbOption1.Controls.Add(this.rbtnAll);
            this.gbOption1.Location = new System.Drawing.Point(15, 70);
            this.gbOption1.Name = "gbOption1";
            this.gbOption1.Size = new System.Drawing.Size(173, 65);
            this.gbOption1.TabIndex = 3;
            this.gbOption1.TabStop = false;
            this.gbOption1.Text = "<선택1>";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(17, 34);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(43, 19);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnHidden
            // 
            this.rbtnHidden.AutoSize = true;
            this.rbtnHidden.Location = new System.Drawing.Point(82, 34);
            this.rbtnHidden.Name = "rbtnHidden";
            this.rbtnHidden.Size = new System.Drawing.Size(73, 19);
            this.rbtnHidden.TabIndex = 1;
            this.rbtnHidden.TabStop = true;
            this.rbtnHidden.Text = "Hidden";
            this.rbtnHidden.UseVisualStyleBackColor = true;
            this.rbtnHidden.CheckedChanged += new System.EventHandler(this.rbtnHidden_CheckedChanged);
            // 
            // gbOption2
            // 
            this.gbOption2.Controls.Add(this.rbDire);
            this.gbOption2.Controls.Add(this.rbFile);
            this.gbOption2.Location = new System.Drawing.Point(227, 70);
            this.gbOption2.Name = "gbOption2";
            this.gbOption2.Size = new System.Drawing.Size(180, 65);
            this.gbOption2.TabIndex = 4;
            this.gbOption2.TabStop = false;
            this.gbOption2.Text = "<선택2>";
            // 
            // rbDire
            // 
            this.rbDire.AutoSize = true;
            this.rbDire.Location = new System.Drawing.Point(86, 34);
            this.rbDire.Name = "rbDire";
            this.rbDire.Size = new System.Drawing.Size(88, 19);
            this.rbDire.TabIndex = 1;
            this.rbDire.TabStop = true;
            this.rbDire.Text = "디렉토리";
            this.rbDire.UseVisualStyleBackColor = true;
            this.rbDire.CheckedChanged += new System.EventHandler(this.rbDire_CheckedChanged);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(19, 34);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(58, 19);
            this.rbFile.TabIndex = 0;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "파일";
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.CheckedChanged += new System.EventHandler(this.rbFile_CheckedChanged);
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chFileName,
            this.chFileTime,
            this.chFileSize});
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(15, 172);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(1000, 388);
            this.lvFile.TabIndex = 5;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "파일 경로";
            this.chFilePath.Width = 297;
            // 
            // chFileName
            // 
            this.chFileName.Text = "파일 이름";
            this.chFileName.Width = 233;
            // 
            // chFileTime
            // 
            this.chFileTime.Text = "생성일";
            this.chFileTime.Width = 231;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "사이즈";
            this.chFileSize.Width = 243;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 586);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.gbOption2);
            this.Controls.Add(this.gbOption1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Find File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOption1.ResumeLayout(false);
            this.gbOption1.PerformLayout();
            this.gbOption2.ResumeLayout(false);
            this.gbOption2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox gbOption1;
        private System.Windows.Forms.RadioButton rbtnHidden;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.GroupBox gbOption2;
        private System.Windows.Forms.RadioButton rbDire;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileTime;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
    }
}

