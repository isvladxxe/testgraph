using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace testgraph
{
    public partial class colorPicker : Form
    {
        Bitmap imgNoise;
        BitmapData bmpData;
        IntPtr scan;
        public colorPicker()
        {
            InitializeComponent();
        }
        public System.Drawing.Color Color = System.Drawing.Color.White;
        private void colorPicker_Load(object sender, EventArgs e)
        {
            imgNoise = new Bitmap(255, 255, PixelFormat.Format24bppRgb);




            BluChan();

        }
        void BluChan()
        {
            unsafe
            {
                bmpData = imgNoise.LockBits(new Rectangle(0, 0, 255, 255), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                scan = bmpData.Scan0;
                byte* ptr = (byte*)scan.ToPointer();
                byte* ptrHelper = ptr;


                for (int y = 0; y < 255; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
                {
                    for (int x = 0; x < 255; x++)
                    {


                        *(ptr++) = (byte)(numB.Value); //BBBBBBBBBBПрисвоение красного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(255 - y); //GGGGGGGGGПрисвоение зелёного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(x); //RRRRRRRRRRПрисвоение синего компонента цвета и установка указателя на следующий байт
                    }

                    ptrHelper += bmpData.Stride;
                    ptr = ptrHelper;
                }
            }

            imgNoise.UnlockBits(bmpData);
            pictureBox1.Image = imgNoise;
            //   MessageBox.Show(picture.Image.Size.ToString());
        }
        void rChan()
        {
            unsafe
            {
                bmpData = imgNoise.LockBits(new Rectangle(0, 0, 255, 255), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                scan = bmpData.Scan0;
                byte* ptr = (byte*)scan.ToPointer();
                byte* ptrHelper = ptr;

                for (int y = 0; y < 255; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
                {
                    for (int x = 0; x < 255; x++)
                    {

                        //*(ptr++) = color; //Присвоение красного компонента цвета и установка указателя на следующий байт
                        //*(ptr++) = color; //Присвоение зелёного компонента цвета и установка указателя на следующий байт
                        //*(ptr++) = color; //Присвоение синего компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(x); //BBBBBBBBBBПрисвоение красного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(255 - y); //GGGGGGGGGПрисвоение зелёного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(numR.Value); //RRRRRRRRRRПрисвоение синего компонента цвета и установка указателя на следующий байт
                    }

                    ptrHelper += bmpData.Stride;
                    ptr = ptrHelper;
                }
            }

            imgNoise.UnlockBits(bmpData);
            pictureBox1.Image = imgNoise;
            //   MessageBox.Show(picture.Image.Size.ToString());
        }
        void GChan()
        {
            unsafe
            {
                bmpData = imgNoise.LockBits(new Rectangle(0, 0, 255, 255), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                scan = bmpData.Scan0;
                byte* ptr = (byte*)scan.ToPointer();
                byte* ptrHelper = ptr;

                for (int y = 0; y < 255; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
                {
                    for (int x = 0; x < 255; x++)
                    {


                        *(ptr++) = (byte)(x); //BBBBBBBBBBПрисвоение красного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(numG.Value); //GGGGGGGGGПрисвоение зелёного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(255 - y); //RRRRRRRRRRПрисвоение синего компонента цвета и установка указателя на следующий байт
                    }

                    ptrHelper += bmpData.Stride;
                    ptr = ptrHelper;
                }
            }

            imgNoise.UnlockBits(bmpData);
            pictureBox1.Image = imgNoise;

        }
        void curentcolor()
        {
            Color = Color.FromArgb((byte)255, (byte)numR.Value, (byte)numG.Value, (byte)numB.Value);
            pictureBox2.BackColor = Color;
        }
        private void numB_ValueChanged(object sender, System.EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                BluChan();

                trackBar1.Value = (int)numB.Value;
            }
            if (radioButtonR.Checked)
            {
                rChan();

                trackBar1.Value = (int)numR.Value;
            }
            if (radioButtonG.Checked)
            {
                GChan();

                trackBar1.Value = (int)numG.Value;
            }


            curentcolor();

        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                numB.Value = trackBar1.Value;
                curentcolor();
            }
            if (radioButtonR.Checked)
            {
                numR.Value = trackBar1.Value;
                curentcolor();
            }
            if (radioButtonG.Checked)
            {
                numG.Value = trackBar1.Value;
                curentcolor();
            }
        }

        private void radioButtonG_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    pictureBox2.BackColor = imgNoise.GetPixel(e.X, e.Y);
                    numR.Value = pictureBox2.BackColor.R;
                    numG.Value = pictureBox2.BackColor.G;
                    numB.Value = pictureBox2.BackColor.B;
                }
                catch (System.Exception)
                {


                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
