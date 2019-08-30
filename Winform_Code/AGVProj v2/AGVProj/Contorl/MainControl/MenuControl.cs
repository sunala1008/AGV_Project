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
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        private bool notice = false;
        private bool enroll = false;
        private bool search = false;
        private bool indication = false;
        private bool manual = false;
        private bool logout = false;

        private void PtbNotice_Click(object sender, EventArgs e)
        {
            OnNotice_Click();
        }

        private void PtbEnroll_Click(object sender, EventArgs e)
        {
            OnEnroll_Click();
        }
       

        private void PtbIndication_Click(object sender, EventArgs e)
        {
            OnIndication_Click();
        }

        private void Ptbmanual_Click(object sender, EventArgs e)
        {
            OnManual_Click();
        }

        private void PtbLogout_Click(object sender, EventArgs e)
        {
            OnLogout_Click();
        }


        #region Notice_Click event things for C# 3.0
        public event EventHandler<Notice_ClickEventArgs> Notice_Click;

        protected virtual void OnNotice_Click(Notice_ClickEventArgs e)
        {
            if (Notice_Click != null)
                Notice_Click(this, e);
        }


        private Notice_ClickEventArgs OnNotice_Click()
        {
            Notice_ClickEventArgs args = new Notice_ClickEventArgs();
            OnNotice_Click(args);

            Init_Menu();

            notice = true;
            ptbNotice.Image = AGVProj.Properties.Resources.menu_1_3_01;
            ptbNotice.Location = new System.Drawing.Point(8, 70);

            return args;
        }

        private void PtbNotice_MouseEnter(object sender, EventArgs e)
        {
            if (!notice) ptbNotice.Image = AGVProj.Properties.Resources.menu_1_2_01;
        }

        private void PtbNotice_MouseLeave(object sender, EventArgs e)
        {
            if (!notice) ptbNotice.Image = AGVProj.Properties.Resources.menu_1_1_01_01_01;
        }

        /*private Notice_ClickEventArgs OnNotice_ClickForOut()
        {
            Notice_ClickEventArgs args = new Notice_ClickEventArgs();
            OnNotice_Click(args);

            return args;
        }*/

        public class Notice_ClickEventArgs : EventArgs
        {


            /*public Notice_ClickEventArgs()
            {
            }

            public Notice_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Enroll_Click event things for C# 3.0
        public event EventHandler<Enroll_ClickEventArgs> Enroll_Click;

        protected virtual void OnEnroll_Click(Enroll_ClickEventArgs e)
        {
            if (Enroll_Click != null)
                Enroll_Click(this, e);
        }

        private Enroll_ClickEventArgs OnEnroll_Click()
        {
            Enroll_ClickEventArgs args = new Enroll_ClickEventArgs();
            OnEnroll_Click(args);
            Init_Menu();

            enroll = true;
            ptbEnroll.Image = AGVProj.Properties.Resources.menu_2_3_01;
            ptbEnroll.Location = new System.Drawing.Point(8, 120);

            return args;
        }

        private void PtbEnroll_MouseEnter(object sender, EventArgs e)
        {
            if (!enroll) ptbEnroll.Image = AGVProj.Properties.Resources.menu_2_2_01;

        }

        private void PtbEnroll_MouseLeave(object sender, EventArgs e)
        {
            if (!enroll) ptbEnroll.Image = AGVProj.Properties.Resources.menu_2_1_01_01;

        }

        /*private Enroll_ClickEventArgs OnEnroll_ClickForOut()
        {
            Enroll_ClickEventArgs args = new Enroll_ClickEventArgs();
            OnEnroll_Click(args);

            return args;
        }*/

        public class Enroll_ClickEventArgs : EventArgs
        {


            /*public Enroll_ClickEventArgs()
            {
            }

            public Enroll_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Search_Click event things for C# 3.0
        public event EventHandler<Search_ClickEventArgs> Search_Click;

        protected virtual void OnSearch_Click(Search_ClickEventArgs e)
        {
            if (Search_Click != null)
                Search_Click(this, e);
        }

        private Search_ClickEventArgs OnSearch_Click()
        {
            Search_ClickEventArgs args = new Search_ClickEventArgs();
            OnSearch_Click(args);

            Init_Menu();

            search = true;
            ptbSearch.Image = AGVProj.Properties.Resources.menu_7_3_01;
            ptbSearch.Location = new System.Drawing.Point(8, 170);

            return args;
        }

        private void PtbSearch_MouseEnter(object sender, EventArgs e)
        {
            if(!search) ptbSearch.Image = AGVProj.Properties.Resources.menu_7_2_01;
        }

        private void PtbSearch_MouseLeave(object sender, EventArgs e)
        {
            if (!search) ptbSearch.Image = AGVProj.Properties.Resources.menu_7_1_01;
        }

        /*private Search_ClickEventArgs OnSearch_ClickForOut()
        {
            Search_ClickEventArgs args = new Search_ClickEventArgs();
            OnSearch_Click(args);

            return args;
        }*/

        public class Search_ClickEventArgs : EventArgs
        {


            /*public Search_ClickEventArgs()
            {
            }

            public Search_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Indication_Click event things for C# 3.0
        public event EventHandler<Indication_ClickEventArgs> Indication_Click;

        protected virtual void OnIndication_Click(Indication_ClickEventArgs e)
        {
            if (Indication_Click != null)
                Indication_Click(this, e);
        }

        private Indication_ClickEventArgs OnIndication_Click()
        {
            Indication_ClickEventArgs args = new Indication_ClickEventArgs();
            OnIndication_Click(args);

            Init_Menu();

            indication = true;
            ptbIndication.Image = AGVProj.Properties.Resources.menu_4_3_01;
            ptbIndication.Location = new System.Drawing.Point(8, 220);


            return args;
        }

        private void PtbIndication_MouseEnter(object sender, EventArgs e)
        {
            if (!indication) ptbIndication.Image = AGVProj.Properties.Resources.menu_4_2_01;

        }

        private void PtbIndication_MouseLeave(object sender, EventArgs e)
        {
            if (!indication) ptbIndication.Image = AGVProj.Properties.Resources.menu_4_1_01;

        }

        /*private Indication_ClickEventArgs OnIndication_ClickForOut()
        {
            Indication_ClickEventArgs args = new Indication_ClickEventArgs();
            OnIndication_Click(args);

            return args;
        }*/

        public class Indication_ClickEventArgs : EventArgs
        {


            /*public Indication_ClickEventArgs()
            {
            }

            public Indication_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Manual_Click event things for C# 3.0
        public event EventHandler<Manual_ClickEventArgs> Manual_Click;

        protected virtual void OnManual_Click(Manual_ClickEventArgs e)
        {
            if (Manual_Click != null)
                Manual_Click(this, e);
        }

        private Manual_ClickEventArgs OnManual_Click()
        {
            Manual_ClickEventArgs args = new Manual_ClickEventArgs();
            OnManual_Click(args);

            Init_Menu();

            manual = true;
            ptbmanual.Image = AGVProj.Properties.Resources.menu_5_3_01;
            ptbmanual.Location = new System.Drawing.Point(8, 270);

            return args;
        }
        private void Ptbmanual_MouseEnter(object sender, EventArgs e)
        {
            if (!manual) ptbmanual.Image = AGVProj.Properties.Resources.menu_5_2_01;

        }

        private void Ptbmanual_MouseLeave(object sender, EventArgs e)
        {
            if (!manual) ptbmanual.Image = AGVProj.Properties.Resources.menu_5_1_01_01;

        }

        /*private Manual_ClickEventArgs OnManual_ClickForOut()
        {
            Manual_ClickEventArgs args = new Manual_ClickEventArgs();
            OnManual_Click(args);

            return args;
        }*/

        public class Manual_ClickEventArgs : EventArgs
        {


            /*public Manual_ClickEventArgs()
            {
            }

            public Manual_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Logout_Click event things for C# 3.0
        public event EventHandler<Logout_ClickEventArgs> Logout_Click;

        protected virtual void OnLogout_Click(Logout_ClickEventArgs e)
        {
            if (Logout_Click != null)
                Logout_Click(this, e);
        }

        private Logout_ClickEventArgs OnLogout_Click()
        {
            Logout_ClickEventArgs args = new Logout_ClickEventArgs();
            OnLogout_Click(args);

            Init_Menu();

            logout = true;
            ptbLogout.Image = AGVProj.Properties.Resources.menu_6_3_01;
            ptbLogout.Location = new System.Drawing.Point(8, 562);

            return args;
        }
        private void PtbLogout_MouseEnter(object sender, EventArgs e)
        {
            if (!logout) ptbLogout.Image = AGVProj.Properties.Resources.menu_6_2_01;

        }

        private void PtbLogout_MouseLeave(object sender, EventArgs e)
        {
            if (!logout) ptbLogout.Image = AGVProj.Properties.Resources.menu_6_1_01;
        }
        /*private Logout_ClickEventArgs OnLogout_ClickForOut()
        {
            Logout_ClickEventArgs args = new Logout_ClickEventArgs();
            OnLogout_Click(args);

            return args;
        }*/

        public class Logout_ClickEventArgs : EventArgs
        {


            /*public Logout_ClickEventArgs()
            {
            }

            public Logout_ClickEventArgs()
            {

            }*/
        }
        #endregion

        #region Banner_Click event things for C# 3.0
        public event EventHandler<Banner_ClickEventArgs> Banner_Click;

        protected virtual void OnBanner_Click(Banner_ClickEventArgs e)
        {
            if (Banner_Click != null)
                Banner_Click(this, e);
        }

        private Banner_ClickEventArgs OnBanner_Click()
        {
            Banner_ClickEventArgs args = new Banner_ClickEventArgs();
            OnBanner_Click(args);

            return args;
        }

        /*private Banner_ClickEventArgs OnBanner_ClickForOut()
        {
            Banner_ClickEventArgs args = new Banner_ClickEventArgs();
            OnBanner_Click(args);

            return args;
        }*/

        public class Banner_ClickEventArgs : EventArgs
        {


            /*public Banner_ClickEventArgs()
            {
            }

            public Banner_ClickEventArgs()
            {

            }*/
        }
        #endregion


        public void Init_Menu()
        {
            #region

            notice = false;
            enroll = false;
            search = false;
            indication = false;
            manual = false;
            logout = false;
            // ptbmanual
            // 
            ptbmanual.Image = AGVProj.Properties.Resources.menu_5_1_01_01;
            ptbmanual.Location = new System.Drawing.Point(4, 270);


            // ptbIndication
            // 
            ptbIndication.Image = AGVProj.Properties.Resources.menu_4_1_01;
            ptbIndication.Location = new System.Drawing.Point(4, 220);

            // ptbConnect
            // 
            ptbSearch.Image = AGVProj.Properties.Resources.menu_7_1_01;
            ptbSearch.Location = new System.Drawing.Point(4, 170);

            // ptbEnroll
            // 
            ptbEnroll.Image = AGVProj.Properties.Resources.menu_2_1_01_01;
            ptbEnroll.Location = new System.Drawing.Point(4, 120);

            // ptbNotice
            // 
            ptbNotice.Image = AGVProj.Properties.Resources.menu_1_1_01_01_01;
            ptbNotice.Location = new System.Drawing.Point(4, 70);

            // ptbLogout
            // 
           
            #endregion
            //InitializeComponent
        }

        private void LblAMS_Click(object sender, EventArgs e)
        {
            OnBanner_Click();
        }

        private void PtbSearch_Click(object sender, EventArgs e)
        {
            OnSearch_Click();
        }

        
    }
}
