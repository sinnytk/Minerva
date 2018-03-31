using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    //Tarun Kumar
    //Started working on 3/8/2018
    //Last edit 3/26/2018
    class vigEncode
    {

        string plaintext; //normal text to cipher
        char[] ciphertext; //encrypted text
        private string key; //key to interchange letters inside the string

        private vigEncode() { }//private non-parameterized constructor to avoid a class being made without any string and/or key.
        private void encrypt()//private function to only do a process called when a parameterized constructor is acquired.
        {  
                string alphabet = "abcdefghijklmnopqrstuvwxyz";
                int len = ciphertext.Length;
                int klen = key.Length;
                int i = 0, j = 0;

                for (; i < len; ++i)
                {
                    var isAlpha = char.IsLetter(ciphertext[i]);
                    if (isAlpha)
                    {
                        j = j % klen;//to ensure that the key string doesn't go out of range, i.e tarun + cpp will be t+c,a+p,r+p and again u+c,n+p, this assignment ensures proper traversing
                        ciphertext[i] = char.ToLower(ciphertext[i]);//converting each letter in lowercase, for proper handling.
                        ciphertext[i] = alphabet[((ciphertext[i] - 'a') + (key[j] - 'a')) % 26];// retrieving remainder by division with 'z' so that the addition doesn't exceed letter 'z' and the alphabet stays within a to z.
                                                                                                // this way a = 1 and z = 26.
                        ++j;//only increase key string element if any character in the cipher is changed.

                    }
                    else
                    {
                        continue;
                    }
                }
        }
        public vigEncode(string ptext, string ktext)//constructor which only works if the parameters are received, I plan to do the encryption of the string within the constructor
        {
            plaintext = ptext;
            key = ktext;
            ciphertext = plaintext.ToCharArray();
            encrypt();
            System.Diagnostics.Debug.WriteLine(ciphertext);
        }
        ~vigEncode() { }
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







    class vigDecode
    {//class to make an object which will have a deciphered or decrypted message

        static string ciphertext;//ciphered text to be input
        char[] plaintext;//output, decrypted text
        private string key;
        private vigDecode() { }//private non-parameterized constructor to avoid a class being made without any string and/or key.
        private void decrypt()//private function to only do a process called when a parameterized constructor is acquired.
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int len = ciphertext.Length;
            int klen = key.Length;
            int i = 0, j = 0;

            for (; i < len; ++i)
            {
                var isAlpha = char.IsLetter(ciphertext[i]);
                if (isAlpha)
                {
                    j = j % klen;//to ensure that the key string doesn't go out of range, i.e tarun + cpp will be t+c,a+p,r+p and again u+c,n+p, this assignment ensures proper traversing
                    plaintext[i] = char.ToLower(plaintext[i]);//converting each letter in lowercase, for proper handling.
                    plaintext[i] = alphabet[((((ciphertext[i] - 'a') - (key[j] - 'a')) + 26) % 26)];// retrieving remainder by division with 26 so that the addition doesn't exceed letter 'z' and the alphabet stays within a to z.
                                                                                                 // this way a = 1 and z = 26.
                    ++j;//only increase key string element if any character in the cipher is changed.

                }
                else
                {
                    continue;
                }
            }
        }
	    public vigDecode(string ctext, string ktext)
        {
            ciphertext = ctext;
            key = ktext;
            plaintext = ciphertext.ToCharArray();
            decrypt();

        }
        ~vigDecode() { }
        public string get_Plaintext()//returns the plaintext
        {
            string returning = new string(plaintext);
            return returning;
        }
        public string get_Ciphertext()//returns the ciphered text
        {
            return ciphertext;
        }
    };
}
