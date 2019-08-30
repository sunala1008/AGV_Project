using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGV.Control
{
    public partial class NoticeControl : UserControl
    {
        public NoticeControl()
        {
            InitializeComponent();

            timer1.Start(); // 시계
        }

        #region 시계
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbWhatTimeisitNow.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

    }
}
