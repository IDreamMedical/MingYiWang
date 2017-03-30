using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    /// <summary>
    /// 预约时间
    /// </summary>
    public class RegDateResponse
    {

        public string WeekStr { get; set; }

        public DateTime CurDate { get; set; }

        public bool CanReg { get; set; }
    }
}