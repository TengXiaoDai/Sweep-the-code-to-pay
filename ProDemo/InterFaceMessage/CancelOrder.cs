using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequsetCancelOrder
    {
        public string OrderID { get; set; }
        public string OutCancelOID { get; set; }
        public string Amount { get; set; }
        public string OrderTime { get; set; }
    }
    [Serializable]
    public class ResponseCancelOrder
    {
        public string OrderID { get; set; }
        public string OutCancelOID { get; set; }
        public string CancelOID { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
    }
}
