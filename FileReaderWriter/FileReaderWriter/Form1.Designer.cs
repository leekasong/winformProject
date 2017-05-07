namespace FileReaderWriter
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
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.txt_Save = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pgbView = new System.Windows.Forms.ProgressBar();
            this.lb_Per = new System.Windows.Forms.Label();
            this.btn_Mtf = new System.Windows.Forms.Button();
            this.btn_Ftm = new System.Windows.Forms.Button();
            this.sfd_Save = new System.Windows.Forms.SaveFileDialog();
            this.ofd_Find = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(12, 24);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(568, 25);
            this.txt_Find.TabIndex = 0;
            // 
            // txt_Save
            // 
            this.txt_Save.Location = new System.Drawing.Point(12, 83);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(568, 25);
            this.txt_Save.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(657, 26);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(126, 23);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "파일 찾기";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(657, 82);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "파일 저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pgbView
            // 
            this.pgbView.Location = new System.Drawing.Point(41, 154);
            this.pgbView.Name = "pgbView";
            this.pgbView.Size = new System.Drawing.Size(539, 23);
            this.pgbView.TabIndex = 4;
            // 
            // lb_Per
            // 
            this.lb_Per.AutoSize = true;
            this.lb_Per.Location = new System.Drawing.Point(9, 158);
            this.lb_Per.Name = "lb_Per";
            this.lb_Per.Size = new System.Drawing.Size(26, 15);
            this.lb_Per.TabIndex = 5;
            this.lb_Per.Text = "0%";
            // 
            // btn_Mtf
            // 
            this.btn_Mtf.Location = new System.Drawing.Point(724, 154);
            this.btn_Mtf.Name = "btn_Mtf";
            this.btn_Mtf.Size = new System.Drawing.Size(126, 23);
            this.btn_Mtf.TabIndex = 6;
            this.btn_Mtf.Text = "mem->file";
            this.btn_Mtf.UseVisualStyleBackColor = true;
            this.btn_Mtf.Click += new System.EventHandler(this.btn_Mtf_Click);
            // 
            // btn_Ftm
            // 
            this.btn_Ftm.Location = new System.Drawing.Point(587, 154);
            this.btn_Ftm.Name = "btn_Ftm";
            this.btn_Ftm.Size = new System.Drawing.Size(126, 23);
            this.btn_Ftm.TabIndex = 7;
            this.btn_Ftm.Text = "file->mem";
            this.btn_Ftm.UseVisualStyleBackColor = true;
            this.btn_Ftm.Click += new System.EventHandler(this.btn_Ftm_Click);
            // 
            // ofd_Find
            // 
            this.ofd_Find.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 192);
            this.Controls.Add(this.btn_Ftm);
            this.Controls.Add(this.btn_Mtf);
            this.Controls.Add(this.lb_Per);
            this.Controls.Add(this.pgbView);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Save);
            this.Controls.Add(this.txt_Find);
            this.Name = "Form1";
            this.Text = "파일 읽기 쓰기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.TextBox txt_Save;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ProgressBar pgbView;
        private System.Windows.Forms.Label lb_Per;
        private System.Windows.Forms.Button btn_Mtf;
        private System.Windows.Forms.Button btn_Ftm;
        private System.Windows.Forms.SaveFileDialog sfd_Save;
        private System.Windows.Forms.OpenFileDialog ofd_Find;
    }
}

