using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Practice_DES
{
    class Program
    {
        static void Main(string[] args)
        {
            DES des = DES.Create();
            //des.Key;
        }
    }

    public static byte[] Ecrypt(byte[] Data, Byte[] Key, Byte[] IV)
    {

        DES des = DES.Create();

        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(Key, IV);


        return Data;
    }

    public static byte[] Decrypt(byte[] Data, Byte[] Key, Byte[] IV)
    {
        DES des = DES.Create();

        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(Key, IV));

        return Data;

    }

    public static void DisplayOptions()
    {
        Console.WriteLine("1. For Encrypting");
        Console.WriteLine("2. For Decrypting");
        Console.WriteLine("3. For System exit");

    }
}
