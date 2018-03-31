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
    public partial class PTmethod_en : UserControl
    {
        public PTmethod_en()
        {
            InitializeComponent();
            process1.Visible = false;
            file_en1.Visible = false;
        }

        private void fileoption_Click(object sender, EventArgs e)
        {
            file_en1.BringToFront();
            file_en1.Visible = true;
        }

        private void writeoption_Click(object sender, EventArgs e)
        {
            process1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
