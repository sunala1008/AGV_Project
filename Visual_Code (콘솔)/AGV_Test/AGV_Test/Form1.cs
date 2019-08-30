using AForge.Video;                 // 누겟 추가
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGV_Test
{
    public partial class Form1 : Form
    {
        MJPEGStream stream;

        // (1) 소켓 객체 생성 (TCP 소켓)
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // (2) 서버에 연결
        IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 9000);   // Server_IP, Port 번호
        static string data;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnpass_Click(object sender, EventArgs e)
        {
            data = "1";
            byte[] buff = Encoding.UTF8.GetBytes(data);

            //(3) 서버에 데이타 전송
            sock.Send(buff, SocketFlags.None);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sock.Connect(ep);

            string data = string.Empty;
            byte[] receiverBuff = new byte[8192];
            stream = new MJPEGStream("http://192.168.0.82:8081"); // 720x480 : 화면 비율
            //stream.Start();

            //stream.NewFrame += stream_NewFrame;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sock.Close();
            stream.Stop();
        }

        private void btnunpass_Click(object sender, EventArgs e)
        {
            data = "2"; // 불량품
            byte[] buff = Encoding.UTF8.GetBytes(data);

            // (3) 서버에 데이타 전송
            sock.Send(buff, SocketFlags.None);
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            stream.Start();

            stream.NewFrame += stream_NewFrame;
        }

        void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
            //pictureBox2.Image = bmp;
        }
    }
}
