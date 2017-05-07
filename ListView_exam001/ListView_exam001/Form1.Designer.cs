namespace ListView_exam001
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
            this.listViewAll = new System.Windows.Forms.ListView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtSnum = new System.Windows.Forms.ComboBox();
            this.labelSnum = new System.Windows.Forms.Label();
            this.listView_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_snum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAll
            // 
            this.listViewAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listView_name,
            this.listView_age,
            this.listView_snum});
            this.listViewAll.Location = new System.Drawing.Point(12, 12);
            this.listViewAll.Name = "listViewAll";
            this.listViewAll.Size = new System.Drawing.Size(279, 158);
            this.listViewAll.TabIndex = 0;
            this.listViewAll.UseCompatibleStateImageBehavior = false;
            this.listViewAll.View = System.Windows.Forms.View.Details;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(351, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "이름:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(351, 88);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 15);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "나이:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(425, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(425, 78);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 25);
            this.txtAge.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(106, 211);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "제거";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtSnum
            // 
            this.txtSnum.FormattingEnabled = true;
            this.txtSnum.Location = new System.Drawing.Point(425, 128);
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(100, 23);
            this.txtSnum.TabIndex = 7;
            // 
            // labelSnum
            // 
            this.labelSnum.AutoSize = true;
            this.labelSnum.Location = new System.Drawing.Point(351, 136);
            this.labelSnum.Name = "labelSnum";
            this.labelSnum.Size = new System.Drawing.Size(42, 15);
            this.labelSnum.TabIndex = 8;
            this.labelSnum.Text = "학번:";
            // 
            // listView_name
            // 
            this.listView_name.Text = "이름";
            this.listView_name.Width = 90;
            // 
            // listView_age
            // 
            this.listView_age.Text = "나이";
            this.listView_age.Width = 87;
            // 
            // listView_snum
            // 
            this.listView_snum.Text = "학번";
            this.listView_snum.Width = 146;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(203, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "편집";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 260);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelSnum);
            this.Controls.Add(this.txtSnum);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listViewAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAll;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox txtSnum;
        private System.Windows.Forms.Label labelSnum;
        private System.Windows.Forms.ColumnHeader listView_name;
        private System.Windows.Forms.ColumnHeader listView_age;
        private System.Windows.Forms.ColumnHeader listView_snum;
        private System.Windows.Forms.Button btnEdit;
    }
}

