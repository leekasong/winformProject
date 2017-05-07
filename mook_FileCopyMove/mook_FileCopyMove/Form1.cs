using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mook_FileCopyMove
{
    public partial class Form1 : Form
    {
        string FileSrc = "";
        string FileDest = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvSrc.Items.Clear();
                this.txtSrc.Text = this.fbdFolder.SelectedPath;
                FileSrc = this.fbdFolder.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(this.txtSrc.Text);
                foreach(var fs in di.GetFiles())
                {
                    this.lvSrc.Items.Add(new ListViewItem(new string[] { fs.Name }));
                }
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvDest.Items.Clear();
                this.txtDest.Text = this.fbdFolder.SelectedPath;
                FileDest = this.fbdFolder.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(FileDest);
                foreach(var fs in di.GetFiles())
                {
                    this.lvDest.Items.Add(new ListViewItem(new string[] { fs.Name }));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.txtDest.Text == this.txtSrc.Text)
            {
                MessageBox.Show("경로가 같을 수 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 0;
            int sum = this.lvSrc.Items.Count;
            for(int n = this.lvSrc.Items.Count - 1; n >= 0; n--)
            {
                i++;
                if(File.Exists(FileSrc + @"\" + this.lvSrc.Items[n].SubItems[0].Text) == false)
                {
                    MessageBox.Show("존재하지 않는 파일입니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                FileInfo fi = new FileInfo(FileSrc + @"\" + this.lvSrc.Items[n].SubItems[0].Text);
                FileLoad fd = new FileLoad(FileSrc + @"\" + this.lvSrc.Items[n].SubItems[0].Text, FileDest + @"\" + this.lvSrc.Items[n].SubItems[0].Text);
                if(fd.ShowDialog() == DialogResult.OK)
                {
                    fd.Close();
                    int Flag = 0;
                    for(int k = 0; k < this.lvDest.Items.Count; k++)
                    {
                        if (this.lvDest.Items[k].SubItems[0].Text == this.lvSrc.Items[n].SubItems[0].Text) Flag++;
                    }
                    if(Flag == 0)
                    {
                        this.lvDest.Items.Add(new ListViewItem(new string[] { this.lvSrc.Items[n].SubItems[0].Text }));
                        if(rbMove.Checked == true)
                        {
                            fi.Delete();
                            this.lvSrc.Items.RemoveAt(n);
                        }
                    }

                    int v = (int)(i * 100 / sum);
                    this.tspgrbar.Value = v;
                    this.tsslblStatus.Text = "" + v.ToString() + " %";
                }
            }
        }
    }
}
