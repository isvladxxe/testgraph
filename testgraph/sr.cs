using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace testgraph
{
    public partial class sr : Form
    {
        long count;
        public Bitmap img1;
        public Bitmap img2;
        public Pixel[,] mas1;
        public Pixel eq = new Pixel(255, 255, 255);
        public Pixel[,] mas2;
        public Pixel[,] mas3;
        public sr()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img1;
                mas1 = Pixel.toMas(img1);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = img2;
                mas2 = Pixel.toMas(img2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            mas3 = new Pixel[img1.Width, img1.Height];
            if (checkBox1.Checked)
            {
                count = img1.Height * img1.Width;
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (mas1[i, j] != mas2[i, j])
                        {
                            count--;
                            mas3[i, j] = eq;
                        }

                    }
                }
            }
            else
            {
                count = 0;
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        if (mas1[i, j] == mas2[i, j])
                        {
                            mas3[i, j] = mas1[i, j]; count++;
                        }
                        else
                        {

                            mas3[i, j] = new Pixel(0, 0, 0);

                        }
                    }
                }
            }
            pictureBox3.Image = Pixel.toBmp(mas3, img1.Width, img1.Height);
            this.Text = " " + count + " / " + img1.Height * img1.Width + "  " + ((count / (double)(img1.Height * img1.Width))) * 100 + "%";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pixel.toBmp(mas3, img1.Width, img1.Height).Save(saveFileDialog1.FileName, Pixel.getFormat(
                   Path.GetExtension(saveFileDialog1.FileName)));
            }
        }
    }
}
