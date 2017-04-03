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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void FrmStart_Shown(object sender, EventArgs e)
        {
            this.Hide();
            sysGlobal.FrmMain.Show();
            sysGlobal.FrmMain.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStart_FormClosing);

        }



        private void FrmStart_Load(object sender, EventArgs e)
        {


        }


        private void FrmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
