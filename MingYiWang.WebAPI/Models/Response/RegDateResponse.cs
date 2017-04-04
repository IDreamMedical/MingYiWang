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

        /// <summary>
        /// 0,表示上午可预约，1表示下午可以预约，-1表示今日不能预约
        /// </summary>
        public string  RegValue { get; set; }
    }
}