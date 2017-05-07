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
using System.Diagnostics;

namespace ExplorerExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Drv_list;
            TreeNode root;
            Drv_list = Environment.GetLogicalDrives();

            foreach(string Drv in Drv_list)
            {
                root = trvDir.Nodes.Add(Drv);
                root.ImageIndex = 2;

                if(trvDir.SelectedNode == null)
                {
                    trvDir.SelectedNode = root;
                }
                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }
        }

        private void SetPlus(TreeNode node)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;

            try
            {
                path = node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                if (di.Length > 0)
                    node.Nodes.Add("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenFiles()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lstFiles.SelectedItems;
            foreach(ListViewItem item in siList)
            {
                OpenItem(item);
            }
        }

        public void OpenItem(ListViewItem item)
        {
            TreeNode node;
            TreeNode child;

            if(item.Tag.ToString() == "0")
            {
                node = trvDir.SelectedNode;
                node.Expand();

                child = node.FirstNode;

                while (child != null)
                {
                    if(child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();
                        break;
                    }
                    child = child.NextNode;
                }
            }
            else
            {
                Process.Start(txtPath.Text + "\\" + item.Text);
            }
        }

        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;
            TreeNode node;
            try
            {
                e.Node.Nodes.Clear();
                path = e.Node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();

                foreach(DirectoryInfo dirs in di)
                {
                    node = e.Node.Nodes.Add(dir.Name);
                    SetPlus(node);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo di;
            DirectoryInfo[] diarray;
            ListViewItem item;
            FileInfo[] fiArray;

            try
            {
                di = new DirectoryInfo(e.Node.FullPath);
                txtPath.Text = e.Node.FullPath.Substring(0, 2) + e.Node.FullPath.Substring(3);
            }
            catch
            {

            }
        }
    }
}
