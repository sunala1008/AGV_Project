﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // (1) 소켓 객체 생성 (TCP 소켓)
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // (2) 서버에 연결
            var ep = new IPEndPoint(IPAddress.Parse("192.168.4.1"), 9000);
            sock.Connect(ep);

            string cmd = string.Empty;
            string data = string.Empty;
            byte[] receiverBuff = new byte[1024];

            Console.WriteLine("Connected... Enter Q to exit");

            // Q 를 누를 때까지 계속 Echo 실행
            while ((cmd = Console.ReadLine()) != "Q")
            //while(true)
            {

                byte[] buff = Encoding.UTF8.GetBytes(cmd);

                //// (3) 서버에 데이타 전송
                sock.Send(buff, SocketFlags.None);

                //// (4) 서버에서 데이타 수신
                int n = sock.Receive(receiverBuff);

                data = Encoding.Default.GetString(receiverBuff, 0, n);

                Console.WriteLine(data);

            }
            
            // (5) 소켓 닫기
            sock.Close();
        }
    }
}
