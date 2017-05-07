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

namespace mook_MemoryReaderWriter
{
    public partial class Form1 : Form
    {
        FileStream fsr = null;
        FileStream fsw = null;
        MemoryStream ms = new MemoryStream();
        byte[] bt = new byte[4096];

        Thread FileMemThre = null;
        Thread MemFileThre = null;
        private delegate void OnDelegateView(int n);
        private OnDelegateView OnView = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ofdFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            if(this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtOpenPath.Text = this.ofdFile.FileName;
                fsr = new FileStream(this.txtOpenPath.Text, FileMode.Open, FileAccess.Read);
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if(this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtSavePath.Text = this.sfdFile.FileName;
            }
        }

        private void btnMemLoad_Click(object sender, EventArgs e)
        {
            this.pgbLoad.Value = 0;
            FileInfo fi = new FileInfo(this.txtOpenPath.Text);
            FileMemThre = new Thread(new ParameterizedThreadStart(FileMem));
            FileMemThre.Start(fi);
        }

        private void FileMem(object o)
        {
            FileInfo fi = (FileInfo)o;
            long FlengthC = fi.Length / 4096;
            long FlengthL = fi.Length % 4096;
            long n = 0;
            for(n = 0; n < FlengthC; n++)
            {
                Thread.Sleep(10);
                fsr.Seek(4096 * n, SeekOrigin.Begin);
                fsr.Read(bt, 0, 4096);
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Write(bt, 0, 4096);
                int v = (int)(ms.Length * 100 / fsr.Length);
                Invoke(OnView, v);
            }
            if((int)FlengthL != 0)
            {
                fsr.Seek(4096 * n, SeekOrigin.Begin);
                fsr.Read(bt, 0, (int)FlengthL);
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Write(bt, 0, (int)FlengthL);
                Invoke(OnView, 100);
            }
            fsr.Close();
            FileMemThre.Abort();
        
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            this.pgbLoad.Value = 0;
            ms.Position = 0;
            fsw = new FileStream(this.txtSavePath.Text, FileMode.Create, FileAccess.Write);
            MemFileThre = new Thread(MemFile);
            MemFileThre.Start();
        }

        private void MemFile()
        {
            long FlengthC = ms.Length / 4096;
            long FlengthL = ms.Length % 4096;
            long n = 0;
            for(n = 0; n < FlengthC; n++)
            {
                Thread.Sleep(10);
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Read(bt, 0, 4096);
                fsw.Seek(4096 * n, SeekOrigin.Begin);
                fsw.Read(bt, 0, 4096);

                int v = (int)(fsw.Length * 100 / ms.Length);
                Invoke(OnView, v);
            }

            if((int)FlengthL != 0)
            {
                ms.Seek(4096 * n, SeekOrigin.Begin);
                ms.Read(bt, 0, (int)FlengthL);
                fsw.Seek(4096 * n, SeekOrigin.Begin);
                fsw.Write(bt, 0, (int)FlengthL);
                Invoke(OnView, 100);
            }

            fsw.Close();
            MemFileThre.Abort();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnView = new OnDelegateView(OnProView);
        }

        private void OnProView(int n)
        {
            this.pgbLoad.Value = n;
            this.lblPer.Text = n.ToString() + " %";
        }
    }
}
