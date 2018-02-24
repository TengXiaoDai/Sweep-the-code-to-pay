﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDemo
{
    [Serializable]
    public class ResponsePicker
    {
        public string Action { get; set; }
        public string ComNum { get; set; }
        public string BizContent { get; set; }
        public string ResCode { get; set; }
        public string ResMsg { get; set; }
        public string ReqFlow { get; set; }
        public string RKey { get; set; }
        public string Sign { get; set; }

    }
}
