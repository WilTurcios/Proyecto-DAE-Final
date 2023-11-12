using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Transportes_Figueroa.Utils
{
    internal class PasswordEncryptor
    {
        private readonly string encryptionKey;
        private TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        private MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

        public PasswordEncryptor(string encryptionKey)
        {
            this.encryptionKey = encryptionKey;
        }

        private byte[] MD5Hash(string value)
        {
            return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public string EncryptPassword(string textoaCodificar)
        {
            DES.Key = this.MD5Hash(encryptionKey);
            DES.Mode = CipherMode.ECB;
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(textoaCodificar);
            return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }

        public string DecryptPassword(string textoaDescodificar)
        {
            try
            {

                DES.Key = this.MD5Hash(encryptionKey);
                DES.Mode = CipherMode.ECB;
                byte[] buffer = Convert.FromBase64String(textoaDescodificar);
                return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception ex)
            {
                return "Error al desencriptar la clave";
            }
        }
    }
}
