using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise_001.Model
{
    public class EmployeeBEL
    {
        [Key, Column(TypeName = "varchar"), MaxLength(50)]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool? Gender { get; set; }
        public bool? Married { get; set; }
        public byte[] Image { get; set; }
        public string Phone { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthdayPlace { get; set; }
        public string CIDNumber { get; set; }
        public DateTime CIDDate { get; set; }
        public string CIDPlaceOfIssue { get; set;}
        public string Hometown { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string TypeEmployeeId { get; set; }
        public virtual TypeEmployeeBEL TypeEmployee { get; set; }
        public DateTime InDate { get; set; }
        public string DepartmentId { get; set; }
        public virtual DepartmentBEL Department { get; set; }
        public string JobId { get; set; }
        public virtual JobBEL Job { get; set; }
        public string PositionId { get; set; }
        public virtual PositionBEL Position { get; set; }
        public string Basicsalary { get; set; }
        public string Coefficient { get; set; }
        public string Wage { get; set; }
        public string Allowance { get; set; }
        public string NumberBook { get; set; }
        public DateTime CIDate { get; set; }
        public string PlaceOfIssue { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string EducationId { get; set; }
        public virtual EducationBEL Education { get; set; }
        public string DegreeId { get; set; }
        public virtual DegreeBEL Degree { get; set; }
        public string LanguageId { get; set; }
        public virtual LanguageBEL Language { get; set; }
        public string InformaticsId { get; set; }
        public virtual InformaticsBEL Informatics { get; set; }
        public string NationId { get; set; }
        public virtual NationBEL Nation { get; set; }
        public string NationalityId { get; set; }
        public virtual NationalityBEL Nationality { get; set; }
        public string ReligionId { get; set; }
        public virtual ReligionBEL Religion { get; set; }

    }
}
