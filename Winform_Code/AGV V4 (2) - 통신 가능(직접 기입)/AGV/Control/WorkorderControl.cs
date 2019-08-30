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
    public partial class WorkorderControl : UserControl
    {
        public WorkorderControl()
        {
            InitializeComponent();
        }

        #region 작업 지시
        private void BtnAdd_Click(object sender, EventArgs e) // 리스트에 작업 추가
        {
            if (rbtnpass.Checked)
                lbWorklist.Items.Add(rbtnpass.Text);

            if (rbtnunpass.Checked)
                lbWorklist.Items.Add(rbtnunpass.Text);
        }

        private void BtnDel_Click(object sender, EventArgs e) // 리스트에 추가된 작업 삭제
        {
            if (lbWorklist.SelectedIndex > -1)
                lbWorklist.Items.RemoveAt(lbWorklist.SelectedIndex);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void SetCamImage(Bitmap bitmap)
        {
            pbCam.Image = bitmap;
        }

    }
}
