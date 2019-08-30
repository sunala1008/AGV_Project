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
    public partial class ERegist : Form
    {
        public ERegist(Regist regist)
        {
            InitializeComponent();

            Icon = Resources.AGV_Navigation_icon_drop_shadow1; // 프로그램 Icon 설정
        }

        #region 종료
        private void PbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = Resources.exit_white_small_01;
        }

        private void PbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = Resources.exit_black_small_01;
        }
        #endregion

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Regist regist = new Regist();

            if(regist.EmployeeNum == null)
            {
                regist.OperatorName = txbOperator.Text;
                regist.EmployeeNum = txbId.Text;
                regist.Password = txbPassword.Text;

                DB.employee.Insert(regist);

                Close();
            }
        }

        private void TxbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Regist regist = new Regist();

            if (e.KeyCode == Keys.Enter)
            {
                if (regist.EmployeeNum == null)
                {
                    regist.OperatorName = txbOperator.Text;
                    regist.EmployeeNum = txbId.Text;
                    regist.Password = txbPassword.Text;

                    DB.employee.Insert(regist);

                    Close();
                }
            }
        }
    }
}
