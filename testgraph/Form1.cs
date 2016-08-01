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
using System.Drawing.Imaging;

namespace testgraph
{
    public partial class Form1 : Form
    {
        customfilter3x3 cf = new customfilter3x3();
       sr ssr = new sr();
        gaus ga = new gaus();
        newfile nf =new newfile();
        yarkost cSs = new yarkost();
        ColorSwap cS = new ColorSwap();
        colorPicker cp = new colorPicker();
        specsave specSaveForm = new specsave();
        int width = 500;
        int height = 500;
        Pixel[,] data;
        int randmax = 1;
      //  Bitmap imgNoise;
        BitmapData bmpData;
        IntPtr scan;
        int radius = 10;
        Random rand = new Random();
        byte color = 0;
        System.Drawing.Color curentColor= System.Drawing.Color.White;
        System.Drawing.Color nextColor;
        public Form1()
        {
            InitializeComponent();
          
        }

        void advenceBrushGo(MouseEventArgs me, int rad)
        {
            Pixel tc = new Pixel(color1.BackColor.B, color1.BackColor.G, color1.BackColor.R);


            //for (int i = 0; i < rad*2; i++)
            //{
            Action<int> _ForAction = (i) =>
            {
                for (int j = 0; j < rad * 2; j++)
                {
                    if ((me.X - rad >= 0) && (me.X + rad < width))
                    {
                        if ((me.Y - rad >= 0) && (me.Y + rad < height))
                        {
                            data[me.X - rad + i, me.Y - rad + j] = tc;
                        }
                    }

                }
            };
            Parallel.For(0, rad * 2, _ForAction);


            picture.Image = Pixel.toBmp(data, width, height);


        }
        void advGausian(MouseEventArgs me, int rad)
        {
            


          
            Action<int> _ForAction = (i) =>
            {
                int[,] datB = new int[3, 3];
                int[,] datG = new int[3, 3];
                int[,] datR = new int[3, 3];
                for (int j = 0; j < rad * 2; j++)
                {
                    if ((me.X - rad >= 0) && (me.X + rad < width))
                    {
                        if ((me.Y - rad >= 0) && (me.Y + rad < height))
                        {
                            for (int ax = -1; ax < 2; ax++)
                            {
                                for (int bx = -1; bx < 2; bx++)
                                {
                                    datB[1 + ax, 1 + bx] = data[me.X + ax, me.Y + bx].Blue;
                                    datG[1 + ax, 1 + bx] = data[me.X + ax, me.Y + bx].Green;
                                    datR[1 + ax, 1 + bx] = data[me.X + ax, me.Y + bx].Red;
                                }
                            }
                            data[me.X, me.Y].Blue = (byte)(gauss.gauuusss(datB));
                            data[me.X, me.Y].Green = (byte)(gauss.gauuusss(datG));
                            data[me.X, me.Y].Red = (byte)(gauss.gauuusss(datR));
                          //  data[me.X - rad + i, me.Y - rad + j] = tc;
                        }
                    }

                }
            };
            Parallel.For(0, rad * 2, _ForAction);


            picture.Image = Pixel.toBmp(data, width, height);


        }
        //void brushGo(MouseEventArgs me, int rad)
        //{
            
        //        try
        //        {
                    
               
        //           for (int i = 0; i < rad; i++)
        //            {
        //                for (int j = 0; j < rad; j++)
        //                {
                            
        //                    imgNoise.SetPixel(me.X - rad + i + 1, me.Y - rad + j + 1, color1.BackColor);
        //                }
        //            }
        //            for (int i = 0; i < rad; i++)
        //            {
        //                for (int j = 0; j < rad; j++)
        //                {
        //                    imgNoise.SetPixel(me.X + rad - i - 1, me.Y + rad - j - 1, color1.BackColor);
        //                }
        //            }
        //            for (int i = 0; i < rad; i++)
        //            {
        //                for (int j = 0; j < rad; j++)
        //                {
        //                    imgNoise.SetPixel(me.X + rad - i - 1, me.Y - rad + j + 1, color1.BackColor);
        //                }
        //            }
        //            for (int i = 0; i < rad; i++)
        //            {
        //                for (int j = 0; j < rad; j++)
        //                {
        //                    imgNoise.SetPixel(me.X - rad + i + 1, me.Y + rad - j - 1, color1.BackColor);
        //                }
        //            }

