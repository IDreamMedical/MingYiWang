using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class DoctorQueryResponse
    {
        public string DoctorId { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 医生职业证书
        /// </summary>
        public string DoctorCertNO { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        public string HospitalName { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        public string Title { get; set; }



        /// <summary>
        /// 预约次数
        /// </summary>
        public int OrderCount { get; set; }

        /// <summary>
        /// 医生擅长描述
        /// </summary>
        public string SkillDesc { get; set; }


        /// <summary>
        /// 直接预约
        /// </summary>
        public KeyReg DirectReg { get; private set; }


        public DoctorQueryResponse()
        {
            DirectReg = new KeyReg();
        }

    }




}

