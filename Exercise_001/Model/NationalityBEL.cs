using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class NationalityBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string NationalityId { get; set; }
        public string NationalityName { get; set; }
        public virtual List<EmployeeBEL> Nationality { get; set; } = new List<EmployeeBEL>();
    }
}
