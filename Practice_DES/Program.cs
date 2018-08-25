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

    public static byte[] Ecrypt(byte[] Data, DES.Key, DES.IV)
    {

        DES des = DES.Create();

        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream(ms, DES.Key, DES.IV);


        return Data;
    }

    public static byte[] Decrypt(byte[] Data, des.Key(), DES.IV)
    {
        MemoryStream ms = new MemoryStream();
        CryptoStream cs = new CryptoStream();

        return Data;

    }

    public static void DisplayOption()
    {
        Console.WriteLine("1. For Encrypting");
        Console.WriteLine("2. For Decrypting");
        Console.WriteLine("3. For System exit");

    }
}
