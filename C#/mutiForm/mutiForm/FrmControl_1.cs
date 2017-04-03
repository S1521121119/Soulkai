using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mutiForm.Tools;

namespace mutiForm
{
    public partial class FrmControl_1 : Form
    {
        public FrmControl_1()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            DataObj dataObj = new DataObj();
            dataObj.name = textBox1.Text;
            dataObj.password = textBox2.Text;
            dataObj.id = Convert.ToInt16(textBox3.Text);
            this.Close();
            sysGlobal.FrmMain.dataAdd(dataObj);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