        //            imgNoise.SetPixel(me.X, me.Y, color1.BackColor);

        //        }
        //        catch (Exception)
        //        {
                    

        //        }
        //        picture.Image = imgNoise;
        //        data = Pixel.toMas(imgNoise);
        //    }
        
  
        //void func()
        //{
        //    unsafe
        //    {
        //        imgNoise = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        //        bmpData = imgNoise.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
        //        scan = bmpData.Scan0;
        //        byte* ptr = (byte*)scan.ToPointer();
        //        byte* ptrHelper = ptr;

        //        for (int y = 0; y < height; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
        //        {
        //            for (int x = 0; x < width; x++)
        //            {
        //                color = (byte)rand.Next(0, randmax);
                        
        //                *(ptr++) = (byte)color; //Присвоение красного компонента цвета и установка указателя на следующий байт
        //                *(ptr++) = (byte)rand.Next(0, randmax); //Присвоение зелёного компонента цвета и установка указателя на следующий байт
        //                *(ptr++) = (byte)color; //Присвоение синего компонента цвета и установка указателя на следующий байт
        //            }

        //            ptrHelper += bmpData.Stride;
        //            ptr = ptrHelper;
        //        }
        //    }

        //    imgNoise.UnlockBits(bmpData);
        //    picture.Image = imgNoise;
        //   // MessageBox.Show(picture.Image.Size.ToString());
        //}
        void func2()
        {
            unsafe
            {
             Bitmap   imgNoise = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                bmpData = imgNoise.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                scan = bmpData.Scan0;
                byte* ptr = (byte*)scan.ToPointer();
                byte* ptrHelper = ptr;

                for (int y = 0; y < height; y++) //Порядок перебора критичен, т. к. изображение хранится в памяти построчно
                {
                    for (int x = 0; x < width; x++)
                    {
                        color = (byte)x;
                        
                        *(ptr++) = (byte)(0/2); //BBBBBBBBBBПрисвоение красного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(255-y); //GGGGGGGGGПрисвоение зелёного компонента цвета и установка указателя на следующий байт
                        *(ptr++) = (byte)(x); //RRRRRRRRRRПрисвоение синего компонента цвета и установка указателя на следующий байт
                    }

                    ptrHelper += bmpData.Stride;
                    ptr = ptrHelper;
                }
           

            imgNoise.UnlockBits(bmpData);
           
            data = Pixel.toMas(imgNoise);
            picture.Image = Pixel.toBmp(data,width,height);
     }    }
        private void Form1_Load(object sender, EventArgs e)
        {
           // string[] arguments = Environment.GetCommandLineArgs();
           // if (arguments.Length > 1)
           // {
           //     string filePath = arguments[1];

           //   data=  specSaveForm.openIgz(filePath);
           //picture.Width=   width = specSaveForm.w;
           // picture.Height= height = specSaveForm.h;
           // picture.Image = Pixel.toBmp(data, width, height);
           // return;
           // }
            width = picture.Width;
            height = picture.Height;
        
         data = new Pixel[width, height];
         Action<int> dothomse = (y) =>
         {
             for (int x = 0; x < width; x++)
             {
                data[x, y] = new Pixel(255,255,255);
             }
         };
         Parallel.For(0, height, dothomse);
        
         picture.Image = Pixel.toBmp(data,width,height);

            
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          //  func();
            func2();
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            //menuStrip1.Items.Find("x", false).First().Text = "X=" + e.X;
            //menuStrip1.Items.Find("y", false).First().Text = "Y=" + e.Y;
            //if (e.Button==MouseButtons.Left)
            //{
            //    if (checkBox1.Checked)
            //    {
            //        advGausian(e, radius);
            //    }
            //    else
            //         advenceBrushGo(e,radius);
               
               
            //}
            
        }

