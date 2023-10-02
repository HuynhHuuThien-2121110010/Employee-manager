using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class TypeEmployeeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string TypeEmployeeId { get; set; }
        public string TypeEmployeeName { get; set; }
        public virtual List<EmployeeBEL> typeemployee { get; set; } = new List<EmployeeBEL>();
    }
}
