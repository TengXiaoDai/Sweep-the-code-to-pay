using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo
{
   public class Request
    {
        private RequestPicker _picker;
        public Request(RequestPicker picker)
        {
            this._picker = picker;
        }
        public string GetRequestString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Action=").Append(_picker.Action).Append("&");
            sb.Append("APIVer=").Append(_picker.APIVer).Append("&");
            sb.Append("ComNum=").Append(_picker.ComNum).Append("&");
            sb.Append("BizContent=").Append(_picker.BizContent).Append("&");
            sb.Append("ReqFlow=").Append(_picker.ReqFlow).Append("&");
            sb.Append("RKey=").Append(_picker.RKey).Append("&");
            sb.Append("Sign=").Append(_picker.Sign);
            return sb.ToString().Replace("+","%2b");
        }
    }
}
