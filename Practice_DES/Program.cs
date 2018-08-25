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
            string message = String.Empty;

            Console.WriteLine("What would you like to encrypt?");
            message = Console.ReadLine();

            // Create a new DES object
            DES des = DES.Create();

            Encrypt(message, des.Key, des.IV);


        }

        #region
        /// <summary>
        /// Method to encrypt by DES
        /// </summary>
        /// <param name="Data">Byte Array of the data</param>
        /// <param name="Key">DES Key</param>
        /// <param name="IV">DES Initialization Vector</param>
        /// <returns></returns>
        public static byte[] Encrypt(string Data, Byte[] Key, Byte[] IV)
        {
            // Create a new DES object
            DES des = DES.Create();

            MemoryStream ms = new MemoryStream();

            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(Key, IV), CryptoStreamMode.Write);

            // Couldn't remember
            byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

            cs.Write(toEncrypt, 0, toEncrypt.Length);
            cs.FlushFinalBlock();

            byte[] encrypted = ms.ToArray();

            ms.Close();
            cs.Close();

            return encrypted;

        }
        #endregion

        #region Decrypt
        /// <summary>
        /// Method to decrypt by DES
        /// </summary>
        /// <param name="Data">Byte Array of the data</param>
        /// <param name="Key">DES Key</param>
        /// <param name="IV">DES Initialization Vector</param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] Data, Byte[] Key, Byte[] IV)
        {
            // Create a DES object
            DES des = DES.Create();

            MemoryStream ms = new MemoryStream();

            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(Key, IV), CryptoStreamMode.Read);

            return Data;

        }
        #endregion

        #region DisplayOptions
        /// <summary>
        /// Display the menu
        /// </summary>
        public static void DisplayOptions()
        {
            Console.WriteLine("1. For Encrypting");
            Console.WriteLine("2. For Decrypting");
            Console.WriteLine("3. For System exit");

        }
        #endregion

        #region DisplayError
        /// <summary>
        /// Display a dark red error message
        /// </summary>
        public static void DisplayError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error! Please try again with the input");

        }
        #endregion
    }
}
