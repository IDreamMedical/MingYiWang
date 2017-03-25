using MingYiWang.Business;
using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class HospitalService
    {

        public Hospital GetHospital(string doctorId)
        {
            if (string.IsNullOrWhiteSpace(doctorId))
            {
                throw new ArgumentNullException("doctorId不能为空");
            }
            var hospitalDoctors = HospitalBiz.GetHospitalDoctors(doctorId);
            if (hospitalDoctors == null)
            {
                throw new ArgumentNullException("获取医生所在医院列表失败！");
            }
            var first = hospitalDoctors.FirstOrDefault();
            if (first == null)
            {
                throw new ArgumentNullException("该医生没有关联医院");
            }
            var hospital = HospitalBiz.GetHospital(first.HospitalId);
            return hospital;
        }



    }
}