        unsafe private void новеЗображенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nf.ShowDialog()==DialogResult.OK)
            {
                panel1.Width = width = picture.Width = (int)nf.numericUpDown1.Value;
                panel1.Height = height = picture.Height = (int)nf.numericUpDown2.Value;
                data = new Pixel[width,height];
             
                for (int y = 0; y <(int)nf.numericUpDown2.Value; y++) 
                {
                    for (int x = 0; x < (int)nf.numericUpDown1.Value; x++)
                    {
                        data[x,y].Blue = (byte)(nf.color.B); //BBBBBBBBBBПрисвоение красного компонента цвета и установка указателя на следующий байт
                        data[x, y].Green = (byte)(nf.color.G); //GGGGGGGGGПрисвоение зелёного компонента цвета и установка указателя на следующий байт
                        data[x, y].Red = (byte)(nf.color.R); //RRRRRRRRRRПрисвоение синего компонента цвета и установка указателя на следующий байт
                    }
                }
                picture.Image =Pixel.toBmp(data,width,height);
               
            }
            
        }

        

      

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            menuStrip1.Items.Find("x", false).First().Text = "X=" + e.X;
            menuStrip1.Items.Find("y", false).First().Text = "Y=" + e.Y;
        }

    

        private void color1_Click(object sender, EventArgs e)
        {
            if (cp.ShowDialog()==DialogResult.OK)
            {
                color1.BackColor = cp.Color;
            } 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            radius = trackBar1.Value;
            menuStrip1.Items.Find("r", false).First().Text = "R=" + trackBar1.Value;
        }

        private void збереженняФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Pixel.toBmp(data, width, height).Save(saveFileDialog1.FileName,Pixel.getFormat(
                   Path.GetExtension( saveFileDialog1.FileName)));
                
            }
        }

       unsafe private void поФормуліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                 byte temp = (byte)((150*data[x,y].Blue + 29*data[x,y].Green + 77*data[x,y].Red) / 256);
                    data[x, y] = new Pixel(temp, temp, temp);
                }
            };
            Parallel.For(0, height, dothomse);
        
            picture.Image = Pixel.toBmp(data,width,height);
        }

        private void середнєЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action<int> dothomse = (y) =>
            {
                for (int x = 0; x < width; x++)
                {
                    byte temp = (byte)((data[x, y].Red + data[x, y].Green + data[x, y].Blue) / 3);
                    data[x, y] = new Pixel(temp,temp,temp);
                }
            };
            Parallel.For(0, height, dothomse);
       
            picture.Image = Pixel.toBmp(data,width,height);     
        }



     private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
     {
         if (openFileDialog1.ShowDialog()==DialogResult.OK)
         {
             if (Path.GetExtension(openFileDialog1.FileName)==".igz")
             {
                 MemoryStream ms = gZipC.getMemStream(openFileDialog1.FileName);
                 picture.Width = width = gZipC.getW(ms);
                 picture.Height = height = gZipC.getH(ms);   
              data= Pixel.byteArrToP(ms);
          
            picture.Image = Pixel.toBmp(data, width, height);
            return;
             }
           Bitmap   imgNoise = new Bitmap(openFileDialog1.FileName);
              picture.Image = imgNoise;
              //panel1.Width = = picture.Width 
                  width = imgNoise.Width;
             // panel1.Height == picture.Height
                  height  = imgNoise.Height;
              data = Pixel.toMas(imgNoise);
         }
        
     }

      void linG()
     {
             Pixel[,] mas =data;
             Action<int> dothomse = (y) =>
             {
                 for (int x = 0; x < width; x++)
                 {
                     if ((x > 1) && (x < width - 1))
                     {
                         mas[x, y].Blue = (byte)((mas[x - 1, y].Blue + mas[x, y].Blue + mas[x + 1, y].Blue) / 3);
                         mas[x, y].Green = (byte)((mas[x - 1, y].Green + mas[x, y].Green + mas[x + 1, y].Green) / 3);
                         mas[x, y].Red = (byte)((mas[x - 1, y].Red + mas[x, y].Red + mas[x + 1, y].Red) / 3);
                     }
                 }
             };
             Parallel.For(0, height, dothomse);
           
             picture.Image =  Pixel.toBmp(mas,width,height);
     }
    unsafe private void лінійнеToolStripMenuItem_Click(object sender, EventArgs e)
     {
         linG();
     }

    private void негативToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Action<int> dothomse = (y) =>
        {
            for (int x = 0; x < width; x++)
            {
                data[x, y].Blue = (byte)(256 - data[x, y].Blue);
                data[x, y].Green = (byte)(256 - data[x, y].Green);
                data[x, y].Red = (byte)(256 - data[x, y].Red);
            }
        };
        Parallel.For(0, height, dothomse);
      
        picture.Image =  Pixel.toBmp(data,width,height);
    }

  private void гаусToolStripMenuItem_Click(object sender, EventArgs e)
   {
     //  for (int y = 1; y < height-1; y++)
     Action<int> gausian=(y)=>
       {
           for (int x = 1; x < width-1; x++)
           {
               int[,] datB= new int[3,3];
               int[,] datG = new int[3, 3];
               int[,] datR = new int[3, 3];
               for (int ax = -1; ax < 2; ax++)
               {
                   for (int bx = -1; bx < 2; bx++)
                   {
                        datB[1 + ax, 1 + bx] = data[x + ax, y + bx].Blue;
                       datG[1 + ax, 1 + bx] = data[x + ax, y + bx].Green;
                       datR[1 + ax, 1 + bx] = data[x + ax, y + bx].Red;
                   }
               }
                data[x,y].Blue = (byte)(gauss.gauuusss(datB));
                data[x, y].Green = (byte)(gauss.gauuusss(datG));
                data[x, y].Red = (byte)(gauss.gauuusss(datR));
           }
       };
     Parallel.For(1,height-1,gausian);
       picture.Image = Pixel.toBmp(data,width,height); 
   }

 private void timer1_Tick(object sender, EventArgs e)
  {
     
          menuStrip1.Items.Find("mem", false).First().Text = "MEM="+((GC.GetTotalMemory(false)/1024)/1024).ToString()+" mb";
      
    
 }

 private void сепіяToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Action<int> dothomse = (y) =>
     {
         for (int x = 0; x < width; x++)
         {
             data[x, y] = Pixel.sepia(data[x, y]);
         }
     };
     Parallel.For(0, height, dothomse);
     
     
        picture.Image =  Pixel.toBmp(data,width,height);
    
 }

 private void свапнутиКольориToolStripMenuItem_Click(object sender, EventArgs e)
 {
     cS.orig = data;
     cS.width = width;
     cS.height = height;
     if (cS.ShowDialog()==DialogResult.OK)
     {
         data = cS.data;
         picture.Image = Pixel.toBmp(data,width,height);
     }
 }

 private void яскравістьToolStripMenuItem_Click(object sender, EventArgs e)
 {
     cSs.orig = data;
     cSs.width = width;
     cSs.height = height;
     if (cSs.ShowDialog() == DialogResult.OK)
     {
         data = cSs.data;
         picture.Image = Pixel.toBmp(data, width, height);
     }
 }

 private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
 {
     
 }
        
 private void порівнянняToolStripMenuItem_Click(object sender, EventArgs e)
 {
     ssr.ShowDialog();
 }

 private void rGBtoYCbCrToolStripMenuItem_Click(object sender, EventArgs e)
 {
     data = Pixel.RGBtoYCbCr(data,width,height);
     picture.Image = Pixel.toBmp(data,width,height);
 }

 private void yCbCrtoRGBToolStripMenuItem_Click(object sender, EventArgs e)
 {
     data = Pixel.YCbCrtoRGB(data,width,height);
     picture.Image = Pixel.toBmp(data,width,height);
 }

 private void автоЯскравістьToolStripMenuItem_Click(object sender, EventArgs e)
 {
     data = Pixel.renderBrightness(data,width,height);
     picture.Image = Pixel.toBmp(data, width, height);
 }

 private void влівоToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Pixel[,] result = new Pixel[height, width];
     Action<int> dothomse = (y) =>
     {
         for (int x = 0; x < width; x++)
         {
             result[y,x] = data[width- x-1,y];
         }
     };
     Parallel.For(0, height, dothomse);
     data = result;
     int temp = width;
     width = height;
     height = temp;
     picture.Image = Pixel.toBmp(data,width,height);
 }

 private void вправоToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Pixel[,] result = new Pixel[height, width];
     Action<int> dothomse = (y) =>
     {
         for (int x = 0; x < width; x++)
         {
             result[y, x] = data[ x,height- y-1];
         }
     };
     Parallel.For(0, height, dothomse);
     data = result;
     int temp = width;
     width = height;
     height = temp;
     picture.Image = Pixel.toBmp(data, width, height);
 }

 private void toolStripMenuItem2_Click(object sender, EventArgs e)
 {
     влівоToolStripMenuItem_Click(sender, e);
     влівоToolStripMenuItem_Click(sender, e);
 }

 private void відзеркалитиГорToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Pixel[,] result = new Pixel[width, height];
     Action<int> dothomse = (y) =>
     {
         for (int x = 0; x < width; x++)
         {
             result[width-x-1, y] = data[x,y];
         }
     };
     Parallel.For(0, height, dothomse);
     data = result;
     picture.Image = Pixel.toBmp(data, width, height);
 }

 private void відзеркалитиВертToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Pixel[,] result = new Pixel[width, height];
     Action<int> dothomse = (y) =>
     {
         for (int x = 0; x < width; x++)
         {
             result[x , height- y- 1] = data[x, y];
         }
     };
     Parallel.For(0, height, dothomse);
     data = result;
     picture.Image = Pixel.toBmp(data, width, height);
 }

 private void gausV2ToolStripMenuItem_Click(object sender, EventArgs e)
 {
     Action<int> gausian = (y) =>
     {
         for (int x = 1; x < width - 1; x++)
         {
             Pixel[,] dat = new Pixel[3, 3];
            
             for (int ax = -1; ax < 2; ax++)
             {
                 for (int bx = -1; bx < 2; bx++)
                 {
                     dat[1 + ax, 1 + bx] = data[x + ax, y + bx];
                     
                 }
             }
             data[x, y]=gauss.gauss2(dat);
          
         }
     };
     Parallel.For(1, height - 1, gausian);
     picture.Image = Pixel.toBmp(data, width, height); 
 }

 private void заказнийФільтрToolStripMenuItem_Click(object sender, EventArgs e)
 {
     cf.data = data.Clone() as Pixel[,];
     cf.w = width;
     cf.h = height;
     if (cf.ShowDialog()==DialogResult.OK)
     {
         data = cf.data2;
         picture.Image = Pixel.toBmp(data,width,height);
     }
 }

 private void memToolStripMenuItem_Click(object sender, EventArgs e)
 {
     GC.Collect();
 }

 private void збереженняВСпецФорматToolStripMenuItem_Click(object sender, EventArgs e)
 {
     specSaveForm.data = data.Clone() as Pixel[,];
     specSaveForm.w = width;
     specSaveForm.h = height;
     specSaveForm.ShowDialog();
 }

 private void відтінкиСірогоToolStripMenuItem_Click(object sender, EventArgs e)
 {

 }
    }
}
