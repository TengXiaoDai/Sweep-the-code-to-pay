using System;
using System.Collections.Generic;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestBindChannel
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 通道编号
        /// </summary>
        public string ChannelID { get; set; }
        /// <summary>
        /// 商户类别码
        /// </summary>
        public string MCCode { get; set; }
        /// <summary>
        /// 开通省份
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 开通城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 开通区域
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 结算卡类型
        /// </summary>
        public string AccType { get; set; }
        /// <summary>
        /// 开户行所在省
        /// </summary>
        public string BProvince { get; set; }
        /// <summary>
        /// 开户行所在市
        /// </summary>
        public string BCity { get; set; }
        /// <summary>
        /// 开户行编码
        /// </summary>
        public string BankCode { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// 开户分行名称
        /// </summary>
        public string BranchName { get; set; }
        /// <summary>
        /// 开户支行名称
        /// </summary>
        public string SubName { get; set; }
        /// <summary>
        /// 开户行全称
        /// </summary>
        public string BankAllName { get; set; }
        /// <summary>
        /// 开户行联行号
        /// </summary>
        public string BankNumber { get; set; }
        /// <summary>
        /// 开户户名
        /// </summary>
        public string BankUser { get; set; }
        /// <summary>
        /// 开户证件号
        /// </summary>
        public string BankUserCard { get; set; }
        /// <summary>
        /// 预留手机号
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// 结算费率
        /// </summary>
        public IList<RateMansage> Rates { get; set; }
    }
    [Serializable]
    public class ResponseBindChannel
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 通道编号
        /// </summary>
        public string ChannelID { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DevNumber { get; set; }
        /// <summary>
        /// 开通状态
        /// </summary>
        public string Status { get; set; }
    }
}
