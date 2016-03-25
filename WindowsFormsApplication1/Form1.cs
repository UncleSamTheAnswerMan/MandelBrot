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
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load");
            Bitmap bmap = MandelbrotCalc(2, -2, 2, -2);
            Mandelbrot.Image = bmap;
        }

        private Bitmap MandelbrotCalc(double xMax, double xMin, double yMax, double yMin)
        {
            Bitmap img = new Bitmap(Mandelbrot.Width, Mandelbrot.Height);
            double zx = 0;
            double zy = 0;
            double cx = 0;
            double cy = 0;

            double xZoom = ((xMax - xMin) / img.Width);
            double yZoom = ((yMax - yMin) / img.Height);

            double tempZX = 0;
            for (int i = 0; i < img.Width; i++)
            {
                cx = (xZoom * i) - Math.Abs(xMin);
                for (int j = 0; j < img.Height; j++)
                {
                    cy = (yZoom * j) - Math.Abs(yMin);
                    zx = 0;
                    zy = 0;
                    int count = 0;
                    double dist = zx * zx + zy * zy;
                    while (dist <= 2 && count < LOOP_MAX)
                    {
                        tempZX = zx;
                        zx = (zx * zx) - (zy * zy) + cx;
                        zy = 2 * tempZX * zy + cy;
                        count++;
                        dist = zx * zx + zy * zy;
                    }
                    if (count != LOOP_MAX)
                    {
                        img.SetPixel(i, j, Color.FromArgb(count % 64 * 4, count % 32 * 7, count % 16 * 16));
                    }
                    else
                    {
                        img.SetPixel(i, j, Color.Black);
                    }

                }
            }

            return img;
        }

        private void newCoords_Click(object sender, EventArgs e)
        {

        }

        private void Mandelbrot_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("click");
        }

    }
}
