using System;

namespace EncrypterDecrypter
{
    class Program
    {
        static void Main()
        {
            bool debug = true;

            string newText = Encrypter.Encrypt("He");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            if (debug)
                Console.ReadLine();
        }
    }
}