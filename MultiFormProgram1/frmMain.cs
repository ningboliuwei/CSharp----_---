using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFormProgram1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtUserInput.Text == "")
            {
                MessageBox.Show("请输入一条信息", "提示", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
                //焦点回到文本框
                txtUserInput.Focus();
                return;
            }
            //创建从窗体对象
            frmOther frm = new frmOther();
            //向从窗体的自定义属性赋值
            frm.ShowText = txtUserInput.Text;
            //显示从窗体
            frm.Show();
        }
    }
}
