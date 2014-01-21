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
    public partial class frmOther : Form
    {
        public frmOther()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置本窗体的背景色
        /// </summary>
        /// <param name="clr"></param>
        public void SetBackColor(Color clr)
        {
            this.BackColor = clr;
        }
        /// <summary>
        /// 获取或设置自己的背景色
        /// </summary>
        public Color MyBackColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

    }
}
