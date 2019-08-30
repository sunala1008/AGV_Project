using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using System.Net.Sockets;
using System.Net;

namespace AGVProj
{
    public partial class CameraConrtol : UserControl
    {
        MJPEGStream stream;

        // 1. 소켓 객체 생성 (TCP 소켓)
        //Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // 2. 서버 연결
        //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 9000);   // Server_IP, Port 번호

        public CameraConrtol()
        {
            InitializeComponent();
        }

        private void CameraConrtol_Load(object sender, EventArgs e)
        {
            //socket.Connect(ep);

            //string data = string.Empty;
            //byte[] receiverBuff = new byte[8192];
            //stream = new MJPEGStream("http://192.168.0.82:8081"); // 720x480 : 화면 비율
        }

        public void Camera_IP(EnrollClass enrollClass)
        {
            label1.Text = enrollClass.cIP;
          
        }

    }
}
