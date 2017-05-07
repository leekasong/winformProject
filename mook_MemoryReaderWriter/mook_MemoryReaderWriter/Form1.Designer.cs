namespace mook_MemoryReaderWriter
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
            this.txtOpenPath = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.pgbLoad = new System.Windows.Forms.ProgressBar();
            this.btnMemLoad = new System.Windows.Forms.Button();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.lblPer = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtOpenPath
            // 
            this.txtOpenPath.Location = new System.Drawing.Point(48, 13);
            this.txtOpenPath.Name = "txtOpenPath";
            this.txtOpenPath.Size = new System.Drawing.Size(529, 25);
            this.txtOpenPath.TabIndex = 0;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(48, 64);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(529, 25);
            this.txtSavePath.TabIndex = 1;
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(605, 13);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(115, 23);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "파일 경로";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(605, 66);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(115, 23);
            this.btnSavePath.TabIndex = 3;
            this.btnSavePath.Text = "저장 경로";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(91, 220);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.Size = new System.Drawing.Size(629, 23);
            this.pgbLoad.TabIndex = 4;
            // 
            // btnMemLoad
            // 
            this.btnMemLoad.Location = new System.Drawing.Point(384, 149);
            this.btnMemLoad.Name = "btnMemLoad";
            this.btnMemLoad.Size = new System.Drawing.Size(165, 23);
            this.btnMemLoad.TabIndex = 5;
            this.btnMemLoad.Text = "파일->메모리";
            this.btnMemLoad.UseVisualStyleBackColor = true;
            this.btnMemLoad.Click += new System.EventHandler(this.btnMemLoad_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(555, 149);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(165, 23);
            this.btnFileSave.TabIndex = 6;
            this.btnFileSave.Text = "메모리->파일";
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(45, 220);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(26, 15);
            this.lblPer.TabIndex = 7;
            this.lblPer.Text = "0%";
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 273);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.btnFileSave);
            this.Controls.Add(this.btnMemLoad);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.txtOpenPath);
            this.Name = "Form1";
            this.Text = "메모리 읽기 쓰기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpenPath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.ProgressBar pgbLoad;
        private System.Windows.Forms.Button btnMemLoad;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}

