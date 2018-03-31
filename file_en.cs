using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class file_en : UserControl
    {
        public string plaintext;
        public string ciphertext;
        public string vigkey = "";
        public int caesarkey = 1024;
        public string filepath;
        OpenFileDialog browse = new OpenFileDialog();
        public file_en()
        {

            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result = browse.ShowDialog();
            if(result == DialogResult.OK)
            {
                filepath = browse.FileName;
                filename.Text = browse.SafeFileName;
                plaintext = File.ReadAllText(filepath);
                inputtext.Text = plaintext;
            }
        }

        private void caesarbtn_Click(object sender, EventArgs e)
        {
            using (var form = new caesarkeydialog())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    caesarkey = form.ReturnValue1;
                    CzarEncode encode = new CzarEncode(plaintext, caesarkey);
                    outputtext.Text = encode.get_Ciphertext();
                    File.WriteAllText(filepath, encode.get_Ciphertext());
                }
            }

        }

        private void vigenerebtn_Click(object sender, EventArgs e)
        {
            using (var form = new vigkeydialog())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    vigkey = form.ReturnValue2;
                }
            }
            if(vigkey!="")
            {
                vigEncode encode = new vigEncode(plaintext, vigkey);
                outputtext.Text = encode.get_Ciphertext();
                  
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filename.Text = "";
            
            this.Hide();
        }
    }
}
