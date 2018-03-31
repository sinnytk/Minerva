using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class file_de : UserControl
    {
        public string plaintext;
        public string ciphertext;
        public string vigkey = "";
        public int caesarkey = 1024;
        public string filepath;
        OpenFileDialog browse = new OpenFileDialog();
        public file_de()
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
               
                ciphertext = File.ReadAllText(filepath);
                inputtext.Text = ciphertext;
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
                    CzarDecode decode = new CzarDecode(ciphertext, caesarkey);
                    outputtext.Text = decode.get_PlainText();
                    File.WriteAllText(filepath, outputtext.Text);
                    
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
                    vigDecode decode = new vigDecode(ciphertext, vigkey);
                    outputtext.Text = decode.get_Plaintext();
                    File.WriteAllText(filepath, outputtext.text);
                }
                    
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            browse = null;
            inputtext.Text = "";
            outputtext.Text = "";
            this.Hide();
        }
    }
}
