using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.DESorRSACrapy
{
    public static class RsaCrapy
    {
        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="publicKey">公密</param>
        /// <param name="data">加密的数据</param>
        /// <returns></returns>
        public static string RsaEncrapy(string publicKey, string data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            return Convert.ToBase64String(rsa.Encrypt(Encoding.GetEncoding("GBK").GetBytes(data), false));
        }
        /// <summary>
        /// Rsa解密
        /// </summary>
        /// <param name="PrviteKey">私密</param>
        /// <param name="data">要解密的数据</param>
        /// <returns></returns>
        public static string RsaDecrapy(string PrviteKey, string data)
        {
            try
            {
                byte[] PlainTextBArray;
                byte[] DypherTextBArray;
                string Result;
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(PrviteKey);
                string dummyData = data.Trim().Replace("%", "").Replace(",", "").Replace(" ", "+");
                if (dummyData.Length % 4 > 0)
                {
                    dummyData = dummyData.PadRight(dummyData.Length + 4 - dummyData.Length % 4, '=');
                }
                PlainTextBArray = Convert.FromBase64String(dummyData);
                DypherTextBArray = rsa.Decrypt(PlainTextBArray, false);
                Result = Encoding.GetEncoding("GBK").GetString(DypherTextBArray);
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 签名生成
        /// </summary>
        /// <param name="prviteKey">私密</param>
        /// <param name="data">签名数据</param>
        /// <returns></returns>
        public static string SignData(string prviteKey, string data)
        {
            byte[] bts = Encoding.GetEncoding("GBK").GetBytes(data);
            RSACryptoServiceProvider Rsa = new RSACryptoServiceProvider();
            Rsa.FromXmlString(prviteKey);
            SHA256 shal = SHA256.Create();
            return Convert.ToBase64String(Rsa.SignData(bts, shal));
        }
        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="publicKey">公密</param>
        /// <param name="data">验证的数据</param>
        /// <param name="SignData">签名后的数据</param>
        /// <returns></returns>
        public static bool CheckSign(string publicKey, string data, string SignData)
        {
            byte[] dataBytes = Encoding.GetEncoding("GBK").GetBytes(data);
            byte[] SignBytes = Convert.FromBase64String(SignData);
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);
            SHA256 shal = SHA256.Create();
            return rsa.VerifyData(dataBytes, shal, SignBytes);
        }
    }
}
