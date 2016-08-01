using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Drawing;
namespace testgraph
{
    public class gZipC
    {
        public static Point getWHOARR(MemoryStream ind)
        {
            ind.Position = 0;
            int w = -1, h = -5;
            byte[] buf = new byte[4];
            ind.Read(buf, 0, sizeof(int));
            w = BitConverter.ToInt32(buf, 0);
            ind.Read(buf, 0, sizeof(int));
            h = BitConverter.ToInt32(buf, 0);

            //  MessageBox.Show(ind.Length.ToString()+" "+w.ToString() + " " + h.ToString());
            return new Point(w, h);
        }
        public static int getW(MemoryStream ind)
        {
            Point wh = gZipC.getWHOARR(ind);
            return wh.X;

        }
        public static int getH(MemoryStream ind)
        {
            Point wh = gZipC.getWHOARR(ind);
            return wh.Y;

        }
        static public MemoryStream getMemStream(string file)
        {
            byte[] compressed = File.ReadAllBytes(file);
            MemoryStream ms = new MemoryStream();
            GZipStream gz = new GZipStream(new MemoryStream(compressed), CompressionMode.Decompress);
            byte[] buffer = new byte[4096];
            int count;
            do
            {
                count = gz.Read(buffer, 0, 4096);
                if (count > 0)
                {
                    ms.Write(buffer, 0, count);
                }
            }
            while (count > 0);

            gz.Close();
            return ms;
        }

    }
}
