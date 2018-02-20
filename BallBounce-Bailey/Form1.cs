using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallBounce_Bailey
{
    public partial class Form1 : Form
    {
        List<Ball> ballList = new List<Ball>();
        SolidBrush ballBrush;

        int r, g, d;

        public Form1()
        {
            InitializeComponent();

            Random randGen = new Random();
            Random colourRand = new Random();

            r = colourRand.Next(0, 256);
            g = colourRand.Next(0, 256);
            d = colourRand.Next(0, 256);

            Color c = Color.FromArgb(r, g, d);
            ballBrush = new SolidBrush(c);

            for (int i = 0; i < 21; i++)
            {
                Ball b = new Ball(randGen.Next(0, 250), randGen.Next(0, 250), randGen.Next(9, 31), randGen.Next(-4, 4), randGen.Next(-4, 4), c);
                ballList.Add(b);
            }
        }

        private void screenTimer_Tick(object sender, EventArgs e)
        {
            foreach (Ball b in ballList)
            {
                b.x += b.xSpeed;
                b.y += b.ySpeed;
            }

            foreach (Ball b in ballList)
            {
                if (b.x <= 0 || b.x >= this.Width - 35)
                {
                    b.xSpeed *= -1;

                    Random colourRand = new Random();

                    r = colourRand.Next(0, 256);
                    g = colourRand.Next(0, 256);
                    d = colourRand.Next(0, 256);

                    Color c = Color.FromArgb(r, g, d);
                    ballBrush = new SolidBrush(c);
                }

                if (b.y <= 0 || b.y >= this.Height - 60) { b.ySpeed *= -1; }                
            }
                Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ball b in ballList)
            {
                e.Graphics.FillRectangle(ballBrush, b.x, b.y, b.size, b.size);
            }
        }
    }
}

