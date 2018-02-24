using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestCloseOrder
    {
        public string OrderID { get; set; }
        public string OutOrderID { get; set; }
        public string OrderTime { get; set; }
    }
    [Serializable]
    public class ResponseCloseOrder
    {
        public string OrderID { get; set; }
        public string OutOrderID { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
    }
}
