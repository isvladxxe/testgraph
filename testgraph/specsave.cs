using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace testgraph
{
    public partial class specsave : Form
    {
        FileStream str;
        MemoryStream tstr = new MemoryStream();
        public int w;
        public int h;
        public Pixel[,] data;
        public specsave()
        {
            InitializeComponent();
        }

        private void specsave_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Pixel.toBmp(data, w, h);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
                str = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                var temp = Pixel.toByteArry(data, w, h);

                GZipStream gz = new GZipStream(str, CompressionMode.Compress, true);
                gz.Write(temp.GetBuffer(), 0, (int)temp.Length);
                gz.Close();
                str.Close();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
