using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    /// <summary>
    /// 登录请求
    /// </summary>
    public class LoginRequest
    {

        /// <summary>
        /// 邮箱
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// 密码
        /// </summary>

        public string Pwd { get; set; }
    }
}