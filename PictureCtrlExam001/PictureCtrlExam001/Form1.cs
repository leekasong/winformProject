using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureCtrlExam001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_show.Visible == true)
            {
                pb_show.Image = Image.FromFile("설현1.jpg");
                txt_desc.Text = "설현1";
            }
              
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_show.Visible == true)
            {
                pb_show.Image = Image.FromFile(@"E:\workspace\winform\PictureCtrlExam001\PictureCtrlExam001\bin\Debug\설현2.jpg");
                txt_desc.Text = "설현2";
            } 
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_show.Visible == true)
            {
                pb_show.Image = Properties.Resources.설현3;
                txt_desc.Text = "설현3";
            }
               
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_show.Visible == true)
            {
                pb_show.Image = Properties.Resources.설현4;
                txt_desc.Text = "설현4";
            }

        }

        private void cb_visible_CheckedChanged(object sender, EventArgs e)
        {
            if (pb_show.Visible == false)
                pb_show.Visible = true;
            else
                pb_show.Visible = false;

            txt_desc.Text = "";
        }
    }
}
