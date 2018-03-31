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
    public partial class vigkeydialog : Form
    {
        public string ReturnValue2 { get; set; }
        public vigkeydialog()
        {
            InitializeComponent();
        }

        public void keyreturn_Click(object sender, EventArgs e)
        {
            this.ReturnValue2 = maskedTextBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
