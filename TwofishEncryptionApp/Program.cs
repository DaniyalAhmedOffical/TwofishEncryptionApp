using System;

namespace TwofishEncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "jetFdASbM9tonlaSsNrkMw==";
            string keyHex = "A1AF0E74BCB0BECA048443CFD0A36D6B";

            // Encrypt
           // string encryptedText = TwofishEncryption.Encrypt64(plainText, keyHex);
           // Console.WriteLine($"Encrypted: {encryptedText}");

            // Decrypt
            string decryptedText = TwofishEncryption.Decrypt64(plainText, keyHex);
            Console.WriteLine($"Decrypted: {decryptedText}");
        }
    }
}
