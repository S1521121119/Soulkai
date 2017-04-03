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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            sysGlobal.FrmControl_1.Show();
        }


        public void dataAdd(DataObj te)
        {
            textBox1.Text += te.name;
            textBox1.Text += te.password;
            textBox1.Text += te.id.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
