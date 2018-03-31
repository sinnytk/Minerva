using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PTmethod_de : UserControl
    {
        public PTmethod_de()
        {
            InitializeComponent();
        }

        private void writeoption_Click(object sender, EventArgs e)
        {
            decode1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fileoption_Click(object sender, EventArgs e)
        {
            file_de1.BringToFront();
            file_de1.Visible = true;
        }
    }
}
