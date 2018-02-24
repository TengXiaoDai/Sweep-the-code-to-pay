using System;
using System.IO;

namespace ProDemo.HTTPResquest
{
    public class FileItem
    {
        private string _fileName;
        private FileInfo _fileInfo;

        public string FileName
        {
            get
            {
                return _fileName;
            }

            set
            {
                _fileName = value;
            }
        }

        public FileItem(string filePath)
        {
            if (!File.Exists(filePath) & string.IsNullOrEmpty(filePath))
                throw new Exception("上传文件不存在!");
            else
            {
                _fileInfo = new FileInfo(filePath);
                FileName=_fileInfo.Name;
            }
        }
        public byte[] GetContent()
        {
            byte[] bts = null;
            using (FileStream stm = _fileInfo.OpenRead())
            {
                bts = new byte[stm.Length];
                stm.Read(bts,0,bts.Length);
            }
            return bts;
        }
        public string GetFileSuffix(byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }
            else if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }
            else if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }
            else if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }
    }
}
