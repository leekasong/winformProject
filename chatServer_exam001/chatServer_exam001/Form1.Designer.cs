namespace chatServer_exam001
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
            this.ChatText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ServerIp = new System.Windows.Forms.TextBox();
            this.ServerConnect_Btn = new System.Windows.Forms.Button();
            this.ServerStop_btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Send_Btn = new System.Windows.Forms.Button();
            this.txt_all = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatText
            // 
            this.ChatText.Location = new System.Drawing.Point(12, 352);
            this.ChatText.Name = "ChatText";
            this.ChatText.Size = new System.Drawing.Size(333, 25);
            this.ChatText.TabIndex = 1;
            this.ChatText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatText_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ServerIp);
            this.groupBox1.Controls.Add(this.ServerConnect_Btn);
            this.groupBox1.Controls.Add(this.ServerStop_btn);
            this.groupBox1.Location = new System.Drawing.Point(379, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_ServerIp
            // 
            this.txt_ServerIp.Location = new System.Drawing.Point(27, 124);
            this.txt_ServerIp.Name = "txt_ServerIp";
            this.txt_ServerIp.Size = new System.Drawing.Size(179, 25);
            this.txt_ServerIp.TabIndex = 2;
            // 
            // ServerConnect_Btn
            // 
            this.ServerConnect_Btn.Location = new System.Drawing.Point(27, 82);
            this.ServerConnect_Btn.Name = "ServerConnect_Btn";
            this.ServerConnect_Btn.Size = new System.Drawing.Size(179, 23);
            this.ServerConnect_Btn.TabIndex = 1;
            this.ServerConnect_Btn.Text = "서버 연결";
            this.ServerConnect_Btn.UseVisualStyleBackColor = true;
            this.ServerConnect_Btn.Click += new System.EventHandler(this.ServerConnect_Btn_Click);
            // 
            // ServerStop_btn
            // 
            this.ServerStop_btn.Location = new System.Drawing.Point(27, 34);
            this.ServerStop_btn.Name = "ServerStop_btn";
            this.ServerStop_btn.Size = new System.Drawing.Size(179, 23);
            this.ServerStop_btn.TabIndex = 0;
            this.ServerStop_btn.Text = "서버 켜기";
            this.ServerStop_btn.UseVisualStyleBackColor = true;
            this.ServerStop_btn.Click += new System.EventHandler(this.ServerStop_btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Location = new System.Drawing.Point(379, 294);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(222, 23);
            this.Exit_Btn.TabIndex = 3;
            this.Exit_Btn.Text = "프로그램 종료";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(379, 351);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(222, 23);
            this.Send_Btn.TabIndex = 4;
            this.Send_Btn.Text = "보내기";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // txt_all
            // 
            this.txt_all.Location = new System.Drawing.Point(12, 24);
            this.txt_all.Multiline = true;
            this.txt_all.Name = "txt_all";
            this.txt_all.Size = new System.Drawing.Size(333, 293);
            this.txt_all.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 408);
            this.Controls.Add(this.txt_all);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChatText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ServerIp;
        private System.Windows.Forms.Button ServerConnect_Btn;
        private System.Windows.Forms.Button ServerStop_btn;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.TextBox txt_all;
    }
}

