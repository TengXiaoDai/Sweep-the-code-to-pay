using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class  RequestMerQuery
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 机构商户号
        /// </summary>
        public string ComMerNum { get; set; }
    }
    [Serializable]
    public class ResponseMerQuery
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 机构商户号
        /// </summary>
        public string ComMerNum { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 驳回原因
        /// </summary>
        public string Reason { get; set; }

    }
}
