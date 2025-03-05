using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Proyecto_Final
{
    public partial class FrmFractales : Form
    {
        private Fractal1 fractal1;
        private double zoomFactor1 = 1.0; 
        private Color fractalColor = Color.Black;
        private Color backgroundColor = Color.White;
        private int maxIterations = 7000;


        public FrmFractales()
        {
            InitializeComponent();
            fractal1 = new Fractal1(maxIterations, 2.0, fractalColor, backgroundColor);       
            this.MouseWheel += new MouseEventHandler(FrmFractales_MouseWheel);
            picCanvas.Focus();
        }

        private void FrmFractales_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoomFactor1 *= 1.1; 
            }
            else
            {
                zoomFactor1 /= 1.1;
            }

            if (picCanvas.Tag.ToString() == "Fractal1")
            {
                RedrawFractal1();
            }
        }

        private void RedrawFractal1()
        {
            fractal1.MaxIterations = maxIterations;
            fractal1.FractalColor = fractalColor;
            fractal1.BackgroundColor = backgroundColor;

            Bitmap fractalImage = fractal1.GenerateFractal(picCanvas.Width, picCanvas.Height, zoomFactor1);
            picCanvas.Image = fractalImage;
            picCanvas.Tag = "Fractal1";
        }

        private void btnFractal1_Click(object sender, EventArgs e)
        {
            zoomFactor1 = 1.0;
            RedrawFractal1();
        }

        private void btnColorFractal_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fractalColor = colorDialog.Color;
                RedrawFractal1();
            }
        }

        private void btnColorBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = colorDialog.Color;
                RedrawFractal1();
            }
        }

        private void numericUpDownIterations_ValueChanged(object sender, EventArgs e)
        {
            maxIterations = (int)numericUpDownIterations.Value;
            RedrawFractal1();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
