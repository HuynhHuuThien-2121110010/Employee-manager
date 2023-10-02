using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class NationBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string NationId { get; set; }
        public string NationName { get; set; }
        public virtual List<EmployeeBEL> Nation { get; set; } = new List<EmployeeBEL>();
    }
}
