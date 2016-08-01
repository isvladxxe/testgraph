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
    public partial class newfile : Form
    {
        colorPicker cp = new colorPicker();
        public Color color;

        public newfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cp.ShowDialog() == DialogResult.OK)
            {
                color = cp.Color;
                pictureBox1.BackColor = cp.Color;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void newfile_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = color = Color.White;
        }
    }
}
