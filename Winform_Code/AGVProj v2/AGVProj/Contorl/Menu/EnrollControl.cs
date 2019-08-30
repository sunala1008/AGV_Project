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
    public partial class EnrollControl : UserControl
    {
       
        public EnrollControl()
        {
            InitializeComponent();

        }

        private EnrollClass Enroll_Init()
        {
            EnrollClass enrollClass = new EnrollClass();
            enrollClass.agvName = tbagvname.Text;
            enrollClass.registerName = tbregistername.Text;
            enrollClass.aIP = tbagvip1.Text + "." + tbagvip2.Text + "." + tbagvip3.Text + "." + tbagvip4.Text;
            enrollClass.aPort = tbagvport.Text;

            enrollClass.cIP = tbcameraip1.Text + "." + tbcameraip2.Text + "." + tbcameraip3.Text + "." + tbcameraip4.Text;
            enrollClass.cPort = tbcameraport.Text;

            enrollClass.map = pbmap.Image;

            return enrollClass;

        }

        private string String_List()
        {
            EnrollClass enrollClass = new EnrollClass();
            enrollClass = Enroll_Init();

            string list = enrollClass.agvName + " / " + enrollClass.registerName + " / " + enrollClass.aIP + " / " + enrollClass.aPort + " / " + enrollClass.cIP + " / " + enrollClass.cPort;

            return list;

        }

        #region Connect_Click event things for C# 3.0
        public event EventHandler<Connect_ClickEventArgs> Connect_Click;

        protected virtual void OnConnect_Click(Connect_ClickEventArgs e)
        {
            if (Connect_Click != null)
                Connect_Click(this, e);
        }

        private Connect_ClickEventArgs OnConnect_Click(EnrollClass enrollclass)
        {
            Connect_ClickEventArgs args = new Connect_ClickEventArgs(enrollclass);
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
            public EnrollClass Enrollclass { get; set; }

            public Connect_ClickEventArgs()
            {
            }

            public Connect_ClickEventArgs(EnrollClass enrollclass)
            {
                Enrollclass = enrollclass;
            }
        }
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\"; // 초기 폴더

            if (dialog.ShowDialog() == DialogResult.OK)
                image_file = dialog.FileName;
            else if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            pbmap.Image = Bitmap.FromFile(image_file);
            pbmap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Test(EnrollClass enroll)
        {
            MessageBox.Show("좋아 미안함돠 .....가 보여");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            lbagvlist.Items.Add(String_List());

            if (!lbagvlist.Items.Contains(String_List()))
                lbagvlist.Items.Add(String_List());
        }

       

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (lbagvlist.SelectedIndex > -1)
                lbagvlist.Items.RemoveAt(lbagvlist.SelectedIndex);
        }

        private void btnconnect_Click_1(object sender, EventArgs e)
        {
            if (lbagvlist.SelectedIndex > -1) MessageBox.Show(lbagvlist.SelectedValue.ToString());

            //EnrollClass List 작성이 필요하다!!!
            EnrollClass enrollClass = new EnrollClass();
            enrollClass = Enroll_Init();

            OnConnect_Click(enrollClass);
        }
    }
}
