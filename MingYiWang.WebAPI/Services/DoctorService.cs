using MingYiWang.Business;
using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.SqLite;
using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class DoctorService
    {


        public ResultApi<List<DoctorQueryResponse>> GetDoctors()
        {
            var result = new ResultApi<List<DoctorQueryResponse>>
            {
                Data = new List<DoctorQueryResponse>()

            };

            var hospitalService = new HospitalService();
            var lst = new List<DoctorQueryResponse>();
            var doctors = DoctorBiz.GetDoctors();
            if (doctors == null)
            {

                result.ReturnMsg = "获取医生列表失败";
                result.Sucess = false;
                return result;
            }
            foreach (var doctor in doctors)
            {
                var hospital = hospitalService.GetHospital(doctor.DoctorId);
                if (hospital == null)
                {
                    continue;
                }
                result.Data.Add(new DoctorQueryResponse
                {

                    Avatar = doctor.Avatar,
                    DoctorCertNO = doctor.CertNo,
                    DoctorName = doctor.DoctorName,
                    SkillDesc = doctor.SkillDesc.Length > 30 ? doctor.SkillDesc.Substring(0, 30) : doctor.SkillDesc.Substring(0, doctor.SkillDesc.Length),
                    HospitalName = hospital.HospitalName,
                    DeptName = doctor.DeptName,
                    Title = doctor.Title
                });
            }
            result.Sucess = true;
            result.ReturnMsg = "获取医生列表成功";
            return result;
        }
    }
}