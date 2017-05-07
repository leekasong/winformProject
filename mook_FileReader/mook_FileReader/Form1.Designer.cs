namespace mook_FileReader
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
            this.txtView = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnAllRead = new System.Windows.Forms.Button();
            this.btnLineRead = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(446, 25);
            this.txtPath.TabIndex = 0;
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(12, 120);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtView.Size = new System.Drawing.Size(599, 254);
            this.txtView.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(487, 11);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(124, 23);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "파일";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnAllRead
            // 
            this.btnAllRead.Location = new System.Drawing.Point(334, 73);
            this.btnAllRead.Name = "btnAllRead";
            this.btnAllRead.Size = new System.Drawing.Size(124, 23);
            this.btnAllRead.TabIndex = 3;
            this.btnAllRead.Text = "전체읽기";
            this.btnAllRead.UseVisualStyleBackColor = true;
            this.btnAllRead.Click += new System.EventHandler(this.btnAllRead_Click);
            // 
            // btnLineRead
            // 
            this.btnLineRead.Location = new System.Drawing.Point(487, 73);
            this.btnLineRead.Name = "btnLineRead";
            this.btnLineRead.Size = new System.Drawing.Size(124, 23);
            this.btnLineRead.TabIndex = 4;
            this.btnLineRead.Text = "라인읽기";
            this.btnLineRead.UseVisualStyleBackColor = true;
            this.btnLineRead.Click += new System.EventHandler(this.btnLineRead_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 415);
            this.Controls.Add(this.btnLineRead);
            this.Controls.Add(this.btnAllRead);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.txtPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 읽기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnAllRead;
        private System.Windows.Forms.Button btnLineRead;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

