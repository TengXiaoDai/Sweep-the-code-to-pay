using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestChangeCard
    {
        public string MerNum { get; set; }
        public string DevNumber { get; set; }
        public string AccType { get; set; }
        public string BProvince { get; set; }
        public string BCity { get; set; }
        public string BankCode { get; set; }
        public string CardNumber { get; set; }
        public string BranchName { get; set; }
        public string SubName { get; set; }
        public string BankAllName { get; set; }
        public string BankNumber { get; set; }
        public string BankUser { get; set; }
        public string BankUserCard { get; set; }
        public string MobileNumber { get; set; }
    }

    [Serializable]
    public class ResponseChangeCard
    {
        public string MerNum { get; set; }
        public string DevNumber { get; set; }
        public string Status { get; set; }
        public string POID { get; set; }
    }
}
