namespace FileLoad.cs
{
    partial class FileLoad
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
            this.lblCopy = new System.Windows.Forms.Label();
            this.pgbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(32, 19);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(71, 15);
            this.lblCopy.TabIndex = 0;
            this.lblCopy.Text = "복사 : 0%";
            // 
            // pgbCopy
            // 
            this.pgbCopy.Location = new System.Drawing.Point(22, 48);
            this.pgbCopy.Name = "pgbCopy";
            this.pgbCopy.Size = new System.Drawing.Size(455, 23);
            this.pgbCopy.Step = 1;
            this.pgbCopy.TabIndex = 1;
            // 
            // FileLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 99);
            this.Controls.Add(this.pgbCopy);
            this.Controls.Add(this.lblCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileLoad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "파일 복사";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileLoad_FormClosing);
            this.Load += new System.EventHandler(this.FileLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.ProgressBar pgbCopy;
    }
}

