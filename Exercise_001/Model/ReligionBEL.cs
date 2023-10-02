using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class ReligionBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string ReligionId { get; set; }
        public string ReligionName { get; set; }
        public virtual List<EmployeeBEL> Religion { get; set; } = new List<EmployeeBEL>();
    }
}
