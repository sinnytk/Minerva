using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class CzarEncode
    {
        private string plaintext;
        private char[] ciphertext;
        private int key;

        private CzarEncode() { }
        private void encrypt()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int len = ciphertext.Length;
            int i = 0;

            for (; i < len; ++i)
            {
                var isAlpha = char.IsLetter(ciphertext[i]);
                if (isAlpha)
                {
                    ciphertext[i] = char.ToLower(ciphertext[i]);
                    ciphertext[i] = alphabet[((ciphertext[i] - 'a')+key) % 26];
                }
                else
                {
                    continue;
                }
            }
        }
        public CzarEncode(string pt,int k)
        {
            plaintext = pt;
            key = k;
            ciphertext = plaintext.ToCharArray();
            encrypt();
        }
        ~CzarEncode() { }
        public string get_PlainText()//returns the plaintext
        {
            return plaintext;
        }
        public string get_Ciphertext()//returns the ciphered text
        {
            string returning = new string(ciphertext);
            return returning;
        }
    };
    class CzarDecode
       {
        private string ciphertext;
        private char[] plaintext;
        private int key;

        private CzarDecode() { }
        private void decrypt()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int len = ciphertext.Length;
            int i = 0;

            for (; i < len; ++i)
            {
                var isAlpha = char.IsLetter(ciphertext[i]);
                if (isAlpha)
                {
                    plaintext[i] = char.ToLower(ciphertext[i]);
                    plaintext[i] = alphabet[(((ciphertext[i] - 'a') - key)+26) % 26];
                }
                else
                {
                    continue;
                }
            }
        }
        public CzarDecode(string ct, int k)
        {
            ciphertext = ct;
            key = k;
            plaintext = ciphertext.ToCharArray();
            decrypt();
        }
        ~CzarDecode() { }
        public string get_PlainText()//returns the plaintext
        {
            string returnvalue = new string(plaintext);
            return returnvalue;
        }
        public string get_Ciphertext()//returns the ciphered text
        {
            return ciphertext;
        }
    };
}
