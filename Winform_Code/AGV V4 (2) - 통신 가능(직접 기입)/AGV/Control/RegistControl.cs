using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using AForge.Video;

namespace AGV.Control
{
    public partial class RegistControl : UserControl
    {
        MJPEGStream stream;

        // (1) 소켓 객체 생성 (TCP 소켓)
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public RegistControl()
        {
            InitializeComponent();
        }

        #region AGV 등록 & 삭제

        static string image_file = string.Empty;

        private void BtnMapLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\"; // 초기 폴더

            if (dialog.ShowDialog() == DialogResult.OK)
                image_file = dialog.FileName;
            else if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            pbmap.Image = Bitmap.FromFile(image_file);
            pbmap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnAGVRegist_Click(object sender, EventArgs e)
        {
            AGVRegist aGVRegist = new AGVRegist();

            aGVRegist.AGVName = tbAGVName.Text;
            aGVRegist.RegisterName = tbRegisterName.Text;
            aGVRegist.AGVIP = tbAGVIP.Text;
            aGVRegist.AGVPort = tbAGVPort.Text;
            aGVRegist.CamIP = tbCamIP.Text;
            aGVRegist.CamPort = tbCamPort.Text;
            aGVRegist.Map = image_file.ToString();
            //aGVRegist.Num = 2;

            DB.agvInfo.Insert(aGVRegist);
        }

        private void BtnLoad_Click(object sender, EventArgs e) // AGV 등록 List Load
        {
            bdsAGVList.DataSource = DB.agvInfo.GetAll();
        }

        private void DgvAGVList_KeyUp(object sender, KeyEventArgs e) // 등록된 AGV List에서 삭제
        {
            if (e.KeyCode == Keys.Delete)
            {
                AGVRegist aGVRegist = dgvAGVList.CurrentRow.DataBoundItem as AGVRegist;

                if (aGVRegist == null)
                    return;

                if (FormHelper.SureToDelete())
                    DB.agvInfo.Delete(aGVRegist);
            }
        }
        #endregion

        #region AGV 연결

        #region Connect_Click event things for C# 3.0
        public event EventHandler<Connect_ClickEventArgs> Connect_Click;

        protected virtual void OnConnect_Click(Connect_ClickEventArgs e)
        {
            if (Connect_Click != null)
                Connect_Click(this, e);
        }

        private Connect_ClickEventArgs OnConnect_Click(Socket sock, MJPEGStream stream)
        {
            Connect_ClickEventArgs args = new Connect_ClickEventArgs(sock, stream);
            OnConnect_Click(args);

            return args;
        }

        private Connect_ClickEventArgs OnConnect_ClickForOut()
        {
            Connect_ClickEventArgs args = new Connect_ClickEventArgs();
            OnConnect_Click(args);

            return args;
        }

        public class Connect_ClickEventArgs : EventArgs
        {
            public Socket Sock { get; set; }
            public MJPEGStream Stream { get; set; }

            public Connect_ClickEventArgs()
            {
            }

            public Connect_ClickEventArgs(Socket sock, MJPEGStream stream)
            {
                Sock = sock;
                Stream = stream;
            }
        }
        #endregion

        private void BtnAGVConnect_Click(object sender, EventArgs e)
        {
            //#region TCP/IP 통신
            //string AGVIP = dgvAGVList.CurrentRow.Cells[2].ToString();
            //string AGVPort = dgvAGVList.CurrentRow.Cells[3].ToString();

            //// (2) 서버에 연결
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse(AGVIP), int.Parse(AGVPort));   // Server_IP, Port 번호

            //#endregion

            #region 카메라 스트리밍
            var CamIP = dgvAGVList.CurrentRow.Cells[4].Value;
            var CamPort = dgvAGVList.CurrentRow.Cells[5].Value;

            //string CAM = "http://" + CamIP + ":" + CamPort;
            string CAM = "http://" + CamIP + ":" + CamPort;

            //sock.Connect(ep);

            string data = string.Empty;
            byte[] receiverBuff = new byte[8192];
            stream = new MJPEGStream(CAM);

            stream.Start();
            //stream.NewFrame += stream_NewFrame;
            #endregion

            OnConnect_Click(sock, stream);
        }
        #endregion

        #region AGV 연결 해제

        #region Disconnect_Click event things for C# 3.0
        public event EventHandler<Disconnect_ClickEventArgs> Disconnect_Click;

        protected virtual void OnDisconnect_Click(Disconnect_ClickEventArgs e)
        {
            if (Disconnect_Click != null)
                Disconnect_Click(this, e);
        }

        private Disconnect_ClickEventArgs OnDisconnect_Click(Socket sock, MJPEGStream stream)
        {
            Disconnect_ClickEventArgs args = new Disconnect_ClickEventArgs(sock, stream);
            OnDisconnect_Click(args);

            return args;
        }

        private Disconnect_ClickEventArgs OnDisconnect_ClickForOut()
        {
            Disconnect_ClickEventArgs args = new Disconnect_ClickEventArgs();
            OnDisconnect_Click(args);

            return args;
        }

        public class Disconnect_ClickEventArgs : EventArgs
        {
            public Socket Sock { get; set; }
            public MJPEGStream Stream { get; set; }

            public Disconnect_ClickEventArgs()
            {
            }

            public Disconnect_ClickEventArgs(Socket sock, MJPEGStream stream)
            {
                Sock = sock;
                Stream = stream;
            }
        }
        #endregion

        private void BtnAGVDisconnect_Click(object sender, EventArgs e)
        {
            sock.Close();
            stream.Stop();

            OnDisconnect_Click(sock, stream);
        }
        #endregion

    }
}
