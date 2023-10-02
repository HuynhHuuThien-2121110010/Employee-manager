using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class DegreeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string DegreeId { get; set; }
        public string DegreeName { get; set; }
        public virtual List<EmployeeBEL> Degree { get; set; } = new List<EmployeeBEL>();
    }
}
