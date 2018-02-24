using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestChangeQuery
    {
        public string MerNum { get; set; }
        public string POID { get; set; }
    }
    [Serializable]
    public class ResponseChangeQuery
    {
        public string MerNum { get; set; }
        public string POID { get; set; }
        public string ChangeType { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
