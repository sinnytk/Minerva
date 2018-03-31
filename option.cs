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
    public partial class homecontrol : UserControl
    {
        public homecontrol()
        {
            InitializeComponent();
            UserControl home = new UserControl();
            home.BringToFront();
            
        }

        private void encodebtn_Click(object sender, EventArgs e)
        {
            pTmethod1.Visible = true;
        }

        private void decodebtn_Click(object sender, EventArgs e)
        {
            pTmethod_de1.Visible = true;
        }

    }
}
