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
        public Form1()
        {
            InitializeComponent();
        }

        private void Mandelbrot_Click(object sender, EventArgs e)
        {

        }

        private void newCoords_Click(object sender, EventArgs e)
        {

        }

        private void Mandelbrot_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("X: {0} Y: {1}", MousePosition.X, MousePosition.Y));
        }
    }
}
