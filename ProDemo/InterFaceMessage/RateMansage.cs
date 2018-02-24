using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo.InterFaceMessage
{
    public class RateMansage
    {
        /// <summary>
        /// 卡类型
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        /// 费率类型
        /// </summary>
        public string RateType { get; set; }
        /// <summary>
        /// 比例值
        /// </summary>
        public string Rate { get; set; }
        /// <summary>
        /// 封顶值
        /// </summary>
        public string Cap { get; set; }
    }
}
