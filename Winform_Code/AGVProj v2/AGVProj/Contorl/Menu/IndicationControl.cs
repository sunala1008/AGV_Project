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
    public partial class IndicationControl : UserControl
    {
        public IndicationControl()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnpass.Checked)
                listBox1.Items.Add(rbtnpass.Text);

            if (rbtnunpass.Checked)
                listBox1.Items.Add(rbtnunpass.Text);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
