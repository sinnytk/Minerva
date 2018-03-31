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
    public partial class encode : UserControl
    {
        public string plaintext;
        public string ciphertext;
        public string vigkey="";
        public int caesarkey=1024;
        public encode()
        {
            InitializeComponent();
        }

        private void caesarbtn_Click(object sender, EventArgs e)
        {
            plaintext = inputtext.Text;
            using (var form = new caesarkeydialog())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    caesarkey = form.ReturnValue1;
                }
            }
            if(caesarkey!=1024)
            {
                CzarEncode czarobj = new CzarEncode(plaintext, caesarkey);
                outputtext.Text = czarobj.get_Ciphertext();
            }


        }

        private void vigenerebtn_Click(object sender, EventArgs e)
        {
            plaintext = inputtext.Text;
            using (var form1 = new vigkeydialog())
            {
                var result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    vigkey = form1.ReturnValue2;
                }
            }
            if(vigkey!="")
            {
                vigEncode test = new vigEncode(plaintext, vigkey);
                outputtext.Text = test.get_Ciphertext();
            }
          
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
