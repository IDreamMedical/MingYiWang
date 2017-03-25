﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    /// <summary>
    /// 医院
    /// </summary>
    public class Hospital
    {
        [Key]
        public string HospitalId { get; set; }

        public string HospitalName { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }


    }
}
