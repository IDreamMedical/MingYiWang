using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class KeyRegRequest
    {
        /// <summary>
        /// 直接预约
        /// </summary>
        public KeyReg DirectReg { get; set; }

        /// <summary>
        /// 病人Id
        /// </summary>
        public string PatientId { get; set; }

    }

    public class PatientorderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string DoctorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime WorkDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RegValue { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public string Reged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }

    }
}