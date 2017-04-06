using MingYiWang.Business;
using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MingYiWang.WebAPI.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> PostUser(UserRequest req)
        {
            if (null == req)
            {
                throw new Exception("参数不能为空");
            }

            var user = new User();
            user.eMail = req.eMail;
            user.Tel = req.Tel;
            user.UserName = req.UserName;
            user.Password = req.Password;
            var userInfo = new SaveUserInfo(user);
            return userInfo.SaveInfo();
        }

        [HttpPost]
        public ResultApi<string> Login(LoginRequest req)
        {
            var result = new ResultApi<string>();
            if (null == req)
            {
                throw new Exception("参数不能为空");
            }
            var userSearchBiz = new UserSearchBiz();
            var user = userSearchBiz.GetUser(req.EMail, req.Pwd);
            if (user != null)
            {
                result.Data = "../doctor/doctorIndex.html";
            }
            else
            {
                result.Data = "../patient/patientIndex.html";
            }
            return result;
        }

    }
}
