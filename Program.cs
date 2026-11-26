using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        byte[] data = Encoding.UTF8.GetBytes("compliance-test");

        using var md5 = MD5.Create();
        byte[] hash = md5.ComputeHash(data);

        using var rsa = RSA.Create(1024);
        byte[] sig = rsa.SignData(data, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

        using var aes = Aes.Create();
        aes.KeySize = 256;
    }
}
