using MingYiWang.Business.Model;
using MingYiWang.DataAccess.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business
{
    public class HospitalBiz
    {
        public static Hospital GetHospital(string hospitalId)
        {
            var result = new Hospital();
            try
            {
                using (var ctx = new HospitalContext())
                {
                    result = ctx.Hospitals.FirstOrDefault(o => o.HospitalId == hospitalId);
                }
            }
            catch (Exception exp)
            {
            }
            return result;

        }

        public List<Hospital> GetHospitals()
        {

            var result = new List<Hospital>();
            try
            {
                using (var ctx = new HospitalContext())
                {
                    result = ctx.Hospitals.ToList();
                }
            }
            catch (Exception exp)
            {
            }
            return result;
        }


        /// <summary>
        /// 获取医生医院对照关系
        /// </summary>
        /// <returns></returns>
        public static List<HospitalDoctor> GetHospitalDoctors(string doctorId)
        {
            var results = new List<HospitalDoctor>();
            try
            {
                using (var ctx = new HospitalDoctorContext())
                {
                    results = ctx.HospitalDoctors.Where(o => o.DoctorId == doctorId).ToList();
                }
            }
            catch (Exception exp)
            {
            }
            return results;
        }
    }
}
