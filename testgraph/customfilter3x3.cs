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
    public partial class customfilter3x3 : Form
    {
        public Pixel[,] data;
        public Pixel[,] data2;
        public int w;
        public int h;
        double coef = 1;
        double[,] table = new double[3, 3];
        public customfilter3x3()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            table[0, 0] = (double)numericUpDown1.Value;
            table[0, 1] = (double)numericUpDown4.Value;
            table[0, 2] = (double)numericUpDown7.Value;
            table[1, 0] = (double)numericUpDown2.Value;
            table[1, 1] = (double)numericUpDown5.Value;
            table[1, 2] = (double)numericUpDown8.Value;
            table[2, 0] = (double)numericUpDown3.Value;
            table[2, 1] = (double)numericUpDown6.Value;
            table[2, 2] = (double)numericUpDown9.Value;

            calculate();

        }

        void calculate()
        {
            Action<int> gausian = (y) =>
            {
                for (int x = 1; x < w - 1; x++)
                {
                    Pixel[,] dat = new Pixel[3, 3];

                    for (int ax = -1; ax < 2; ax++)
                    {
                        for (int bx = -1; bx < 2; bx++)
                        {
                            dat[1 + ax, 1 + bx] = data[x + ax, y + bx];
                        }
                    }

                    data2[x, y] = matrix.aMxM(dat, table, 3, 3, (double)numericUpDown10.Value, (int)numericUpDown11.Value);

                }
            };
            Parallel.For(1, h - 1, gausian);
            pictureBox1.Image = Pixel.toBmp(data2, w, h);
        }
        private void customfilter3x3_Load(object sender, EventArgs e)
        {
            data2 = data.Clone() as Pixel[,];
            pictureBox1.Image = Pixel.toBmp(data2, w, h);
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            coef = (double)numericUpDown10.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
