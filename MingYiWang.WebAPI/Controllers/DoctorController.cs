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
    public class DoctorController : ApiController
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> Register([FromBody]DoctorRegisterRequest req)
        {
            return new ResultApi<string>();
        }

        [HttpGet]
        [ActionName("api/Doctor/Doctors")]
        /// <summary>
        /// 医生列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<List<DoctorQueryResponse>> List([FromBody] DoctorQueryRequest req)
        {
            try
            {
                var service = new DoctorService();
                return service.GetDoctors();
            }
            catch
            {
                throw new Exception("获取医生出错了！");
            }
        }
    }
}