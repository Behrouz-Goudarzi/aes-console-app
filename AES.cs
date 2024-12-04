using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AESConsoleApp;

internal class AES
{
    public static string Encrypt(string plainText, string key, string iv)
    {
        using var aes = new RijndaelManaged
        {
            BlockSize = 128,
            Mode = CipherMode.CBC,
            Padding = PaddingMode.PKCS7,
            Key = Convert.FromBase64String(key),
            IV = Convert.FromBase64String(iv)
        };

        var encryptor = aes.CreateEncryptor();
        var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        var cipherTextBytes = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);

        return Convert.ToBase64String(cipherTextBytes);
    }

    public static string Decrypt(string cipherText, string key, string iv)
    {
        using var aes = new RijndaelManaged
        {
            BlockSize = 128,
            Mode = CipherMode.CBC,
            Padding = PaddingMode.PKCS7,
            Key = Convert.FromBase64String(key),
            IV = Convert.FromBase64String(iv)
        };

        var decryptor = aes.CreateDecryptor();
        var cipherTextBytes = Convert.FromBase64String(cipherText);
        var plainTextBytes = decryptor.TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);

        return Encoding.UTF8.GetString(plainTextBytes);
    }
}
