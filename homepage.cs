using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
            homecontrol1.BringToFront();
            btn_Welcome.FlatAppearance.BorderSize = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            home.Visible = true;
            homecontrol1.BringToFront();
            navbar_home.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void nav_home_Click(object sender, EventArgs e)
        {
            homecontrol1.BringToFront();
        }

        private void nav_use_Click(object sender, EventArgs e)
        {

        }


        private void nav_works_Click(object sender, EventArgs e)
        {

        }

        private void encode_Click(object sender, EventArgs e)
        {
            
        }

        private void decode_Click(object sender, EventArgs e)
        {

        }

        private void nav_about_Click(object sender, EventArgs e)
        {
            aboutcontrol1.BringToFront();
        }

    }
}
