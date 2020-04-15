namespace EncrypterDecrypter
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            string textEncrypted = "";

            for (int i = 0; i < text.Length; i++)
                textEncrypted += (char)(text[i] + 1);

            return textEncrypted;
        }

        public static string Decrypt(string text)
        {
            string textDecrypted = "";

            for (int i = 0; i < text.Length; i++)
                textDecrypted += (char)(text[i] - 1);

            return textDecrypted;
        }
    }
}