using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DwLib.Data
{
    public class DWSHA256
    {
        public class EncryptionHelper
        {
            public static string EncryptionSHA256(string message)
            {
                //입력받은 문자열을 바이트배열로 변환
                byte[] array = Encoding.Default.GetBytes(message);
                byte[] hashValue;
                string result = string.Empty;

                //바이트배열을 암호화된 32byte 해쉬값으로 생성
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    hashValue = mySHA256.ComputeHash(array);
                }
                //32byte 해쉬값을 16진수로변환하여 64자리로 만듬
                for (int i = 0; i < hashValue.Length; i++)
                {
                    result += hashValue[i].ToString("x2");
                }
                return result;
            }

            public static string SHA256_Salt(string text, string salt = "salt")
            {
                HashAlgorithm algorithm = new SHA256Managed();

                byte[] textBytes = Encoding.UTF8.GetBytes(text);
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

                //Combine salt and input text
                List<byte> listByte = new List<byte>();
                listByte.AddRange(textBytes);
                listByte.AddRange(saltBytes);

                byte[] hashedBytes = algorithm.ComputeHash(listByte.ToArray());
                StringBuilder strBuilder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    strBuilder.AppendFormat("{0:x2}", b);
                }

                return strBuilder.ToString();
            }

        }
    }
}
