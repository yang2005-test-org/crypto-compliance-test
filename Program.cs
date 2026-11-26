using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        using var aes = Aes.Create();
        aes.KeySize = 256;
    }
}
