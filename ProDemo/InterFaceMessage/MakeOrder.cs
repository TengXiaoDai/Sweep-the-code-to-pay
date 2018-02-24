using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo
{
    [Serializable]
    public class MakeOrder
    {
        /// <summary>
        /// 系统商户号
        /// </summary>
        public string MerNum { get; set; }
        /// <summary>
        /// 系统设备号
        /// </summary>
        public string DevNum { get; set; }
        /// <summary>
        /// 机构订单号
        /// </summary>
        public string OutOrderID { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProductID { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// 终端IP
        /// </summary>
        public string ClientIP { get; set; }
        /// <summary>
        /// 支付渠道
        /// </summary>
        public string ChannelType { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayType { get; set; }
        /// <summary>
        /// 应用ID
        /// </summary>
        public string APPID { get; set; }
        /// <summary>
        /// 付款人标识
        /// </summary>
        public string PayUserID { get; set; }
        /// <summary>
        /// 支付授权码
        /// </summary>
        public string AuthCode { get; set; }
        /// <summary>
        /// 支付完成地址
        /// </summary>
        public string ComplateUrl { get; set; }
        /// <summary>
        /// 应用类型
        /// </summary>
        public string WPAppType { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string WPAppName { get; set; }
        /// <summary>
        /// 应用ID
        /// </summary>
        public string WPAppID { get; set; }
    }
}
