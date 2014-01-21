using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetOtherFormBackColor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void btnShowOtherForm_Click(object sender, EventArgs e)
        {
            frmOther frm = new frmOther();
            //方式一：将信息作为方法参数传送
            //frm.SetBackColor(pictureBox1.BackColor);
            //方式二：将信息通过公有属性传送
            frm.MyBackColor = pictureBox1.BackColor;
            frm.Show();
        }
    }
}
