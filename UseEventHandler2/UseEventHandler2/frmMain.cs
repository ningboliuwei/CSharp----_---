using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UseEventHandler2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
/// <summary>
/// 借的钱
/// </summary>
        private int LoanMoney = 0;
        private int LoanCount = 0;

        private void btnLoanFromHuang_Click(object sender, EventArgs e)
        {
            btnSum.Enabled = true;
            LoanMoney = 0;
            btnSum.Click += new EventHandler(btnSum_Click);
            lblLoanCount.Text = string.Format("{0} 次", ++LoanCount); 
        }

        void btnSum_Click(object sender, EventArgs e)
        {
           LoanMoney += 100;
           
            lblLoanMoney.Text = string.Format("{0} 元", LoanMoney);
            lblLoanMoney.Refresh();
            Thread.Sleep(300);
            btnSum.Enabled = false;
        }
    }
}
