using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ImageTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics m_graphics;
        Image img = new Bitmap(@"d:\target.png");
        private BufferedGraphicsContext m_CurrentContext;
        private BufferedGraphics m_Graphics;
        Point prePosition = new Point();
        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox pic_target = new PictureBox();

            
            
            pic_target.Image = img;
            m_graphics = this.CreateGraphics();
            
            //m_graphics.Clear(Color.Gray);
            m_CurrentContext = BufferedGraphicsManager.Current;

            m_Graphics = m_CurrentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            m_Graphics.Graphics.Clear(Color.Gray);
            m_Graphics.Graphics.DrawImage(img,new PointF(50,50));
            timer1.Start();
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_Graphics.Render(this.CreateGraphics());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            m_Graphics.Graphics.Clear(Color.Azure);
            Pen pen = new Pen(Color.Yellow, 2); //畫筆
            if (prePosition != new Point(0,0))
            {
                m_Graphics.Graphics.DrawLine(pen, prePosition.X, prePosition.Y, e.X, e.Y);
                m_Graphics.Graphics.DrawImage(img, new PointF(e.X, e.Y));
            }
            prePosition = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 1);
            m_Graphics.Graphics.DrawEllipse(pen, e.X , e.Y , 2, 2);
        }

    }
}

    
