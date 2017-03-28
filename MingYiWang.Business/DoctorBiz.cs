using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.SqLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    public class DoctorBiz
    {

        public static List<Doctor> GetDoctors()
        {
            var result = new List<Doctor>();
            try
            {
                using (var ctx = new DoctorContext())
                {
                    result = ctx.Doctors.ToList();
                }
            }
            catch (Exception exp)
            {
            }
            return result;

        }


        public static Doctor GetDoctor(string doctorId)
        {
            var result = new Doctor();
            try
            {
                using (var ctx = new DoctorContext())
                {
                    result = ctx.Doctors.FirstOrDefault(o => o.DoctorId == doctorId);
                }
            }
            catch (Exception exp)
            {
            }
            return result;

        }

    }
}
