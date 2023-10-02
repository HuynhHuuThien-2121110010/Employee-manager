using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class PositionBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(20)]
        public string PositionId { get; set; }
        public string PositionName { get; set; }
        public virtual List<EmployeeBEL> position { get; set; } = new List<EmployeeBEL>();
    }
}
