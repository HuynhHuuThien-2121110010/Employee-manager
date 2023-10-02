using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class DepartmentBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual List<EmployeeBEL> department { get; set; } = new List<EmployeeBEL>();
    }
}
