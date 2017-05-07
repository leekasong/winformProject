using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_exam001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            string[] itemStr = new string[3];
            if (txtName.Text.CompareTo("") != 0)
                itemStr.SetValue(txtName.Text, 0);
            else
                itemStr.SetValue("NULL", 0);

            if (txtAge.Text.CompareTo("") != 0)
                itemStr.SetValue(txtAge.Text, 1);
            else
                itemStr.SetValue("NULL", 1);

            if (txtSnum.Text.CompareTo("") != 0)
                itemStr.SetValue(txtSnum.Text, 2);
            else
                itemStr.SetValue("NULL", 3);

            item = new ListViewItem(itemStr);
            listViewAll.Items.Add(item);

            ClearTextBox();
        }

        public void ClearTextBox()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtSnum.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listViewAll.FocusedItem != null)
                listViewAll.FocusedItem.Remove();

            ClearTextBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem Item;
            string[] str = new string[3];
            if (txtName.Text.CompareTo("") != 0)
                str.SetValue(txtName.Text, 0);
            else
                str.SetValue("NULL", 0);

            if (txtAge.Text.CompareTo("") != 0)
                str.SetValue(txtAge.Text, 1);
            else
                str.SetValue("NULL", 1);

            if (txtSnum.Text.CompareTo("") != 0)
                str.SetValue(txtSnum.Text, 2);
            else
                str.SetValue("NULL", 2);

            Item = new ListViewItem(str);
            listViewAll.Items.Add(Item);
            listViewAll.FocusedItem.Remove();

            ClearTextBox();

            
        }
    }

}
