using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class DBConnection : DbContext
    {
        public DBConnection() : base("name = DHRDB")
        {

        }
        public DbSet<EmployeeBEL> employees { get; set; }
        public DbSet<TypeEmployeeBEL> typeemployee { get; set; }
        public DbSet<DepartmentBEL> department { get; set; }
        public DbSet<JobBEL> job { get; set; }
        public DbSet<PositionBEL> position { get; set; }
        public DbSet<EducationBEL> Education { get; set; }
        public DbSet<LanguageBEL> Language { get; set; }
        public DbSet<NationBEL> Nation { get; set; }
        public DbSet<NationalityBEL> Nationality { get; set; }
        public DbSet<DegreeBEL> Degree { get; set; }
        public DbSet<InformaticsBEL> Informatics { get; set; }
        public DbSet<ReligionBEL> Religion { get; set; }
    }
}
