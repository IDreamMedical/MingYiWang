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
    /// 一键预约
    /// </summary>
    public class KeyRegController : ApiController
    {
        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>

        public ResultApi<List<DoctorQueryResponse>> Reg([FromBody] KeyRegRequest req)
        {

            return new ResultApi<List<DoctorQueryResponse>>();
        }

        [HttpGet]
        [ActionName("api/KeyReg/Date")]
        public ResultApi<List<RegDateResponse>> GetRegDate(string doctorId)
        {
            var results = new ResultApi<List<RegDateResponse>>();
            try
            {
                results.Data = RegDateService.GetRegDate(doctorId);
                results.Sucess = true;
                results.ReturnMsg = "获取预约时间成功！";
            }
            catch (Exception exp)
            {
                results.Sucess = false;
                results.ReturnMsg = string.Format("异常：{0},获取预约时间失败！", exp.Message);
            }
            return results;
        }
    }
}
