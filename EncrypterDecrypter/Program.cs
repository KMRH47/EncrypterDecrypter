using System;

namespace EncrypterDecrypter
{
    class Program
    {
        static void Main()
        {
            string textEncrypted = Encrypter.Encrypt("Tester Bedster");
            Console.WriteLine($"Text encrypted: {textEncrypted}");

            string textDecrypted = Encrypter.Decrypt(textEncrypted);
            Console.WriteLine($"Text decrypted: {textDecrypted}");
        }
    }
}