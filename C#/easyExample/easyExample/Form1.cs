using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <10; j++)
                {
                    if (j < i)
                        System.Console.Write("*");
                }
                System.Console.Write("\r\n");
            }
            ////////////////////////////////
            int zi=0,zj=0;
            while (zi < 10)
            {
                zj = 0;
                while (zj < 10)
                {
                    if (zj < zi)
                        System.Console.Write("0");
                    zj++;
                }
                System.Console.Write("\r\n");
                zi++;
            }
            ///////////////////////////////
            int mode=0;
            char symbol;
            mode = Convert.ToInt32( textBox1.Text);
            switch (mode)
            {
                case 1:
                    symbol = '!';
                    break;
                case 2:
                    symbol = '@';
                    break;
                case 3:
                    symbol = '#';
                    break;
                case 4:
                    symbol = '$';
                    break;
                default:
                    symbol = '%';
                    break;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j < i)
                        System.Console.Write(symbol);
                }
                System.Console.Write("\r\n");
            }
            //////////////////////////
            string[] name = new string[5] {"Amanda","ben", "Cathy", "David","Eve" };
            foreach (string nameData in name)
            {
                System.Console.Write(nameData+'\n'); 
            }
            //////////////////////////

        }


    }
}
