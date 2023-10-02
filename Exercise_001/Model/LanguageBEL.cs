using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.Model
{
    public class LanguageBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(30)]
        public string LanguageId { get; set; }
        public string LanguageName { get; set; }
        public virtual List<EmployeeBEL> Language { get; set; } = new List<EmployeeBEL>();
    }
}
