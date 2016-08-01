using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgraph
{
    public partial class yarkost : Form
    {
        public Pixel[,] orig;
        public Pixel[,] data;
        public int width;
        public int height;

        public yarkost()
        {
            InitializeComponent();
        }

        private void ColorSwap_Load(object sender, EventArgs e)
        {
            data = orig;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = (Pixel[,])orig.Clone();
            int w = width;
            int h = height;
            double contrast = trackBar2.Value;
            contrast = (255 + contrast) / 255;
            int value = trackBar1.Value;
            Action<int> yarkost = (y) =>
            {
                for (int x = 0; x < w; x++)
                {
                    double temp = (int)data[x, y].Red + value;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = 0;
                    data[x, y].Red = (byte)(temp);

                    temp = (int)data[x, y].Green + value;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = 0;
                    data[x, y].Green = (byte)(temp);

                    temp = (int)data[x, y].Blue + value;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = 0;
                    data[x, y].Blue = (byte)(temp);
                    //
                    temp = data[x, y].Red * contrast;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = -1 * temp;
                    data[x, y].Red = (byte)(temp);

                    temp = data[x, y].Green * contrast;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = -1 * temp;
                    data[x, y].Green = (byte)(temp);

                    temp = data[x, y].Blue * contrast;
                    if (temp > 255) { temp = 255; }
                    else
                        if (temp < 0) temp = -1 * temp;
                    data[x, y].Blue = (byte)(temp);




                }

            };
            Parallel.For(0, h, yarkost);
            pictureBox1.Image = Pixel.toBmp(data, width, height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            data = (Pixel[,])orig.Clone();
            if ((width > 1000) && (height > 600))
            {
                pictureBox1.Width = width / (SystemInformation.VirtualScreen.Width / 250);
                pictureBox1.Height = height / (SystemInformation.VirtualScreen.Height / 250);
            }
            else
            {
                pictureBox1.Width = width;
                pictureBox1.Height = height;
            }
            pictureBox1.Image = Pixel.toBmp(data, width, height);
            this.Width = pictureBox1.Width + pictureBox1.Location.X + 5;
            this.Height = pictureBox1.Height + pictureBox1.Location.Y + 5;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void trackBar1_KeyUp(object sender, KeyEventArgs e)
        {
            button1_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }


        private void yarkost_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
