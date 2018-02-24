using System;

namespace ProDemo.InterFaceMessage
{
    [Serializable]
    public class RequestMerRegist
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerName { get; set; }
        /// <summary>
        /// 机构商户号
        /// </summary>
        public string ComMerNum { get; set; }
        /// <summary>
        /// 商户简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 商户属性
        /// </summary>
        public string RegType { get; set; }
        /// <summary>
        /// 注册号
        /// </summary>
        public string RegNum { get; set; }
        /// <summary>
        /// 注册资金
        /// </summary>
        public string RegMoney { get; set; }
        /// <summary>
        /// 门店名称
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 经营范围
        /// </summary>
        public string BusiScope { get; set; }
        /// <summary>
        /// 营业用地面积
        /// </summary>
        public string LandArea { get; set; }
        /// <summary>
        /// 营业开始时间
        /// </summary>
        public string OpenTime { get; set; }
        /// <summary>
        /// 营业结束时间
        /// </summary>
        public string CloseTime { get; set; }
        /// <summary>
        /// 营业地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 热线电话
        /// </summary>
        public string SerNum { get; set; }
        /// <summary>
        /// 法人姓名
        /// </summary>
        public string DutyName { get; set; }
        /// <summary>
        /// 法人证件类型
        /// </summary>
        public string DutyCertType { get; set; }
        /// <summary>
        /// 证件编号
        /// </summary>
        public string DutyCertNum { get; set; }
        /// <summary>
        /// 营业执照有效期开始时间
        /// </summary>
        public string RegBeginDate { get; set; }
        /// <summary>
        /// 营业执照有效期结束时间
        /// </summary>
        public string RegEndDate { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactPhone { get; set; }
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }
    }
    [Serializable]
    public class ResponseMerRegist
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
    }
}
