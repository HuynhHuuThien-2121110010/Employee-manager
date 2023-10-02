using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class EducationBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string EducationId { get; set; }
        public string EducationName { get; set; }
        public virtual List<EmployeeBEL> Education { get; set; } = new List<EmployeeBEL>();
    }
}
