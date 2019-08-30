using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGVProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            //Init_Control();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PictureBox11_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //표시줄 커서 On시 색상 변경
        #region

        private void PictureBox11_MouseEnter(object sender, EventArgs e)
        {
            ptbMini.Image = AGVProj.Properties.Resources.minus_white_small_01;
        }

        private void PtbMini_MouseLeave(object sender, EventArgs e)
        {
            ptbMini.Image = AGVProj.Properties.Resources.minus_black_small_01;
        }

        private void PtbClose_MouseEnter(object sender, EventArgs e)
        {
            ptbClose.Image = AGVProj.Properties.Resources.exit_white_small_01;
        }

        private void PtbClose_MouseLeave(object sender, EventArgs e)
        {
            ptbClose.Image = AGVProj.Properties.Resources.exit_black_small_01;

        }
        #endregion

        private void MenuControl1_Logout_Click(object sender, MenuControl.Logout_ClickEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();           
        }

        //창옮기기, 최대화 최소화
        #region
        private void PictureBox2_DoubleClick(object sender, EventArgs e) //최대화 최소화
        {
            //this.MaximizedBounds = Screen.GetWorkingArea(this);
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.WindowState = FormWindowState.Normal;

            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
        }
        private void LblName_DoubleClick(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.GetWorkingArea(this);
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.WindowState = FormWindowState.Normal;

            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
        }

        private Point mousePoint;              //창 옮기기
        private void LblName_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void LblName_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        
        private void PictureBox2_MouseDown(object sender, MouseEventArgs e) //마우스 키값 받기
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)  //창 이동
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        #endregion

        //유저컨트롤 Visible 속성 조절
        #region

        private void MenuControl1_Banner_Click(object sender, MenuControl.Banner_ClickEventArgs e)
        {
            informationControl1.Banner_Panel_Click();
            menuControl1.Init_Menu();

        }

        private void MenuControl1_Notice_Click(object sender, MenuControl.Notice_ClickEventArgs e)
        {
            informationControl1.Notice_Panel_Click();        
        }

        private void MenuControl1_Enroll_Click(object sender, MenuControl.Enroll_ClickEventArgs e)
        {
            informationControl1.Enroll_Panel_Click();

        }


        private void MenuControl1_Search_Click(object sender, MenuControl.Search_ClickEventArgs e)
        {
            informationControl1.Search_Panel_Click();

        }

        private void MenuControl1_Indication_Click(object sender, MenuControl.Indication_ClickEventArgs e)
        {
            informationControl1.Indication_Panel_Click();

        }

        private void MenuControl1_Manual_Click(object sender, MenuControl.Manual_ClickEventArgs e)
        {
            informationControl1.Manual_Panel_Click();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        //private void MainForm_Resize(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Normal)


        //    else if (this.WindowState == FormWindowState.Maximized)

        //}

    }
}
