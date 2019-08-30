using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGV
{
    class FormHelper
    {
        public static bool SureToDelete()
        {
            return MessageBox.Show("삭제하시겠습니까?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static bool CheckLoginInfo()
        {
            return MessageBox.Show("정보가 일치하지 않습니다. 다시 입력해주세요.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK;
        }

        public static bool ChangeEnum()
        {
            return MessageBox.Show("이미 등록된 사번입니다.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK;
        }
    }
}
