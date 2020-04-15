using System;
using System.Collections.Generic;
using System.Text;

namespace EncrypterDecrypter
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            string textEncrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                int letterInt = text[i] + 1;
                char letter = (char)letterInt;
                textEncrypted += letter.ToString();
            }

            return textEncrypted;
        }

        public static string Decrypt(string text)
        {
            string textDecrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                char letter = (char)(text[i] - 1);
                textDecrypted += letter.ToString();
            }

            return textDecrypted;
        }
    }
}