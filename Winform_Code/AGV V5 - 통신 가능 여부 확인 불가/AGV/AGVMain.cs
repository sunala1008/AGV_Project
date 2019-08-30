using AGV.Properties;
using AGV.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.Net.Sockets;
using System.Net;

namespace AGV
{ 
    public partial class AGVMain : Form
    {
        static string data;

        // (1) 소켓 객체 생성 (TCP 소켓)
        static Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        string GetOperatorName;
        //private string GetOperatorName;
        //public AGVMain(string SendOName)

        public AGVMain()
        {
            InitializeComponent();

            //this.GetOperatorName = SendOName;

            Icon = Resources.AGV_Navigation_icon_drop_shadow1; // 프로그램 Icon 설정

            pbNotice1.Visible = false;
            pbNotice3.Visible = true;
            uscNoticeControl.Visible = true;
        }

        #region 폼 창 옮기는 함수 --> ??? 팀뷰어라서 이상한가?
        private Point mousePoint;

        private void LblName_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Pb1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void LblName_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top = (mousePoint.Y - e.Y));
        }

        private void Pb1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (mousePoint.X - e.X), this.Top = (mousePoint.Y - e.Y));
        }


        #endregion

        #region 최소화, 종료 색 변화
        private void PbMini_MouseEnter(object sender, EventArgs e) // 마우스 올릴 시
        {
            pbMini.Image = Resources.minus_white_small_01;
        }

        private void PbMini_MouseLeave(object sender, EventArgs e) // 마우스 내릴 시
        {
            pbMini.Image = Resources.minus_black_small_01;
        }

        private void PbMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PbClose_MouseEnter(object sender, EventArgs e) // 마우스 올릴 시
        {
            pbClose.Image = Resources.exit_white_small_01;
        }

        private void PbClose_MouseLeave(object sender, EventArgs e) // 마우스 내릴 시
        {
            pbClose.Image = Resources.exit_black_small_01;
        }
        #endregion

        #region 폼 종료
        private void AGV_KeyDown(object sender, KeyEventArgs e) // ESC 누를 시 Form 종료
        {
            if (e.KeyCode == Keys.Escape)
            {
                //sock.Close();
                //stream.Stop();
                Close();
            }   
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            //sock.Close();
            //stream.Stop();
            Close();
        }



        #endregion

        #region 메뉴바, 메인 화면

        #region Notice
        private void PbNotice1_MouseEnter(object sender, EventArgs e)
        {
            pbNotice2.Visible = true;
        }

        private void PbNotice2_Click(object sender, EventArgs e)
        {
            pbNotice3.Visible = true;
            pbNotice1.Visible = false;
            pbNotice2.Visible = false;

            pbAGVRegist1.Visible = true;
            pbAGVRegist2.Visible = false;
            pbAGVRegist3.Visible = false;

            pbAGVWorkOrder1.Visible = true;
            pbAGVWorkOrder2.Visible = false;
            pbAGVWorkOrder3.Visible = false;

            uscNoticeControl.Visible = true;
            uscRegistControl.Visible = false;
        }

        private void PbNotice2_MouseLeave(object sender, EventArgs e)
        {
            pbNotice2.Visible = false;
        }
        #endregion

        #region Regist
        private void PbAGVRegist1_MouseEnter(object sender, EventArgs e)
        {
            pbAGVRegist2.Visible = true;
        }

        private void PbAGVRegist2_Click(object sender, EventArgs e)
        {
            pbNotice3.Visible = false;
            pbNotice1.Visible = true;
            pbNotice2.Visible = false;

            pbAGVRegist1.Visible = false;
            pbAGVRegist2.Visible = false;
            pbAGVRegist3.Visible = true;

            pbAGVWorkOrder1.Visible = true;
            pbAGVWorkOrder2.Visible = false;
            pbAGVWorkOrder3.Visible = false;

            uscNoticeControl.Visible = false;
            uscRegistControl.Visible = true;
        }

        private void PbAGVRegist2_MouseLeave(object sender, EventArgs e)
        {
            pbAGVRegist2.Visible = false;
        }
        #endregion

        #region WorkOrder
        private void PbAGVWorkOrder1_MouseEnter(object sender, EventArgs e)
        {
            pbAGVWorkOrder2.Visible = true;
        }

        private void PbAGVWorkOrder2_Click(object sender, EventArgs e)
        {
            pbNotice3.Visible = false;
            pbNotice1.Visible = true;
            pbNotice2.Visible = false;

            pbAGVRegist1.Visible = true;
            pbAGVRegist2.Visible = false;
            pbAGVRegist3.Visible = false;

            pbAGVWorkOrder1.Visible = false;
            pbAGVWorkOrder2.Visible = false;
            pbAGVWorkOrder3.Visible = true;

            uscNoticeControl.Visible = false;
            uscRegistControl.Visible = false;
        }

        private void PbAGVWorkOrder2_MouseLeave(object sender, EventArgs e)
        {
            pbAGVWorkOrder2.Visible = false;
        }
        #endregion

        #region Logout
        private void PbLogout1_MouseEnter(object sender, EventArgs e)
        {
            pbLogout2.Visible = true;
        }

        private void PbLogout2_Click(object sender, EventArgs e)
        {
            pbLogout2.Visible = false;
            pbLogout3.Visible = true;

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void PbLogout2_MouseLeave(object sender, EventArgs e)
        {
            pbLogout2.Visible = false;
        }


        #endregion
        
        private void AGVMain_Load(object sender, EventArgs e) // 로그인 시 입력받은 운행자 이름 메뉴쪽에 표시
        {
            lbOperator.Text = GetOperatorName;
        }
        #endregion

        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pbCam.Image = bmp;
        }

        #region 작업지시리스트
        private void BtnAdd_Click(object sender, EventArgs e) // lbWorklist에 작업 추가
        {
            if (rbtnpass.Checked)
                lbWorklist.Items.Add(rbtnpass.Text);

            if (rbtnunpass.Checked)
                lbWorklist.Items.Add(rbtnunpass.Text);
        }

        private void BtnDel_Click(object sender, EventArgs e) // lbWorklist에 작업 삭제
        {
            if (lbWorklist.SelectedIndex > -1)
                lbWorklist.Items.RemoveAt(lbWorklist.SelectedIndex);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var item = lbWorklist.SelectedItem;
            if (item.Equals(rbtnpass.Text) == true)
            {
                data = "2"; // 양품
                byte[] buff = Encoding.UTF8.GetBytes(data);

                // (3) 서버에 데이타 전송
                sock.Send(buff, SocketFlags.None);

                lbWorklist.Items.RemoveAt(lbWorklist.SelectedIndex);
            }

            else if (item.Equals(rbtnunpass.Text) == true)
            {
                data = "1"; // 불량품
                byte[] buff = Encoding.UTF8.GetBytes(data);

                // (3) 서버에 데이타 전송

                sock.Send(buff, SocketFlags.None);

                lbWorklist.Items.RemoveAt(lbWorklist.SelectedIndex);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("미구현");
        }
        #endregion

        #region 작업지시 탭에서 연결, 연결해제 했을 경우
        private void UscRegistControl_Connect_Click(object sender, RegistControl.Connect_ClickEventArgs e)
        {
            lbAGVState.Text = "운행중";
            lbAGVState.ForeColor = Color.PaleGreen;

            e.Stream.NewFrame += stream_NewFrame;

            pbMap.Image = Image.FromFile(e.MapAddress);
        }

        private void UscRegistControl_Disconnect_Click(object sender, RegistControl.Disconnect_ClickEventArgs e)
        {
            lbAGVState.Text = "미운행중";
            lbAGVState.ForeColor = Color.LightCoral;

            pbMap.Image = Resources.warning;

            e.Sock.Close();
            e.Stream.Stop();
        }
        #endregion
    }
}
