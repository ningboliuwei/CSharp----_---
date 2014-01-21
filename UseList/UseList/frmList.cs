using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseList
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                ListBox1.Items.Add("项目 " + i.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
        }

        private void btnShowMultiColumn_Click(object sender, EventArgs e)
        {
            ListBox1.MultiColumn = !ListBox1.MultiColumn;

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
                lblSelectedItem.Text = ListBox1.SelectedItem.ToString();
        }
    }
}
