using System;
using System.Net;
using System.Text;

namespace ProDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           string mes=DESorRSACrapy.RsaCrapy.SignData("<RSAKeyValue><Modulus>1wgaXNGfq830HZaDqniHjNG5KKCt/hb7nbeG/92gYLVFDcYEhuP5WLLyw0/Xw1Iq365o5CNhgDEJVf4jo4GfrWcT8lhCSfsbiqtoYCVwrYjDyi7PRKEwvBs3hjmWQcT/l1Y6ZzPNrkWu2t4JpwbqgL3v0UVeJNS2jX3OwKtv27IZQymSkUFhpF+Uls5HXH7Rr5CCO/Qyso19UXLgHrlh0zPVcjTlOQ0Po75JPOKkUUkXlLClBv+hA7iUPHizRbsQCrf2Dsp10pu+lZI2rIYi/yULYns9sYlY/fUazid978DwHTjGUiy0nxFRUKs/4r7fuH5eqJd2FpL+x/CDtHN06w==</Modulus><Exponent>AQAB</Exponent><P>9QZT09kziuHF2zNpOJrCe0TgCjEOCJgwRpdLr6Ms/QYOs58w5lNxbv2OkzEkZo74AzHRZ2Ya75ciWy3C8/nZagQCtACXulC5C7C8PSQPRA4SUquT/XA5jXMWJP9Uh35Uw7GdqSQyW0bB5lxmrFrx4k6Be2uGnD/kv+NAJkMt1I8=</P><Q>4KnZJVmWwf38gUpcN9S7nK9CCGklJAONB6z/+BXqJ1z6n89kNV3mu7Er/L6OoFP5xLwcQ+2bFcjPvsTfPjMrmiVD6uwZGEN+/tZgcWKP7xM7ZjOHJZjENWGuNa6s3MgXsOBuOpGbIOoE06r/pmoOpMrHE+JxF8aNcYw4fjZZH+U=</Q><DP>OGQjaM9FQIJjkeZMIh3kApDAazgM/cdg3O43Gg4Y7Ya2XXqWu3ua0KuEY7XcpcnjpICTrBNgwaFr48YtZw8qjW6s3JaCVPv9Coa7W+rvpH8EkogwgBSS+k3xW8RzxNc7VOqM2X+eI0mumIDNlH89yhK9VBVUHqPJ1qvLeMLfSls=</DP><DQ>mqDsfwOJet3IVGiMzjSSKIaLyWQtFvuGrtjImMTkk9EwApxomT6XF2obH2s8mWcTCvB599rrGfRL4D56dMIdaYvqkh+MKiISn22HlaLD9EXlZTNj+mGJ8j/X+sTN32usuqXN2GvtPJs1VUZljPGEQLH8kVgShM24/oUHQP9BGm0=</DQ><InverseQ>YZo5IRe4AxvThWGUIOtd1BAtFsr0gnSRUU/2TWhyxhIaKOsWy6Ujc8e0UHsad8jxpO++gj57W1ptPGZRZ0366ovjGKFlVEi8+WZfprQsOTxCfQv7b/v+PuCpCrKy97l/p2az05J6oovtp+gShgNlpmanflVSsw8kaRgTGFmwuuU=</InverseQ><D>uJH29ubjc/eS6vavy1orl17I3KuWzTty/Dx0vxi/uWK+hAUNC6+Q7majY6wb2kakEF1HIVORNBRjHBHJC2aO5atNfr3tIE1OpaddLvHUFtAGpnupYxIsn7mI3kh9xbRPYtobxUu85zJe1PSzOlAAZ0MhHvK4zUpb63UqS0yb9ekFB5yUFHaIN/9vEGX6/XGa+tvfK+tfy6MkT9jzWqF4tNd3w56awEYwJHLu0ebl7bk54D0JUbADzP7nJovdQZW4+uhrTxTMfxfbjHGrzES+bR+Obr/GAhfWa0KyFqY9bo/af2qmlGxTJrAVzUlBcj9ZGEd61SG91FQjjiVOUeiAmQ==</D></RSAKeyValue>", "张腾");
           bool judge=DESorRSACrapy.RsaCrapy.CheckSign("<RSAKeyValue><Modulus>1wgaXNGfq830HZaDqniHjNG5KKCt/hb7nbeG/92gYLVFDcYEhuP5WLLyw0/Xw1Iq365o5CNhgDEJVf4jo4GfrWcT8lhCSfsbiqtoYCVwrYjDyi7PRKEwvBs3hjmWQcT/l1Y6ZzPNrkWu2t4JpwbqgL3v0UVeJNS2jX3OwKtv27IZQymSkUFhpF+Uls5HXH7Rr5CCO/Qyso19UXLgHrlh0zPVcjTlOQ0Po75JPOKkUUkXlLClBv+hA7iUPHizRbsQCrf2Dsp10pu+lZI2rIYi/yULYns9sYlY/fUazid978DwHTjGUiy0nxFRUKs/4r7fuH5eqJd2FpL+x/CDtHN06w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", "张腾", mes);
            Console.WriteLine(judge.ToString());


            Console.ReadKey();
        }
        /// <summary>
        /// 获取当前ip
        /// </summary>
        /// <returns></returns>
        public static string GetClientIP()
        {
            string name = Dns.GetHostName();
            IPAddress ipadrlist = Dns.GetHostAddresses(name)[2];
            return ipadrlist.ToString();
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            TimeSpan cha = (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)));
            long t = (long)cha.TotalSeconds;
            return t.ToString();
        }
    }
}

