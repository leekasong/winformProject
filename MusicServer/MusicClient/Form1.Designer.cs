namespace MusicClient
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMusic = new System.Windows.Forms.ListView();
            this.ml_chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ml_chArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ml_chPlayTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ml_chBitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pgDownload = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.cbPlayMode = new System.Windows.Forms.ComboBox();
            this.tbPlay = new System.Windows.Forms.TrackBar();
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lstPlay = new System.Windows.Forms.ListView();
            this.pl_chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pl_chArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pl_PlayTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pl_BitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrev = new System.Windows.Forms.Button();
            this.fbdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstMusic);
            this.groupBox1.Controls.Add(this.pgDownload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "get MP3 File";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "재생 목록에 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(290, 92);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(168, 59);
            this.btnPath.TabIndex = 12;
            this.btnPath.Text = "find path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Server Music List";
            // 
            // lstMusic
            // 
            this.lstMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ml_chName,
            this.ml_chArtist,
            this.ml_chPlayTime,
            this.ml_chBitRate});
            this.lstMusic.Location = new System.Drawing.Point(38, 357);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(420, 184);
            this.lstMusic.TabIndex = 10;
            this.lstMusic.UseCompatibleStateImageBehavior = false;
            this.lstMusic.View = System.Windows.Forms.View.Details;
            // 
            // ml_chName
            // 
            this.ml_chName.Text = "Music Name";
            this.ml_chName.Width = 123;
            // 
            // ml_chArtist
            // 
            this.ml_chArtist.Text = "Artist";
            this.ml_chArtist.Width = 103;
            // 
            // ml_chPlayTime
            // 
            this.ml_chPlayTime.Text = "Play Time";
            this.ml_chPlayTime.Width = 90;
            // 
            // ml_chBitRate
            // 
            this.ml_chBitRate.Text = "Bit Rate";
            this.ml_chBitRate.Width = 115;
            // 
            // pgDownload
            // 
            this.pgDownload.Location = new System.Drawing.Point(38, 253);
            this.pgDownload.Name = "pgDownload";
            this.pgDownload.Size = new System.Drawing.Size(420, 23);
            this.pgDownload.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "mp3 file Download path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(204, 199);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(254, 25);
            this.txtPath.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(38, 92);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(168, 59);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(351, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(107, 25);
            this.txtPort.TabIndex = 1;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(38, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(171, 25);
            this.txtIp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.testBtn);
            this.groupBox2.Controls.Add(this.cbPlayMode);
            this.groupBox2.Controls.Add(this.tbPlay);
            this.groupBox2.Controls.Add(this.lblPlay);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAfter);
            this.groupBox2.Controls.Add(this.btnPlay);
            this.groupBox2.Controls.Add(this.lstPlay);
            this.groupBox2.Controls.Add(this.btnPrev);
            this.groupBox2.Location = new System.Drawing.Point(536, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 571);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "play mp3 file";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(37, 165);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 21;
            this.testBtn.Text = "testBtn";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Visible = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // cbPlayMode
            // 
            this.cbPlayMode.FormattingEnabled = true;
            this.cbPlayMode.Items.AddRange(new object[] {
            "기본",
            "한곡반복재생",
            "전체반복재생",
            "전체한번재생",
            "전체랜덤재생"});
            this.cbPlayMode.Location = new System.Drawing.Point(339, 25);
            this.cbPlayMode.Name = "cbPlayMode";
            this.cbPlayMode.Size = new System.Drawing.Size(121, 23);
            this.cbPlayMode.TabIndex = 20;
            this.cbPlayMode.SelectedIndexChanged += new System.EventHandler(this.cbPlayMode_SelectedIndexChanged);
            // 
            // tbPlay
            // 
            this.tbPlay.Location = new System.Drawing.Point(16, 102);
            this.tbPlay.Maximum = 100;
            this.tbPlay.Name = "tbPlay";
            this.tbPlay.Size = new System.Drawing.Size(445, 56);
            this.tbPlay.TabIndex = 19;
            this.tbPlay.Scroll += new System.EventHandler(this.tbPlay_Scroll);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(153, 84);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(152, 15);
            this.lblPlay.TabIndex = 14;
            this.lblPlay.Text = "선택된 곡이 없습니다";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(229, 314);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(218, 27);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "재생 목록에서 삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "play list";
            // 
            // btnAfter
            // 
            this.btnAfter.Image = global::MusicClient.Properties.Resources.Next;
            this.btnAfter.Location = new System.Drawing.Point(334, 217);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(127, 59);
            this.btnAfter.TabIndex = 16;
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::MusicClient.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(178, 217);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(127, 59);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button5_Click);
            // 
            // lstPlay
            // 
            this.lstPlay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pl_chName,
            this.pl_chArtist,
            this.pl_PlayTime,
            this.pl_BitRate});
            this.lstPlay.Location = new System.Drawing.Point(27, 357);
            this.lstPlay.Name = "lstPlay";
            this.lstPlay.Size = new System.Drawing.Size(420, 184);
            this.lstPlay.TabIndex = 14;
            this.lstPlay.UseCompatibleStateImageBehavior = false;
            this.lstPlay.View = System.Windows.Forms.View.Details;
            // 
            // pl_chName
            // 
            this.pl_chName.Text = "Music Name";
            this.pl_chName.Width = 123;
            // 
            // pl_chArtist
            // 
            this.pl_chArtist.Text = "Artist";
            this.pl_chArtist.Width = 103;
            // 
            // pl_PlayTime
            // 
            this.pl_PlayTime.Text = "Play Time";
            this.pl_PlayTime.Width = 90;
            // 
            // pl_BitRate
            // 
            this.pl_BitRate.Text = "Bit Rate";
            this.pl_BitRate.Width = 115;
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::MusicClient.Properties.Resources.Prev;
            this.btnPrev.Location = new System.Drawing.Point(16, 217);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(127, 59);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 1;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstMusic;
        private System.Windows.Forms.ColumnHeader ml_chName;
        private System.Windows.Forms.ColumnHeader ml_chArtist;
        private System.Windows.Forms.ColumnHeader ml_chPlayTime;
        private System.Windows.Forms.ColumnHeader ml_chBitRate;
        private System.Windows.Forms.ProgressBar pgDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView lstPlay;
        private System.Windows.Forms.ColumnHeader pl_chName;
        private System.Windows.Forms.ColumnHeader pl_chArtist;
        private System.Windows.Forms.ColumnHeader pl_PlayTime;
        private System.Windows.Forms.ColumnHeader pl_BitRate;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TrackBar tbPlay;
        private System.Windows.Forms.FolderBrowserDialog fbdSave;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.ComboBox cbPlayMode;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

