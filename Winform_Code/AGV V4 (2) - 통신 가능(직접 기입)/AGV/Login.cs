using AGV.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Icon = Resources.AGV_Navigation_icon_drop_shadow1; // 프로그램 Icon 설정
        }

        #region 종료
        private void PbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Resources.exit_black_small_01;
        }

        private void PbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Resources.exit_white_small_01;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region 로그인
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Enum = txbId.Text;
            string pw = txbPassword.Text;
            string EName = txbOperator.Text;

            Regist regist = DB.employee.Check(Enum, pw, EName);

            if(regist != null)
            {
                this.Hide();
                AGVMain agv = new AGVMain(txbOperator.Text);
                agv.Owner = this;
                agv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("비밀번호를 다시 입력해 주세요.");
            }
        }

        private void TxbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            string Enum = txbId.Text;
            string pw = txbPassword.Text;
            string EName = txbOperator.Text;

            if (e.KeyCode == Keys.Enter)
            {              
                Regist regist = DB.employee.Check(Enum, pw, EName);

                if (regist != null)
                {
                    this.Hide();
                    AGVMain agv = new AGVMain(txbOperator.Text);
                    agv.Owner = this;
                    agv.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호를 다시 입력해 주세요.");
                }
            }
        }

        #endregion

        private void BtnRegist_Click(object sender, EventArgs e) // 사원 등록
        {
            Regist regist = new Regist();

            ERegist eregist = new ERegist(regist);

            eregist.ShowDialog();
        }
    }
}
