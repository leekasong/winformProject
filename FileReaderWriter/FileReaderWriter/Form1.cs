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
using System.Threading;


namespace FileReaderWriter
{
    public partial class Form1 : Form
    {
        FileStream fsr = null;
        FileStream fsw = null;
        MemoryStream ms = new MemoryStream();
        byte[] bt = new byte[4096];

        Thread thre_ftm;
        Thread thre_mtf;

        private delegate void OnDelegatePro(int n);
        private OnDelegatePro OnPgb;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if(this.ofd_Find.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd_Find.FileName;
                txt_Find.Text = fileName;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(this.sfd_Save.ShowDialog() == DialogResult.OK)
            {
                string saveFileName = sfd_Save.FileName;
                txt_Save.Text = saveFileName;
            }
        }

        private void btn_Ftm_Click(object sender, EventArgs e)
        {
            if (pgbView.Value != 0)
            {
                pgbView.Value = 0;
                lb_Per.Text = "0%";
            }
            fsr = new FileStream(txt_Find.Text, FileMode.Open, FileAccess.Read);
            FileInfo fi = new FileInfo(txt_Find.Text);
            thre_ftm = new Thread(new ParameterizedThreadStart(FileRead));
            thre_ftm.Start(fi);
            
        }

        private void FileRead(object o)
        {
            FileInfo fi = (FileInfo)o;
            long LengthQ = fi.Length / 4096;
            long LengthR = fi.Length % 4096;
            long n = 0;

            for(n=0; n < LengthQ; n++)
            {
                fsr.Seek(4096 * n, SeekOrigin.Begin);
                fsr.Read(bt, 0, 4096);
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Write(bt, 0, 4096);
                int read_size = (int)(ms.Length * 100 / fsr.Length);
                Invoke(OnPgb, read_size);
            }
            if((int)LengthR != 0)
            {
                fsr.Seek(4096 * n, SeekOrigin.Begin);
                fsr.Read(bt, 0, 4096);
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Write(bt, 0, 4096);
                Invoke(OnPgb, 100);
            }

            fsr.Close();
            thre_ftm.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnPgb = new OnDelegatePro(SetPgbPer);
        }

        private void SetPgbPer(int n)
        {
            pgbView.Value = n;
            lb_Per.Text = pgbView.Value.ToString() + "%";
        }

        private void btn_Mtf_Click(object sender, EventArgs e)
        {
            if (pgbView.Value != 0)
            {
                pgbView.Value = 0;
                lb_Per.Text = "0%";
            }

            fsw = new FileStream(txt_Save.Text, FileMode.Create, FileAccess.Write);
            thre_mtf = new Thread(FileWrite);
            thre_mtf.Start();
        }

        private void FileWrite()
        {
            FileInfo fi = new FileInfo(txt_Find.Text);
            long LengthQ = fi.Length / 4096;
            long LengthR = fi.Length % 4096;
            long n = 0;
            for(n = 0; n < LengthQ; n++)
            {
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Read(bt, 0, 4096);
                fsw.Seek(4096 * n, SeekOrigin.Begin);
                fsw.Write(bt, 0, 4096);
                int write_size = (int)(ms.Length * 100 / fsw.Length);
                Invoke(OnPgb, write_size);
            }
            if((int)LengthR != 0)
            {
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Read(bt, 0, 4096);
                fsw.Seek(4096 * n, SeekOrigin.Begin);
                fsw.Write(bt, 0, 4096);
                Invoke(OnPgb, 100);
            }

            fsw.Close();
            thre_mtf.Abort();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms.Close();
        }
    }
}
