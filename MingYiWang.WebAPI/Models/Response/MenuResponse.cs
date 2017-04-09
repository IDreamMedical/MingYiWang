using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class MenuResponse
    {

        /// <summary>
        /// 菜单连接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 菜单图片
        /// </summary>
        public string TabBarImg { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }


        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsEnable { get; set; }
    }
}