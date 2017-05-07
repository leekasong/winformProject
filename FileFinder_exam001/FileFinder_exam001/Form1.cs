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

namespace FileFinder_exam001
{
    public partial class Form1 : Form
    {
        private delegate void OnFileFinder(string fn, string fl, string fSize, bool flag);
        OnFileFinder OnFinder = null;

        Thread FileShowThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFinder = new OnFileFinder(FileResult);
        }

        private void FileResult(string fn, string fl, string fSize, bool flag)
        {
            
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.fbdPath.ShowDialog() == DialogResult.OK)
            {
                lvPath.Items.Clear();
                string m_path = fbdPath.SelectedPath;
                txtPath.Text = m_path;
                FileShowThread = new Thread(new ParameterizedThreadStart(ShowFile));
                FileShowThread.Start(m_path);
            }
        }

        private void ShowFile(object obj)
        {
            DirectoryInfo
        }
    }
}
