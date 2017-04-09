using MingYiWang.Common.Model;
using MingYiWang.WebAPI.Models;
using MingYiWang.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MingYiWang.WebAPI.Controllers
{
    /// <summary>
    /// 主页显示
    /// </summary>
    public class DashboardController : ApiController
    {


        /// <summary>
        ///  根据用户类型 和用户级别获取首页菜单 
        ///  userType： 0（医生），（1）病人， 
        ///  userLevel：特级会员，高级会员，中级会员，普通会员， 非会员
        /// </summary>
        /// <returns></returns>
        public ResultApi<List<MenuResponse>> GetMenus(string userType, string userLevel)
        {
            var result = new ResultApi<List<MenuResponse>>() { Sucess = true };
            try
            {
                result.Data = MenuService.GetMenus();
            }
            catch (Exception exp)
            {
                result.Sucess = false;
                result.ReturnMsg = "获取菜单失败！";
            }
            return result;
        }
    }
}
