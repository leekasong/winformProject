namespace mook_FileCopyMove
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
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.lvSrc = new System.Windows.Forms.ListView();
            this.lvDest = new System.Windows.Forms.ListView();
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSrc = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.chFileSrc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspgrbar = new System.Windows.Forms.ToolStripProgressBar();
            this.gbBox.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 13);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(579, 25);
            this.txtSrc.TabIndex = 0;
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(597, 15);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 23);
            this.btnSrc.TabIndex = 1;
            this.btnSrc.Text = "FileSrc";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(12, 55);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(579, 25);
            this.txtDest.TabIndex = 2;
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(597, 57);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 3;
            this.btnDest.Text = "FileDest";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // lvSrc
            // 
            this.lvSrc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileSrc});
            this.lvSrc.Location = new System.Drawing.Point(12, 133);
            this.lvSrc.Name = "lvSrc";
            this.lvSrc.Size = new System.Drawing.Size(606, 370);
            this.lvSrc.TabIndex = 4;
            this.lvSrc.UseCompatibleStateImageBehavior = false;
            this.lvSrc.View = System.Windows.Forms.View.Details;
            // 
            // lvDest
            // 
            this.lvDest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileDest});
            this.lvDest.Location = new System.Drawing.Point(641, 133);
            this.lvDest.Name = "lvDest";
            this.lvDest.Size = new System.Drawing.Size(619, 370);
            this.lvDest.TabIndex = 5;
            this.lvDest.UseCompatibleStateImageBehavior = false;
            this.lvDest.View = System.Windows.Forms.View.Details;
            // 
            // gbBox
            // 
            this.gbBox.Controls.Add(this.rbMove);
            this.gbBox.Controls.Add(this.rbCopy);
            this.gbBox.Location = new System.Drawing.Point(740, 15);
            this.gbBox.Name = "gbBox";
            this.gbBox.Size = new System.Drawing.Size(358, 65);
            this.gbBox.TabIndex = 6;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "Choose";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(39, 23);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(85, 19);
            this.rbCopy.TabIndex = 0;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "FileCopy";
            this.rbCopy.UseVisualStyleBackColor = true;
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(173, 23);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(87, 19);
            this.rbMove.TabIndex = 1;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "FileMove";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1117, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(12, 112);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(37, 15);
            this.lblSrc.TabIndex = 8;
            this.lblSrc.Text = "대상";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(638, 112);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(37, 15);
            this.lblDest.TabIndex = 9;
            this.lblDest.Text = "결과";
            // 
            // ssBar
            // 
            this.ssBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl,
            this.tsslblStatus,
            this.tspgrbar});
            this.ssBar.Location = new System.Drawing.Point(0, 561);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(1272, 25);
            this.ssBar.TabIndex = 10;
            this.ssBar.Text = "statusStrip1";
            // 
            // chFileSrc
            // 
            this.chFileSrc.Text = "파일";
            this.chFileSrc.Width = 607;
            // 
            // chFileDest
            // 
            this.chFileDest.Text = "파일";
            this.chFileDest.Width = 615;
            // 
            // tsslbl
            // 
            this.tsslbl.Name = "tsslbl";
            this.tsslbl.Size = new System.Drawing.Size(72, 20);
            this.tsslbl.Text = "진행사항:";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(30, 20);
            this.tsslblStatus.Text = "0%";
            // 
            // tspgrbar
            // 
            this.tspgrbar.Name = "tspgrbar";
            this.tspgrbar.Size = new System.Drawing.Size(100, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 586);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSrc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbBox);
            this.Controls.Add(this.lvDest);
            this.Controls.Add(this.lvSrc);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.txtSrc);
            this.Name = "Form1";
            this.Text = "File Copy & Move";
            this.gbBox.ResumeLayout(false);
            this.gbBox.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.ListView lvSrc;
        private System.Windows.Forms.ColumnHeader chFileSrc;
        private System.Windows.Forms.ListView lvDest;
        private System.Windows.Forms.ColumnHeader chFileDest;
        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripProgressBar tspgrbar;
    }
}

