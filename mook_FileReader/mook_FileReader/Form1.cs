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

namespace mook_FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.ofdFile.FileName;
            }
        }

        private void btnAllRead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false) return;
            if(File.Exists(this.txtPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtPath.Text))
                {
                    this.txtView.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool txtCheck()
        {
            if (this.txtPath.Text == "") return false;
            else return true;
        }

        private void btnLineRead_Click(object sender, EventArgs e)
        {
            if(txtCheck() == false)
            {
                return;
            }

            this.txtView.Clear();
            if(File.Exists(this.txtPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtPath.Text))
                {
                    string line = null;
                    while((line = sr.ReadLine())!= null)
                    {
                        this.txtView.AppendText(line + "\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
