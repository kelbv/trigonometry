using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blank2
{
    public partial class Form1 : Form
    {
        List<Point> traces;
        int pbw;
        int pbh;
        complexnumber z1, z2, z3;
        complexnumber xoyo;
        complexnumber dragger;
        complexnumber unitdraggerX, unitdraggerY;
        complexnumber ithnthroot;
        double maxMod, dotsPerUnit;
        Point ithnthrootPoint;
        Point z1Point;
        Bitmap b;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            xoyo = new complexnumber(3, 4);
            dragger = new complexnumber(0, 0);
            unitdraggerY = new complexnumber(0, 0);
            unitdraggerX = new complexnumber(0, 0);
            z1 = new complexnumber(0, 0);
            z2 = new complexnumber(0, 0);
            z3 = new complexnumber(0, 0);

            pbw = pictureBox1.Width;
            traces = new List<Point>();
            pbh = pictureBox1.Height;
            b = new Bitmap(pbw, pbh);
            g = Graphics.FromImage(b);
            Brush f2b = new SolidBrush(System.Drawing.Color.White);
            g.FillRectangle(f2b, 0, 0, pbw, pbh);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            maxMod = 1;
            dotsPerUnit = (pbh / (maxMod + 1)) / 2.0;
            pictureBox1.Invalidate();
            drawStuff(true);
        }

        public bool onGraph(int x, int y)
        {
            bool onGraph = false;
            if (x > -1 && x <= pbw && y > -1 && y <= pbh)
            {
                onGraph = true;
            }
            return onGraph;
        }


        public Point getCoord(double x, double y, double dotsPerUnit, int width, int height)
        {
            // what we need to do
            // give the method a x and y value, and get back the picturebox1 coords of that value
            // X 
            // zero is width / 2;
            // x is int(width/2  + x * dotsPerUnit)
            int xcoord = (int)(width / 2 + x * dotsPerUnit);

            // Y
            // zero is height / 2;
            // y is zero - y * dotsPerUnit
            int ycoord = (int)(height / 2 - y * dotsPerUnit);
            return new Point(xcoord, ycoord);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            drawStuff(true);
        }

        public static int interpolate(int v1, int v2, int x1, int x, int x2)
        {
            if (x1 == x2)
            {
                return (v1 + v2) / 2;
            }
            else
            {
                return (v2 * (x - x1) + v1 * (x2 - x)) / (x2 - x1);
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            drawStuff(true);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pbw = pictureBox1.Width;
            pbh = pictureBox1.Height;

            if (onGraph(e.X, e.Y))
            {
                if (e.Button == MouseButtons.Left)
                {
                    //textBox1.AppendText("left " + e.X + "," + e.Y);
                    z1 = resolvePoint(e.X, e.Y);
                    ////////maxMod = Math.Max(Math.Max(z1.getModulus(), z2.getModulus()), z3.getModulus());
                    ////////if ((pbh / (maxMod + 1)) / 2 > 10)
                    ////////{
                    ////////    dotsPerUnit = (pbh / (maxMod + 1)) / 2;
                    ////////}
                    //dotsPerUnit = 75;
                    drawStuff(true);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    //textBox1.AppendText("right " + e.X + "," + e.Y);
                    z2 = resolvePoint(e.X, e.Y);
                    //////maxMod = Math.Max(Math.Max(z1.getModulus(), z2.getModulus()), z3.getModulus());
                    //////if ((pbh / (maxMod + 1)) / 2 > 10)
                    //////{
                    //////    dotsPerUnit = (pbh / (maxMod + 1)) / 2;
                    //////}

                    //dotsPerUnit = 75;              
                    drawStuff(true);
                }
                else
                {
                    return;
                }
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = 1;
                textBox1.ScrollToCaret();

            }
            else
            {
                return;
            }
        }

        public static double interpolate(double v1, double v2, double x1, double x, double x2)
        {
            if (x1 == x2)
            {
                return (v1 + v2) / 2;
            }
            else
            {
                return (v2 * (x - x1) + v1 * (x2 - x)) / (x2 - x1);
            }
        }



        public complexnumber resolvePoint(int x, int y)
        {
            complexnumber result = new complexnumber(0, 0);
            // xzero = pbw/2
            // z - zero = dots distance
            // value = dots distance / dotsperunit

            double real = (x - pbw / 2) / dotsPerUnit;
            if (Math.Abs(real - (int)(real)) < 0.1)
            {
                real = (int)(real);
            }
            double imag = (pbh / 2 - y) / dotsPerUnit;
            if (Math.Abs(imag - (int)(imag)) < 0.1)
            {
                imag = (int)(imag);
            }
            result = new complexnumber(real, imag);
            return result;
        }



        public void drawStuff(bool doit)
        {
            pbw = pictureBox1.Width;
            pbh = pictureBox1.Height;
            b = new Bitmap(pbw, pbh);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Font drawFont = new Font("Lucida Console", 8);


            Color paperColor = System.Drawing.Color.White;
            Brush paperBrush = new SolidBrush(paperColor);


            Color axisColor = System.Drawing.Color.FromArgb(255, 200, 200, 200);
            Brush axisBrush = new SolidBrush(axisColor);
            Pen axisPen = new Pen(axisBrush);

            Color graphColor = System.Drawing.Color.FromArgb(255, 235, 235, 235);
            Brush graphBrush = new SolidBrush(graphColor);
            Pen graphPen = new Pen(graphBrush);

            Color xoyoColor = System.Drawing.Color.DarkCyan;
            Brush xoyoBrush = new SolidBrush(xoyoColor);
            Pen xoyoPen = new Pen(xoyoBrush);

            Color z1Color = System.Drawing.Color.Red;
            Brush z1Brush = new SolidBrush(z1Color);
            Pen z1Pen = new Pen(z1Brush);
            Pen Z1MinusPen = new Pen(z1Brush);
            Z1MinusPen.DashPattern = new float[] { 3.0F, 3.0F };
            z1Pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            double xscale = (pbw / dotsPerUnit) / 2.0;
            double yscale = (pbh / dotsPerUnit) / 2.0;

            g.FillRectangle(paperBrush, 0, 0, pbw, pbh);

            if (doit)
            {
                for (int i = (int)(xscale * -1); i <= xscale; i++)
                {
                    g.DrawLine(graphPen,
                                    getCoord(i, yscale * -1, dotsPerUnit, pbw, pbh),
                                    getCoord(i, yscale, dotsPerUnit, pbw, pbh));

                }

                for (int i = (int)(yscale * -1); i <= yscale; i++)
                {
                    g.DrawLine(graphPen,
                                    getCoord(xscale * -1, i, dotsPerUnit, pbw, pbh),
                                    getCoord(xscale, i, dotsPerUnit, pbw, pbh));

                }

                g.DrawLine(axisPen, getCoord(xscale * -1, 0, dotsPerUnit, pbw, pbh), getCoord(xscale, 0, dotsPerUnit, pbw, pbh));
                g.DrawLine(axisPen, getCoord(0, yscale, dotsPerUnit, pbw, pbh), getCoord(0, yscale * -1, dotsPerUnit, pbw, pbh));
            }

            pictureBox1.Image = b;
            pictureBox1.Refresh();
        }

        public class complexnumber
        {
            double real;
            double imag;

            override public string ToString()
            {
                return "( " + real + " , " + imag + " )";
            }

            public complexnumber(double a, double b)
            {
                real = a;
                imag = b;
            }

            public complexnumber(double argument, double modulus, bool useless)
            {
                real = modulus * Math.Cos(argument);
                imag = modulus * Math.Sin(argument);
            }

            public static complexnumber multiply(complexnumber z1, complexnumber z2)
            {
                complexnumber z3 = new complexnumber(0, 0);
                // (a + bi)(c + di) = ac - bd + i(ad + bc);
                z3.real = z1.real * z2.real - z1.imag * z2.imag;
                z3.imag = z1.real * z2.imag + z1.imag * z2.real;
                return z3;
            }

            public double getReal()
            {
                return real;
            }

            public double getImag()
            {
                return imag;
            }

            public double getModulus()
            {
                return Math.Sqrt(real * real + imag * imag);
            }

            public double getArgument()
            {
                double arg = Math.Atan2(imag, real);
                //if (arg < 0)
                //{
                //    arg = arg + Math.PI;
                //}
                return arg;
            }

            public float getDegrees()
            {
                float f = Convert.ToSingle(360 * getArgument() / (Math.PI * 2));
                return f;
            }

        }

    }
}
