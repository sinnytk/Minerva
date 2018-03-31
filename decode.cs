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
    public partial class decode : UserControl
    {
        public string plaintext;
        public string ciphertext;
        public string vigkey;
        public int caesarkey;
        public decode()
        {
            InitializeComponent();
        }

        private void vigenerebtn_Click(object sender, EventArgs e)
        {
            ciphertext = inputtext.Text;
            using (var form1 = new vigkeydialog())
            {
                var result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    vigkey = form1.ReturnValue2;
                }
            }
            vigDecode decode = new vigDecode(ciphertext, vigkey);
            outputtext.Text = decode.get_Plaintext();
        }

        private void caesarbtn_Click(object sender, EventArgs e)
        {
            ciphertext = inputtext.Text;
            using (var form1 = new caesarkeydialog())
            {
                var result = form1.ShowDialog();
                if(result==DialogResult.OK)
                {
                    caesarkey = form1.ReturnValue1;
                }
            }
            CzarDecode decode = new CzarDecode(ciphertext, caesarkey);
            outputtext.Text = decode.get_PlainText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
