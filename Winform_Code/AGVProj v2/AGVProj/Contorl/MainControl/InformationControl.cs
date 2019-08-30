using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVProj
{
    public partial class InformationControl : UserControl
    {
        
        public InformationControl()
        {
            InitializeComponent();

            Init_Vsible();
            cameraConrtol2.Visible = false;

        }
       

        public void Banner_Panel_Click()
        {
            Init_Vsible();

            cameraConrtol2.Visible = false;

        }

        public void Notice_Panel_Click()
        {
            Init_Vsible();

            noticeControl1.Visible = true;
            mapSmallControl1.Visible = true;

        }
        public void Enroll_Panel_Click()
        {
            Init_Vsible();

            enrollControl1.Visible = true;
            mapSmallControl1.Visible = true;

        }

        public void Search_Panel_Click()
        {
            Init_Vsible();

            searchControl1.Visible = true;
            mapSmallControl1.Visible = true;

        }

        public void Indication_Panel_Click()
        {
            Init_Vsible();

            mapControl1.Visible = true;
            indicationControl1.Visible = true;
        }

        public void Manual_Panel_Click()
        {
            Init_Vsible();

            mapControl1.Visible = true;
            manualControl2.Visible = true;
        }

        public void Init_Vsible()
        {
            cameraConrtol2.Visible = true;
            detailConrtol1.Visible = false;
            enrollControl1.Visible = false;
            indicationControl1.Visible = false;
            manualControl2.Visible = false;
            mapControl1.Visible = false;
            noticeControl1.Visible = false;
            searchControl1.Visible = false;
            mapSmallControl1.Visible = false;
        }

        private void enrollControl1_Connect_Click(object sender, EnrollControl.Connect_ClickEventArgs e)
        {
            enrollControl1.Test(e.Enrollclass);
            cameraConrtol2.Camera_IP(e.Enrollclass);
        }
    }
}
