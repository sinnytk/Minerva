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
    
    public partial class caesarkeydialog : Form
    {
        public int ReturnValue1 { get; set; }
        public caesarkeydialog()
        {
            InitializeComponent();
            
        }

        public void keyreturn_Click(object sender, EventArgs e)
        {
            ReturnValue1 = Convert.ToInt32(maskedTextBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void caesarkeydialog_Load(object sender, EventArgs e)
        {

        }
    }
   

}
