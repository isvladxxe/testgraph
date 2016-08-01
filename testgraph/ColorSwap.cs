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
    public partial class ColorSwap : Form
    {
        public Pixel[,] orig;
        public Pixel[,] data;
        public int width;
        public int height;

        public ColorSwap()
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
            Action<int> swap = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    byte temp = data[x, y].Blue;
                    data[x, y].Blue = data[x, y].Red;

                    data[x, y].Red = temp;
                }
            };
            Parallel.For(0, height, swap);
            pictureBox1.Image = Pixel.toBmp(data, width, height);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            data = (Pixel[,])orig.Clone();
            pictureBox1.Width = width;
            pictureBox1.Height = height;
            pictureBox1.Image = Pixel.toBmp(data, width, height);
            this.Width = width + 98;
            this.Height = height + 17;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<int> swap = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    byte temp = data[x, y].Green;
                    data[x, y].Green = data[x, y].Red;
                    data[x, y].Red = temp;
                }
            };
            Parallel.For(0, height, swap);
            pictureBox1.Image = Pixel.toBmp(data, width, height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Action<int> swap = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    byte temp = data[x, y].Blue;
                    data[x, y].Blue = data[x, y].Green;
                    data[x, y].Green = temp;
                }
            };
            Parallel.For(0, height, swap);
            pictureBox1.Image = Pixel.toBmp(data, width, height);
        }

        private void button5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
