using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class JobBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string JobId { get; set; }
        public string JobName { get; set; }
        public virtual List<EmployeeBEL> job { get; set; } = new List<EmployeeBEL>();
    }
}
