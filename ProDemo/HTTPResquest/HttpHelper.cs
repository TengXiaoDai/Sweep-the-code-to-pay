using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ProDemo.HTTPResquest
{
    public class HttpHelper
    {
        public static ResponsePicker HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.GetEncoding("GBK").GetByteCount(postDataStr);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("GBK"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return PickerParse(retString);
        }
        private static ResponsePicker PickerParse(string ParseStr)
        {
            ResponsePicker picker = new ResponsePicker();
            string[] v = ParseStr.Split('&');
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (string item in v)
            {
                string[] it = item.Split('=');
                for (int i = 0; i < it.Length; i++)
                {
                    dic[it[0]] = it[1];
                }
            }
            foreach (string item in dic.Keys)
            {
                if (item.ToLower() == "action") { picker.Action = dic[item]; }
                else if (item.ToLower() == "comnum") { picker.ComNum = dic[item]; }
                else if (item.ToLower() == "bizcontent") { picker.BizContent = dic[item]; }
                else if (item.ToLower() == "rescode") { picker.ResCode = dic[item]; }
                else if (item.ToLower() == "resmsg") { picker.ResMsg = dic[item]; }
                else if (item.ToLower() == "reqflow") { picker.ReqFlow = dic[item]; }
                else if (item.ToLower() == "rkey") { picker.RKey = dic[item]; }
                else if (item.ToLower() == "sign") { picker.Sign = dic[item]; }
            }
            return picker;
        }
        public static ResponsePicker UploadFilePost(string Url,IDictionary<string,string> txtParms,IDictionary<string,FileItem>FileParms)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            string boundary = DateTime.Now.Ticks.ToString("X");
            request.ContentType = "multipart/form-data;charset=GBK;boundary=" + boundary;
            Stream stm = request.GetRequestStream();
            string requestData = null;
            byte[] itemBoundaryBytes = Encoding.GetEncoding("GBK").GetBytes("\r\n"+boundary+"\r\n");
            byte[] endBoundaryBytes = Encoding.GetEncoding("GBK").GetBytes("\r\n--"+boundary+"--r\n");
            string txtTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
            IEnumerator<KeyValuePair<string, string>> textEnum = txtParms.GetEnumerator();
            while (textEnum.MoveNext())
            {
                requestData = string.Format(txtTemplate, textEnum.Current.Key, textEnum.Current.Value);
                byte[] itemBytes = Encoding.GetEncoding("GBK").GetBytes(requestData);
                stm.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                stm.Write(itemBytes, 0, itemBytes.Length);
            }
            string fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
            IEnumerator<KeyValuePair<string, FileItem>> fileEnum = FileParms.GetEnumerator();
            while (fileEnum.MoveNext())
            {
                string key = fileEnum.Current.Key;
                FileItem fileItem = fileEnum.Current.Value;
                string fileEntry = string.Format(fileTemplate, key, fileItem.FileName,fileItem.GetFileSuffix(fileItem.GetContent()));
                byte[] itemBytes = Encoding.GetEncoding("GBK").GetBytes(fileEntry);
                stm.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                stm.Write(itemBytes, 0, itemBytes.Length);

                byte[] fileBytes = fileItem.GetContent();
                stm.Write(fileBytes, 0, fileBytes.Length);
            }
            stm.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            stm.Close();
            HttpWebResponse rsp = (HttpWebResponse)request.GetResponse();
            Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            Stream myResponseStream = rsp.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return PickerParse(retString);
        }
    }
}
