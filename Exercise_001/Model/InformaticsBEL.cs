using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class InformaticsBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string InformaticsId { get; set; }
        public string InformaticsName { get; set; }
        public virtual List<EmployeeBEL> Informatics { get; set; } = new List<EmployeeBEL>();
    }
}
