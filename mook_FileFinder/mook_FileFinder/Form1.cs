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


namespace mook_FileFinder
{
    public partial class Form1 : Form
    {
        Thread threadFileView = null;
        private delegate void OnDelegateFile(string fn, string fl, string fc, bool flag);
        private OnDelegateFile OnFile = null;
        bool Flag01 = true;
        bool Flag02 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(FileResult);
        }

        private void FileResult(string fn, string fl, string fc, bool flag)
        {
            if (flag == true)
            {
                string fSize = GetFileSize(Convert.ToDouble(fl));
                FileInfo fi = new FileInfo(fn);
                this.lvFile.Items.Add(new ListViewItem(new string[]
                {
                    fi.DirectoryName, fi.Name, fc, fSize
                }));
            }
            else this.lvFile.Items.Add(new ListViewItem(new string[] { fn, "", fc, "" }));
        }

        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount > -1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                this.lvFile.Items.Clear();
                this.txtPath.Text = this.fbdFolder.SelectedPath;
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void FileView(object path)
        {
            DirectoryInfo di = new DirectoryInfo((string)path);
            DirectoryInfo[] dti = di.GetDirectories();
            if(Flag02 == true)
            {
                foreach(var f in di.GetFiles())
                {
                    if(Flag01 == true)
                    {
                        Invoke(OnFile, f.FullName, f.Length.ToString(), f.CreationTime.ToString(), Flag02);
                    }
                    else
                    {
                        if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                        {
                            Invoke(OnFile, f.FullName, f.Length.ToString(), f.CreationTime.ToString(), Flag02);
                        }

                    }
                }
            }
            else
            {
                if(Flag01 == true)
                {
                    Invoke(OnFile, (string)path, "", di.CreationTime.ToString(), Flag02);
                }
                else
                {
                    if(di.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        Invoke(OnFile, (string)path, "", di.CreationTime.ToString(), Flag02);
                    }
                }
            }

            for(int i = 0; i < di.GetDirectories().Length; i++)
            {
                try
                {
                    FileView(dti[i].FullName);
                }
                catch
                {
                    continue;
                }
            }
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            Flag01 = true;
            if (threadFileView != null) threadFileView.Abort();
            if(this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            Flag01 = false;
            if (threadFileView != null) threadFileView.Abort();
            if(this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(new ParameterizedThreadStart(FileView));
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFileView != null) threadFileView.Abort();
        }

        private void rbFile_CheckedChanged(object sender, EventArgs e)
        {
            Flag02= true;
            lvFile.Items.Clear();
            FileView(fbdFolder.SelectedPath);
        }

        private void rbDire_CheckedChanged(object sender, EventArgs e)
        {
            Flag02 = false;
            lvFile.Items.Clear();
            FileView(fbdFolder.SelectedPath);
        }
    }
   
}
