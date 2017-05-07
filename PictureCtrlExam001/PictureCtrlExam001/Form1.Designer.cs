namespace PictureCtrlExam001
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
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.gb_sel = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lb_desc = new System.Windows.Forms.Label();
            this.cb_visible = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            this.gb_sel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_show
            // 
            this.pb_show.Image = global::PictureCtrlExam001.Properties.Resources.설현4;
            this.pb_show.Location = new System.Drawing.Point(178, 12);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(699, 532);
            this.pb_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_show.TabIndex = 0;
            this.pb_show.TabStop = false;
            this.pb_show.Visible = false;
            // 
            // gb_sel
            // 
            this.gb_sel.Controls.Add(this.rb4);
            this.gb_sel.Controls.Add(this.rb3);
            this.gb_sel.Controls.Add(this.rb2);
            this.gb_sel.Controls.Add(this.rb1);
            this.gb_sel.Location = new System.Drawing.Point(12, 12);
            this.gb_sel.Name = "gb_sel";
            this.gb_sel.Size = new System.Drawing.Size(147, 170);
            this.gb_sel.TabIndex = 1;
            this.gb_sel.TabStop = false;
            this.gb_sel.Text = "선택";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(7, 25);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(51, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1번";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(7, 59);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(51, 19);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2번";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 96);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(51, 19);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3번";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(7, 130);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(51, 19);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "4번";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(12, 304);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(147, 25);
            this.txt_desc.TabIndex = 2;
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Location = new System.Drawing.Point(9, 270);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(37, 15);
            this.lb_desc.TabIndex = 3;
            this.lb_desc.Text = "설명";
            // 
            // cb_visible
            // 
            this.cb_visible.AutoSize = true;
            this.cb_visible.Location = new System.Drawing.Point(12, 207);
            this.cb_visible.Name = "cb_visible";
            this.cb_visible.Size = new System.Drawing.Size(104, 19);
            this.cb_visible.TabIndex = 4;
            this.cb_visible.Text = "사진보이기";
            this.cb_visible.UseVisualStyleBackColor = true;
            this.cb_visible.CheckedChanged += new System.EventHandler(this.cb_visible_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.cb_visible);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.gb_sel);
            this.Controls.Add(this.pb_show);
            this.Name = "Form1";
            this.Text = "픽쳐박스";
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            this.gb_sel.ResumeLayout(false);
            this.gb_sel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_show;
        private System.Windows.Forms.GroupBox gb_sel;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.CheckBox cb_visible;
    }
}

