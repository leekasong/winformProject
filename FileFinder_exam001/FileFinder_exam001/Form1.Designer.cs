namespace FileFinder_exam001
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
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lvPath = new System.Windows.Forms.ListView();
            this.lvcPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(23, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(42, 15);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "경로:";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(643, 33);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lvPath
            // 
            this.lvPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcPath,
            this.lvcName,
            this.lvcTime,
            this.lvcSize});
            this.lvPath.Location = new System.Drawing.Point(26, 82);
            this.lvPath.Name = "lvPath";
            this.lvPath.Size = new System.Drawing.Size(747, 370);
            this.lvPath.TabIndex = 3;
            this.lvPath.UseCompatibleStateImageBehavior = false;
            this.lvPath.View = System.Windows.Forms.View.Details;
            // 
            // lvcPath
            // 
            this.lvcPath.Text = "경로";
            this.lvcPath.Width = 281;
            // 
            // lvcName
            // 
            this.lvcName.Text = "이름";
            this.lvcName.Width = 155;
            // 
            // lvcTime
            // 
            this.lvcTime.Text = "생성시간";
            this.lvcTime.Width = 153;
            // 
            // lvcSize
            // 
            this.lvcSize.Text = "크기";
            this.lvcSize.Width = 147;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(71, 30);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(554, 25);
            this.txtPath.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 486);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lvPath);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ListView lvPath;
        private System.Windows.Forms.ColumnHeader lvcPath;
        private System.Windows.Forms.ColumnHeader lvcName;
        private System.Windows.Forms.ColumnHeader lvcTime;
        private System.Windows.Forms.ColumnHeader lvcSize;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
    }
}

