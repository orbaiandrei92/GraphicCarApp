using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace grafica___masina
{
    public partial class Form1 : Form
    {
        int x, y, d, s, p, h, j, k;
        bool pornire = false;
        bool marsalier = false;
        bool politie = false;
        bool pilot = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y++;
            p++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marsalier = false; 
            pornire = true;
            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            pornire = false;
            marsalier = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pornire = false;
            marsalier = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Black);
            Brush b6 = new SolidBrush(Color.Gray);
            Brush b1 = new SolidBrush(Color.Blue);
            Brush b2 = new SolidBrush(Color.Yellow);
            Brush b3 = new SolidBrush(Color.Red);
            Brush b4 = new SolidBrush(Color.Coral);
            Brush b5 = new SolidBrush(Color.Green);
            Brush b7 = new SolidBrush(Color.White);
            g.Clear(Color.LightCyan);
            if (pornire == true) x++;
            if (marsalier == true) x--;
            g.FillRectangle(b, 0, 123, ClientSize.Width, 50);
            for (d = 0; d < 30; d++) g.FillRectangle(b7, d * 60, 146, 40, 4);
            g.FillRectangle(b7, 1020, 138, 40, 4);
            g.FillRectangle(b7, 1020, 130, 40, 4);
            g.FillRectangle(b7, 1020, 123, 40, 4);
            g.FillRectangle(b7, 1020, 154, 40, 4);
            g.FillRectangle(b7, 1020, 162, 40, 4);
            g.FillRectangle(b7, 1020, 170, 40, 4);

            if ((x > 700) && (j<300))
            {
                j++;
                g.FillRectangle(b6, 1035, 80 + j / 5, 10, 20);
                g.FillRectangle(b6, 1035, 100 + j / 5, 4, 20);
                g.FillRectangle(b6, 1041, 100 + j / 5, 4, 20);
                g.FillRectangle(b6, 1040, 78 + j / 5, 1, 2);
                g.FillRectangle(b6, 1045, 80 + j / 5, 2, 20);
                g.FillRectangle(b6, 1033, 80 + j / 5, 2, 20);
                g.FillEllipse(b6, 1035, 72 + j / 5, 8, 8);
                k = j;
            }

            if ((pilot == true) && (x + 150 > 450) && (x + 150 < 500) && (s == 1)) pornire = false;
            else if ((pilot == true) && (x + 150 > 450) && (x + 150 < 500) && (s == 2)) pornire = true;

            if ((pilot == true) && (x + 150 > 970) && (x + 150 < 1020) && (j < 300)) pornire = false;
            else if ((pilot == true) && (x + 150 > 970) && (x + 150 < 1020) && (j == 300)) pornire = true;

            if ((x + 150 == 1033) && (k < 300))
            {
                pornire = false;
                j = 400;
                g.FillEllipse(b3, 1040, 60 + k / 5, 50, 80);
                g.FillRectangle(b6, 1060, 80 + k / 5, 10, 20);
                g.FillRectangle(b6, 1060, 100 + k / 5, 4, 20);
                g.FillRectangle(b6, 1066, 100 + k / 5, 4, 20);
                g.FillRectangle(b6, 1065, 78 + k / 5, 1, 2);
                g.FillRectangle(b6, 1070, 80 + k / 5, 2, 20);
                g.FillRectangle(b6, 1058, 80 + k / 5, 2, 20);
                g.FillEllipse(b6, 1060, 72 + k / 5, 8, 8);
                politie = true;
            }

            if ((x + 150 == 500) && (s == 1)) politie = true;
            g.FillRectangle(b1, 0 + x, 100, 150, 50);
            g.FillRectangle(b1, 25 + x, 75, 100, 25);
            g.FillEllipse(b6, 12 + x, 135, 30, 30);
            g.FillEllipse(b6, 107 + x, 135, 30, 30);
            g.FillRectangle(b2, 140 + x, 100, 10, 10);
            g.FillRectangle(b2, 27 + x, 77, 42, 22);
            g.FillRectangle(b2, 77 + x, 77, 42, 22);
            g.FillRectangle(b, 22 + x, 102, 10, 5);
            g.FillRectangle(b, 77 + x, 102, 10, 5);
            g.FillRectangle(b3, 0 + x, 100, 10, 10);
            g.FillRectangle(b, 500, 25, 15, 35);
            if (politie == true)
            {
                h++;
                g.FillRectangle(b7, 0 + 3 * h, 100, 150, 50);
                g.FillRectangle(b, 25 + 3 * h, 75, 100, 25);
                if (p < 20) g.FillRectangle(b3, 60 + 3 * h, 60, 30, 15);
                else g.FillRectangle(b1, 60 + 3 * h, 60, 30, 15);
                if (p > 40) p = 0;
                g.FillEllipse(b6, 12 + 3 * h, 135, 30, 30);
                g.FillEllipse(b6, 107 + 3 * h, 135, 30, 30);
                g.FillRectangle(b2, 140 + 3 * h, 100, 10, 10);
                g.FillRectangle(b2, 27 + 3 * h, 77, 42, 22);
                g.FillRectangle(b2, 77 + 3 * h, 77, 42, 22);
                g.FillRectangle(b, 22 + 3 * h, 102, 10, 5);
                g.FillRectangle(b, 77 + 3 * h, 102, 10, 5);
                g.FillRectangle(b3, 0 + 3 * h, 100, 10, 10);
                if ((h * 3 + 150 == x - 50) ||
                   (h * 3 + 150 == x - 51) ||
                   (h * 3 + 150 == x - 52))
                {
                    pornire = false;
                    marsalier = false;
                    h--;
                    //MessageBox.Show("ai trecut pe rosu. carnetul ti-a fost retinut");
                }
            }
            if (y < 200)
            {
                g.FillEllipse(b3, 500, 25, 15, 15);
                s = 1;
            }
            else
            {
                g.FillEllipse(b5, 500, 45, 15, 15);
                s = 2;
            }
            if (y == 400) y = 0;
            //Random h = new Random();
            //Console.Beep(100 + h.Next(500), 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pilot = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pornire = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pornire = true;
        }

        
        

        
    }
}
