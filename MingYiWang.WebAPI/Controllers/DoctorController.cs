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
        [ActionName("Doctors")]
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
                throw new Exception("获取医生列表出错了！");
            }
        }

        [HttpGet]
        [ActionName("Doctor")]

        public ResultApi<DoctorQueryResponse> GetDoctorDetail(string doctorId)
        {
            try
            {
                var service = new DoctorService();
                return service.GetDoctor(doctorId);
            }
            catch
            {
                throw new Exception("获取医生详细信息出错了！");
            }
        }
    }
}