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
        // added comment 2020 12 09
        // added second comment 2020 12 09
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

            DoubleBuffered = true;
            pbw = pictureBox1.Width;
            traces = new List<Point>();
            pbh = pictureBox1.Height;
            b = new Bitmap(pbw, pbh);
            g = Graphics.FromImage(b);
            Brush f2b = new SolidBrush(System.Drawing.Color.White);
            g.FillRectangle(f2b, 0, 0, pbw, pbh);
            pictureBox1.Image = b;
            pictureBox1.Refresh();
            maxMod = 1.5;
            dotsPerUnit = (pbh / (maxMod  )) / 2.0;
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


        public Point getCoord(double x, double y)
        {
            // what we need to do
            // give the method a x and y value, and get back the picturebox1 coords of that value
            // X 
            // zero is width / 2;
            // x is int(width/2  + x * dotsPerUnit)
            int xcoord = (int)(pbw / 2 + x * dotsPerUnit);

            // Y
            // zero is height / 2;
            // y is zero - y * dotsPerUnit
            int ycoord = (int)(pbh / 2 - y * dotsPerUnit);
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
                //textBox1.SelectionStart = 0;
                //textBox1.SelectionLength = 0;
                //textBox1.ScrollToCaret();

            }
            else
            {
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbAnglesDegrees_CheckedChanged(object sender, EventArgs e)
        {
            drawStuff(true);
        }

        private void maxmodud_ValueChanged(object sender, EventArgs e)
        {
            maxMod = (double)maxmodud.Value + 0.5;
            drawStuff(true);
        }

        private void cbDrawArcs_CheckedChanged(object sender, EventArgs e)
        {
            drawStuff(true);
        }

        private void cbSnapToDegrees_CheckedChanged(object sender, EventArgs e)
        {
            drawStuff(true);
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
            if (Math.Abs(real - (int)(real)) < 0.0001)
            {
                real = (int)(real);
            }
            double imag = (pbh / 2 - y) / dotsPerUnit;
            if (Math.Abs(imag - (int)(imag)) < 0.0001)
            {
                imag = (int)(imag);
            }
            result = new complexnumber(real, imag);
            return result;
        }



        public void drawStuff(bool doit)
        {
            try
            {
                pbw = pictureBox1.Width;
                pbh = pictureBox1.Height;
                b = new Bitmap(pbw, pbh);
                dotsPerUnit = (pbh / (maxMod)) / 2.0;
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

                Color z2Color = System.Drawing.Color.Blue;
                Brush z2Brush = new SolidBrush(z2Color);
                Pen z2Pen = new Pen(z2Brush);
                Pen Z2MinusPen = new Pen(z2Brush);
                Z2MinusPen.DashPattern = new float[] { 3.0F, 3.0F };
                z2Pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                Color z3Color = System.Drawing.Color.DarkGreen;
                Brush z3Brush = new SolidBrush(z3Color);
                Pen z3Pen = new Pen(z3Brush);
                Pen Z3MinusPen = new Pen(z3Brush);
                Z3MinusPen.DashPattern = new float[] { 3.0F, 3.0F };
                z3Pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                Color z4Color = System.Drawing.Color.FromArgb(255, 255, 131, 0);
                Brush z4Brush = new SolidBrush(z4Color);
                Pen z4Pen = new Pen(z4Brush);
                Pen Z4MinusPen = new Pen(z4Brush);
                Z4MinusPen.DashPattern = new float[] { 3.0F, 3.0F };
                //z4Pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                Color z4ColorA = System.Drawing.Color.FromArgb(80, 255, 131, 0);
                Brush z4BrushA = new SolidBrush(z4ColorA);
                Pen z4PenA = new Pen(z4BrushA);
                z4PenA.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;

                double xscale = (pbw / dotsPerUnit) / 2.0;
                double yscale = (pbh / dotsPerUnit) / 2.0;

                g.FillRectangle(paperBrush, 0, 0, pbw, pbh);


                if (doit)
                {
                    for (int i = (int)(xscale * -1); i <= xscale; i++)
                    {
                        g.DrawLine(graphPen,
                                        getCoord(i, yscale * -1),
                                        getCoord(i, yscale));

                    }

                    for (int i = (int)(yscale * -1); i <= yscale; i++)
                    {
                        g.DrawLine(graphPen,
                                        getCoord(xscale * -1, i),
                                        getCoord(xscale, i));

                    }

                    g.DrawLine(axisPen, getCoord(xscale * -1, 0), getCoord(xscale, 0));
                    g.DrawLine(axisPen, getCoord(0, yscale), getCoord(0, yscale * -1));
                }
                Rectangle bound = new Rectangle(
                             getCoord(-1, 1).X,
                             getCoord(-1, 1).Y,
                             (int)(dotsPerUnit * 2),
                             (int)(dotsPerUnit * 2));

                Rectangle boundArc = new Rectangle(
                 getCoord(-0.4, 0.4).X,
                 getCoord(-0.4, 0.4).Y,
                 (int)(dotsPerUnit * 0.8),
                 (int)(dotsPerUnit * 0.8));

                g.DrawEllipse(z1Pen, bound);

                z1Point = getCoord(z1.getReal(), z1.getImag());
                // g.FillEllipse(z2Brush, z1Point.X - 3, z1Point.Y - 3, 6, 6);

                double theta = Math.Round(Math.Atan2(z1.getImag(), z1.getReal()),3);
                if (theta < 0)
                {
                    theta = theta + (Math.PI * 2);
                }
                // double ttt = Math.Tan(theta);
                double truetheta = theta;
                float thetadegrees = (float)((theta * 360) / (Math.PI * 2)) * -1;
                //float thetadegrees = (float)(((theta * 360) / (Math.PI * 2)) * -1);
                if (rbAnglesDegrees.Checked && cbSnapToDegrees.Checked)
                {
                    thetadegrees = (int)thetadegrees;
                    theta = (thetadegrees / 360.0) * Math.PI * 2 * (-1);
                    truetheta = theta;
                }
                double sss = Math.Sin(theta);
                double ccc = Math.Cos(theta);
                double ttt = Math.Tan(theta);
                string text1stuff = "";
                //double scsc = sss * ccc;

                text1stuff += "    theta  = " + string.Format("{0:0.000}", thetadegrees * (-1)) + " (degrees)\r\n";
                text1stuff += "    theta  = " + string.Format("{0:0.000}", theta) + " (radians)\r\n";
                text1stuff += "sin(theta) = " + string.Format("{0:0.00000}", Math.Sin(theta)) + "\r\n";
                text1stuff += "cos(theta) = " + string.Format("{0:0.00000}", Math.Cos(theta)) + "\r\n";
                Point ztan = getCoord(0, 0);
                try
                {
                    ztan = getCoord(1, ttt);
                    Point ztanz = getCoord(0, ttt);


                    Point zero = getCoord(0, 0);
                    Point minusThree = getCoord(1, -10);
                    Point onezero = getCoord(1, 0);
                    Point plusThree = getCoord(1, 10);
                    Point zCircle = getCoord(ccc, sss);
                    Point zThetatext = getCoord(0.15, 0.15);
                    Point zx = getCoord(ccc, 0);
                    Point zy = getCoord(0, sss);
                    Point zArcLength = getCoord(1, theta);
                    //Point zscsc = getCoord(scsc, 0);

                    try
                    {
                        g.DrawLine(Z2MinusPen, zCircle, ztan);
                    }
                    catch (Exception eeee)
                    {

                    }
                    g.DrawLine(z2Pen, zero, zCircle);
                    g.DrawLine(z2Pen, minusThree, plusThree);
                    g.DrawLine(Z3MinusPen, zCircle, zx);
                    g.DrawLine(Z3MinusPen, zCircle, zy);
                    g.FillEllipse(z3Brush, zx.X - 3, zero.Y - 3, 6, 6);
                    //g.FillEllipse(z3Brush, zscsc.X - 3, zscsc.Y - 3, 6, 6);
                    g.DrawString("cos " + string.Format("{0:0.00}", Math.Cos(theta)), drawFont, z3Brush, zx);
                    g.FillEllipse(z3Brush, zero.X - 3, zy.Y - 3, 6, 6);
                    g.DrawString("sin " + string.Format("{0:0.00}", Math.Sin(theta)), drawFont, z3Brush, zy.X, zy.Y + 5);
                    g.FillEllipse(z4Brush, zArcLength.X - 3, zArcLength.Y - 3, 6, 6);
                    g.DrawString("arc length " + string.Format("{0:0.00}", theta), drawFont, z4Brush, zArcLength.X + 18, zArcLength.Y);
                    if (cbDrawArcs.Checked == false)
                    {
                        g.DrawLine(z4Pen, zCircle, zArcLength);

                    }
                    else
                    {
                        g.DrawLine(z4Pen, onezero, zArcLength);
                        double rsteps = Math.Max(thetadegrees * (-1) * 2, 50);
                        for (int rstep = 0; rstep < rsteps; rstep++)
                        {
                            try
                            {
                                double rmax = 1000;
                                double rcurrent = 1 + (rmax * (Math.Pow((rstep / rsteps), 6)));
                                Point mytopcorner = getCoord(1 - (2 * rcurrent), rcurrent);
                                Size mysize = new Size(minusThree.X - mytopcorner.X, minusThree.X - mytopcorner.X);
                                Rectangle myrectangle = new Rectangle(mytopcorner, mysize);
                                float mytheta = (float)((360 * truetheta) / (Math.PI * 2 * rcurrent));
                                int mythetadegrees = (int)((360 * mytheta) / (Math.PI * 2));
                                try
                                {
                                    int arcred = (int)interpolate(255, 0, 0, rstep, rsteps);
                                    int arcblue  = (int)interpolate(0, 255, 0, rstep, rsteps);
                                    int arcgreen = 0;

                                    Color arcColor = System.Drawing.Color.FromArgb(70, arcred, arcgreen, arcblue);
                                    Brush arcBrush = new SolidBrush(arcColor);
                                    Pen arcPen = new Pen(arcBrush);
                                    //arcPen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;

                                    g.DrawArc(arcPen, myrectangle, 0, (-1) * mytheta);
                                    //g.DrawRectangle(z4Pen, myrectangle);

                                }
                                catch (Exception earc)
                                {
                                    MessageBox.Show(earc.Message);
                                }
                            }
                            catch (Exception esweep)
                            {
                                //MessageBox.Show(esweep.Message);
                            }
                        }
                    }

                    try
                    {
                        g.FillEllipse(z2Brush, minusThree.X - 3, ztan.Y - 3, 6, 6);
                        g.FillEllipse(z3Brush, ztanz.X - 3, ztanz.Y - 3, 6, 6);
                        g.DrawLine(Z3MinusPen, ztan, ztanz);
                        //g.DrawString("tan", drawFont, z3Brush, ztan);
                        g.DrawString("tan " + string.Format("{0:0.00}", Math.Tan(theta)), drawFont, z3Brush, ztanz.X, ztanz.Y - 14);
                        text1stuff += "tan(theta) = " + string.Format("{0:0.0000}", Math.Tan(theta));
                    }
                    catch (Exception eeeee)
                    {

                    }
                    g.FillEllipse(z2Brush, zCircle.X - 3, zCircle.Y - 3, 6, 6);
                    g.DrawArc(Z2MinusPen, boundArc, 0, thetadegrees);
                    if (rbAnglesDegrees.Checked)
                    {
                        g.DrawString(string.Format("{0:0.00}", thetadegrees * (-1)), drawFont, z3Brush, zThetatext);
                    }
                    else
                    {
                        g.DrawString(string.Format("{0:0.00}", theta), drawFont, z3Brush, zThetatext);
                    }
                    textBox1.Text = text1stuff;
                    textBox1.Refresh();

                }
                catch (Exception eee)
                {
                    // MessageBox.Show(eee.Message);
                }
            }
            catch (Exception emain)
            {
                // do nothing
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
