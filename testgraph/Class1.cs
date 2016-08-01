using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace testgraph
{
    public class matrix
    {
        public static Pixel[,] MxM(Pixel[,] M1, Pixel[,] M2, int width, int height)
        {
            Pixel[,] result = new Pixel[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    result[x, y] = M1[x, y] * M2[x, y];
                }
            }

            return result;
        }
        public static Pixel aMxM(Pixel[,] M1, double[,] M2, int width, int height)
        {

            Pixel fresult = new Pixel();
            double[,] r = new double[width, height];
            double[,] g = new double[width, height];
            double[,] b = new double[width, height];
            double rr = 0, gg = 0, bb = 0;
            double coef = 0;


            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    r[x, y] = (double)(M1[x, y].Red * M2[x, y]);
                    g[x, y] = (double)(M1[x, y].Green * M2[x, y]);
                    b[x, y] = (double)(M1[x, y].Blue * M2[x, y]);
                    coef += M2[x, y];
                }
            }



            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    rr += r[x, y];
                    gg += g[x, y];
                    bb += b[x, y];
                }
            }
            rr = rr / coef;
            gg = gg / coef;
            bb = bb / coef;
            rr = rr > 255 ? 255 : rr;
            gg = gg > 255 ? 255 : gg;
            bb = bb > 255 ? 255 : bb;

            rr = rr <= 0 ? 0 : rr;
            gg = gg <= 0 ? 0 : gg;
            bb = bb <= 0 ? 0 : bb;
            fresult.Red = (byte)rr;
            fresult.Green = (byte)gg;
            fresult.Blue = (byte)bb;

            return fresult;
        }

        public static Pixel aMxM(Pixel[,] M1, double[,] M2, int width, int height, double coef, int sm)
        {

            Pixel fresult = new Pixel();
            double[,] r = new double[width, height];
            double[,] g = new double[width, height];
            double[,] b = new double[width, height];
            double rr = 0, gg = 0, bb = 0;

            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    r[x, y] = (double)(M1[x, y].Red * M2[x, y]);
                    g[x, y] = (double)(M1[x, y].Green * M2[x, y]);
                    b[x, y] = (double)(M1[x, y].Blue * M2[x, y]);
                }
            };
            Parallel.For(0, height, dothomse);

            //for (int x = 0; x < width; x++)
            //{
            //    for (int y = 0; y < height; y++)
            //    {


            //    }
            //}

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    rr += r[x, y];
                    gg += g[x, y];
                    bb += b[x, y];
                }
            }
            rr = (rr / coef) + sm;
            gg = (gg / coef) + sm;
            bb = (bb / coef) + sm;
            rr = rr > 255 ? 255 : rr;
            gg = gg > 255 ? 255 : gg;
            bb = bb > 255 ? 255 : bb;

            rr = rr <= 0 ? 0 : rr;
            gg = gg <= 0 ? 0 : gg;
            bb = bb <= 0 ? 0 : bb;
            fresult.Red = (byte)rr;
            fresult.Green = (byte)gg;
            fresult.Blue = (byte)bb;

            return fresult;
        }
    }

    public struct Pixel
    {
        public byte Blue;
        public byte Green;
        public byte Red;
        public static Pixel operator *(Pixel in1, Pixel in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red * in2.Red;
            w = in1.Green * in2.Green;
            e = in1.Blue * in2.Blue;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }
        public static Pixel operator +(Pixel in1, Pixel in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red + in2.Red;
            w = in1.Green + in2.Green;
            e = in1.Blue + in2.Blue;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }

        public static Pixel operator *(Pixel in1, int in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red * in2;
            w = in1.Green * in2;
            e = in1.Blue * in2;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }
        public static Pixel operator /(Pixel in1, int in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red / in2;
            w = in1.Green / in2;
            e = in1.Blue / in2;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }
        public static Pixel operator +(Pixel in1, int in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red + in2;
            w = in1.Green + in2;
            e = in1.Blue + in2;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }

        public static Pixel operator *(Pixel in1, double in2)
        {
            Pixel result = new Pixel();
            double q, w, e;
            q = in1.Red * in2;
            w = in1.Green * in2;
            e = in1.Blue * in2;

            q = q > 255 ? 255 : q;
            w = w > 255 ? 255 : w;
            e = e > 255 ? 255 : e;

            q = q <= 0 ? 0 : q;
            w = w <= 0 ? 0 : w;
            e = e <= 0 ? 0 : e;
            result.Red = (byte)q;
            result.Green = (byte)w;
            result.Blue = (byte)e;

            return result;
        }

        public static ImageFormat getFormat(string ind)
        {
            ind = ind.ToLower();
            switch (ind)
            {
                case ".bmp":
                    return ImageFormat.Bmp;
                    break;
                case ".exif":
                    return ImageFormat.Exif;
                    break;
                case ".gif":
                    return ImageFormat.Gif;
                    break;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                    break;
                case ".png":
                    return ImageFormat.Png;
                    break;
                case ".tif":
                case ".tiff":
                    return ImageFormat.Tiff;
                    break;

            }
            return ImageFormat.Bmp;
        }

        static public Pixel black() { return new Pixel(0, 0, 0); }
        static public Pixel white() { return new Pixel(255, 255, 255); }
        static public bool operator ==(Pixel me, Pixel ex)
        {
            if (me.Blue == ex.Blue)
            {
                if (me.Green == ex.Green)
                {
                    if (me.Red == ex.Red)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static public bool operator !=(Pixel me, Pixel ex)
        {
            if (me.Blue == ex.Blue)
            {
                if (me.Green == ex.Green)
                {
                    if (me.Red == ex.Red)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public unsafe static Pixel[,] toMas(Bitmap ind)
        {
            Pixel[,] mas = new Pixel[ind.Width, ind.Height];
            BitmapData bmpData;
            IntPtr scan;
            bmpData = ind.LockBits(new Rectangle(0, 0, ind.Width, ind.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            scan = bmpData.Scan0;
            byte* ptr = (byte*)scan.ToPointer();
            byte* ptrHelper = ptr;
            for (int y = 0; y < ind.Height; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
            {
                for (int x = 0; x < ind.Width; x++)
                {
                    mas[x, y] = new Pixel(*(ptr++), *(ptr++), *(ptr++));


                }

                ptrHelper += bmpData.Stride;
                ptr = ptrHelper;
            }

            ind.UnlockBits(bmpData);
            return mas;

        }
        public unsafe static Bitmap toBmp(Pixel[,] ind, int width, int height)
        {
            Bitmap imgNoise = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            Pixel[,] mas = ind;

            BitmapData bmpData;
            IntPtr scan;
            bmpData = imgNoise.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            scan = bmpData.Scan0;
            byte* ptr = (byte*)scan.ToPointer();
            byte* ptrHelper = ptr;
            for (int y = 0; y < height; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
            {
                for (int x = 0; x < width; x++)
                {

                    *(ptr++) = mas[x, y].Blue;
                    *(ptr++) = mas[x, y].Green;
                    *(ptr++) = mas[x, y].Red;
                }

                ptrHelper += bmpData.Stride;
                ptr = ptrHelper;
            }
            imgNoise.UnlockBits(bmpData);

            return imgNoise;

        }
        public static MemoryStream toByteArry(Pixel[,] ind, int width, int height)
        {
            MemoryStream result = new MemoryStream();
            byte[] tw = BitConverter.GetBytes(width);
            byte[] th = BitConverter.GetBytes(height);
            //MessageBox.Show("ASAFDGBFDKGBHKDGHDFSD "+BitConverter.ToInt32(tw,0).ToString()+""+BitConverter.ToInt32(th,0).ToString());
            result.Write(tw, 0, sizeof(int));
            result.Write(th, 0, sizeof(int));
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    result.WriteByte(ind[x, y].Red);

                    result.WriteByte(ind[x, y].Green);

                    result.WriteByte(ind[x, y].Blue);
                }
            }

            return result;

        }
        public static Pixel[,] byteArrToP(MemoryStream ind)
        {
            ind.Position = 0;
            int w, h;
            byte[] buf = new byte[4];
            ind.Read(buf, 0, sizeof(int));
            //ind.Seek(20,SeekOrigin.Current);
            w = BitConverter.ToInt32(buf, 0);
            ind.Read(buf, 0, sizeof(int));
            // ind.Seek(20,SeekOrigin.Current);
            h = BitConverter.ToInt32(buf, 0);
            Pixel[,] result = new Pixel[w, h];
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    result[x, y].Red = (byte)ind.ReadByte();
                    result[x, y].Green = (byte)ind.ReadByte();
                    result[x, y].Blue = (byte)ind.ReadByte();
                }
            }

            return result;

        }




        public Pixel(byte b, byte g, byte r)
        {
            Blue = b;
            Green = g;
            Red = r;
        }
        public static Pixel sepia(Pixel ind)
        {
            byte Tone = (byte)(0.299 * ind.Red + 0.587 * ind.Green + 0.114 * ind.Blue);
            return new Pixel((byte)((Tone < 56) ? 0 : Tone - 56),
                (byte)((Tone < 14) ? 0 : Tone - 14),
                (byte)((Tone > 206) ? 255 : Tone + 49));
        }
        public static Pixel[,] renderBrightness(Pixel[,] ind, int width, int height)
        {
            Pixel[,] YCbCr = RGBtoYCbCr(ind, width, height);
            double max = 0, min = 255;
            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    if (YCbCr[x, y].Red > max) max = YCbCr[x, y].Red;
                    if (YCbCr[x, y].Red < min) min = YCbCr[x, y].Red;
                }
            };
            Action<int> dothomse2 = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    double tmp = (255.0 * (double)(YCbCr[x, y].Red - min) / (double)(max - min));
                    YCbCr[x, y].Red = (byte)Math.Round(tmp);
                }
            };
            Parallel.For(0, height, dothomse);
            Parallel.For(0, height, dothomse2);
            Pixel[,] result = YCbCrtoRGB(YCbCr, width, height);
            return result;
        }
        public static Pixel[,] RGBtoYCbCr(Pixel[,] ind, int width, int height)
        {
            //  for (int y = 1; y < height-1; y++)
            Pixel[,] result = new Pixel[width, height];
            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    result[x, y].Red = (byte)Math.Round(0.183 * (double)ind[x, y].Red + 0.614 * (double)ind[x, y].Green + 0.062 * (double)ind[x, y].Blue + 16);
                    result[x, y].Green = (byte)Math.Round(-0.101 * (double)ind[x, y].Red - 0.338 * (double)ind[x, y].Green + 0.439 * (double)ind[x, y].Blue + 128);
                    result[x, y].Blue = (byte)Math.Round(0.439 * (double)ind[x, y].Red - 0.399 * (double)ind[x, y].Green - 0.040 * (double)ind[x, y].Blue + 128);
                }
            };
            Parallel.For(0, height, dothomse);

            return result;
        }
        public static Pixel[,] YCbCrtoRGB(Pixel[,] ind, int width, int height)
        {
            //  for (int y = 1; y < height-1; y++)
            Pixel[,] result = new Pixel[width, height];
            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    double cb = ind[x, y].Green;
                    double cr = ind[x, y].Blue;
                    double coef = 1.164 * (ind[x, y].Red - 16);

                    double q = Math.Round(coef + 1.793 * (cr - 128));
                    double w = Math.Round(coef - 0.534 * (cr - 128) - 0.213 * (cb - 128));
                    double e = Math.Round(coef + 2.115 * (cb - 128));
                    q = q > 255 ? 255 : q;
                    w = w > 255 ? 255 : w;
                    e = e > 255 ? 255 : e;

                    q = q <= 0 ? 0 : q;
                    w = w <= 0 ? 0 : w;
                    e = e <= 0 ? 0 : e;
                    result[x, y].Red = (byte)q;
                    result[x, y].Green = (byte)w;
                    result[x, y].Blue = (byte)e;
                }
            };
            Parallel.For(0, height, dothomse);

            return result;
        }

    }


    public class gauss
    {
        public static byte gauuusss(int[,] inm)
        {


            return (byte)((inm[0, 0] * 0.5 + inm[0, 1] * 0.75 + inm[0, 2] * 0.5 + inm[1, 0] * 0.75 + inm[1, 1] + inm[1, 2] * 0.75 + inm[2, 0] + 0.75 + inm[2, 1] * 0.75 + inm[2, 2] + 0.5) / 7);

        }
        public static byte gauuusss(int[,] inm, int w, int h)
        {


            return (byte)((inm[0, 0] * 0.5 + inm[0, 1] * 0.75 + inm[0, 2] * 0.5 + inm[1, 0] * 0.75 + inm[1, 1] + inm[1, 2] * 0.75 + inm[2, 0] + 0.75 + inm[2, 1] * 0.75 + inm[2, 2] + 0.5) / 7);

        }
        public static Pixel gauss2(Pixel[,] ind)
        {
            double[,] table = new double[3, 3];
            table[0, 0] = 1;
            table[0, 1] = 4;
            table[0, 2] = 1;
            table[1, 0] = 4;
            table[1, 1] = 16;
            table[1, 2] = 4;
            table[2, 0] = 1;
            table[2, 1] = 4;
            table[2, 2] = 1;


            return matrix.aMxM(ind, table, 3, 3);
        }

    }

}
