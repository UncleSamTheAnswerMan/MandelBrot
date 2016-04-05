using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const int LOOP_MAX = 1000;
        double minX;
        double maxX;
        double maxY;
        double minY;
        const double xStartMin = -2;
        const double xStartMax = 2;
        const double yStartMin = -1.5;
        const double yStartMax = 1.5;
        int zoomLevel = 1;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load");
            minX = xStartMin;
            maxX = xStartMax;
            minY = yStartMin;
            maxY = yStartMax;

            Bitmap bmap = MandelbrotCalc();
            Mandelbrot.Image = bmap;
            Bitmap julesImg = juliaCalc();
            Julia.Image = julesImg;
        }

        private Bitmap MandelbrotCalc()
        {
            Bitmap img = new Bitmap(Mandelbrot.Width, Mandelbrot.Height);
            xMaxTextBox.Text = maxX.ToString();
            xMinTextBox.Text = minX.ToString();
            yMaxTextBox.Text = maxY.ToString();
            yMinTextBox.Text = minY.ToString();
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;

            double xZoom = ((maxX - minX) / img.Width);
            double yZoom = ((maxY - minY) / img.Height);

            double tempZX = 0;
            for (int i = 0; i < img.Width; i++)
            {
                cx = (xZoom * i) - Math.Abs(minX);
                for (int j = 0; j < img.Height; j++)
                {
                    cy = (yZoom * j) - Math.Abs(minY);
                    zx = 0;
                    zy = 0;
                    int count = 0;
                    double dist = zx * zx + zy * zy;
                    while (dist <= 4 && count < LOOP_MAX)
                    {
                        tempZX = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = 2 * tempZX * zy + cy;
                        count++;
                        dist = zx * zx + zy * zy;
                    }
                    if (count != LOOP_MAX)
                    {
                        img.SetPixel(i, j, Color.FromArgb(count % 128 * 2, count % 32 * 7, count % 16 * 16));
                    }
                    else
                    {
                        img.SetPixel(i, j, Color.Black);
                    }

                }
            }

            return img;
        }

        private Bitmap juliaCalc()
        {
            Bitmap img = new Bitmap(Julia.Width, Julia.Height);
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;
            double juleXMin = -3;
            double juleXMax = 3;
            double juleYMin = -3;
            double juleYMax = 3;

            //double xZoom = ((juleXMax - juleXMin) / img.Width);
            //double yZoom = ((juleYMax - juleYMin) / img.Height);
            cy = (juleYMax + juleYMin)/2.0;
            cx = (juleXMax + juleXMin)/2.0;
            //cy = 0;
            //cx = 0;
            Console.WriteLine("cx: {0}, cy: {1}", cx, cy);
            double tempZX = 0;
            for (int i = 0; i < img.Width; i++)
            {
                zx = i;
                for (int j = 0; j < img.Height; j++)
                {
                    zy = j;
                    
                    int count = 0;
                    double dist = zx * zx + zy * zy;
                    while (dist <= 4 && count < LOOP_MAX)
                    {
                        tempZX = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = 2 * tempZX * zy + cy;
                        count++;
                        dist = zx * zx + zy * zy;
                    }
                    if (count < LOOP_MAX)
                    {
                        //img.SetPixel(i, j, Color.White);
                        img.SetPixel(i, j, Color.FromArgb(count % 8 * 32, count % 8 * 32, count % 8 * 32));

                    }
                    else
                    {
                        Console.WriteLine("else");
                        img.SetPixel(i, j, Color.Black);
                    }

                }
            }
            return img;
        }

        private void newCoords_Click(object sender, EventArgs e)
        {
            try {
                maxX = Convert.ToDouble(xMaxTextBox.Text);
                minX = Convert.ToDouble(xMinTextBox.Text);
                maxY = Convert.ToDouble(yMaxTextBox.Text);
                minY = Convert.ToDouble(yMinTextBox.Text);
            }
            catch (Exception except)
            {
                Console.WriteLine(except);

            }
            Bitmap img = MandelbrotCalc();
            Mandelbrot.Image.Dispose();
            Mandelbrot.Image = img;
        }

        private void Mandelbrot_MouseClick(object sender, MouseEventArgs e)
        {
            zoomLevel++;
            
            double xScale = (maxX - minX) / ((double)Mandelbrot.Width);
            double yScale = (maxY - minY) / ((double)Mandelbrot.Height);
            double xZoom = ((double)Mandelbrot.Width) / 4;
            double yZoom = ((double)Mandelbrot.Height) / 4;
            double curXMin = minX;
            double curYMin = minY;
            minX = ((e.X - xZoom) * xScale) - Math.Abs(curXMin);
            maxX = ((e.X + xZoom) * xScale) - Math.Abs(curXMin);
            minY = ((e.Y - yZoom) * yScale) - Math.Abs(curYMin);
            maxY = ((e.Y + yZoom) * yScale) - Math.Abs(curYMin);
            

            Bitmap img = MandelbrotCalc();
            Mandelbrot.Image.Dispose();
            Mandelbrot.Image = img;

            Bitmap julesImg = juliaCalc();
            Julia.Image.Dispose();
            Julia.Image = julesImg;

        }

    }
}
