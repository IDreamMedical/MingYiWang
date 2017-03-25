using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class HospitalDoctor
    {
        [Column(Order = 1)]
        [Key]
        public string HospitalId { get; set; }

        [Column(Order = 2)]
        [Key]
        public string DoctorId { get; set; }

        public string IsDel { get; set; }
    }
}
