using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.DESorRSACrapy
{
    public static class DesCrapy
    {
        /// <summary>
        /// Des数据加密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="data">加密数据</param>
        /// <returns></returns>
        public static string DesEncrapy(string key, string data)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(data);
                des.Key = Encoding.GetEncoding("GBK").GetBytes(key);
                des.IV = Encoding.GetEncoding("GBK").GetBytes(key);
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Des数据解密
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="data">Des加密后的数据</param>
        /// <returns></returns>
        public static string DesDecrapy(string key, string data)
        {
            var des = new DESCryptoServiceProvider
            {
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7,
                Key = Encoding.ASCII.GetBytes(key),
                IV = Encoding.ASCII.GetBytes(key)
            };
            string dummyData = data.Trim().Replace("%", "").Replace(",", "").Replace(" ", "+");
            if (dummyData.Length % 4 > 0)
            {
                dummyData = dummyData.PadRight(dummyData.Length + 4 - dummyData.Length % 4, '=');
            }
            byte[] kData = Convert.FromBase64String(dummyData);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(kData, 0, kData.Length);
                cs.FlushFinalBlock();
                byte[] datas = ms.ToArray();
                ms.Close();
                return Encoding.GetEncoding("GBK").GetString(ms.ToArray());
            }
        }
    }
}
