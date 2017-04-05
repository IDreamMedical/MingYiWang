using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class PatientOrder
    {
        [Key]
        public string PatientOrderId { get; set; }

        public string DoctorId { get; set; }

        public DateTime WorkDate { get; set; }

        public string RegValue { get; set; }

        public string PatientId { get; set; }

        public string Reged { get; set; }

        public string Remark { get; set; }

    }
}
