using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestChangeRate
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DevNumber { get; set; }
        /// <summary>
        /// 结算费率
        /// </summary>
        public List<RateMansage> Rates { get; set; }
    }
    [Serializable]
    public class ResponseChangeRate
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DevNumber { get; set; }
        /// <summary>
        /// 变更状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 审核单号
        /// </summary>
        public string POID { get; set; }
    }
    
}
