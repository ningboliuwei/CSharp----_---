using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculateN
{
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN.Text);
            lblResult.Text = n.ToString()+"!="+f(n).ToString();

        }
        //º∆À„n!
        private long f(int n)
        {
            if (n == 1)
                return 1;

            long ret;
            ret = f(n - 1) * n;

            return ret;

        }
    }
}