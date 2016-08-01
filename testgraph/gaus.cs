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
    public partial class gaus : Form
    {
        public gaus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(((12 * 0.5 + 14 * 0.75 + 41 * 0.5 + 43 * 0.75 + 84 * 1 + 24 * 0.75 + 2 + 0.75 + 1 * 0.75 + 43 + 0.5) / 6).ToString());
        }
    }
}
