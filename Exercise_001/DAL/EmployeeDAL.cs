using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class EmployeeDAL:DBConnection
    {
        public List<EmployeeBEL> ReadEmployee()
        {
            return employees.ToList();
        }
        public void NewEmployee(EmployeeBEL emp)
        {
            var typeEmployee = this.typeemployee.Where(m => m.TypeEmployeeId == emp.TypeEmployee.TypeEmployeeId).FirstOrDefault();
            emp.TypeEmployee = typeEmployee;
            var department = this.department.Where(m => m.DepartmentId == emp.Department.DepartmentId).FirstOrDefault();
            emp.Department = department;
            var job = this.job.Where(m => m.JobId == emp.Job.JobId).FirstOrDefault();
            emp.Job = job;
            var position = this.position.Where(m => m.PositionId == emp.Position.PositionId).FirstOrDefault();
            emp.Position = position; 
            var education = this.Education.Where(m => m.EducationId == emp.Education.EducationId).FirstOrDefault();
            emp.Education = education;
            var degree = this.Degree.Where(m => m.DegreeId == emp.Degree.DegreeId).FirstOrDefault();
            emp.Degree = degree;
            var language = this.Language.Where(m => m.LanguageId == emp.Language.LanguageId).FirstOrDefault();
            emp.Language = language;
            var informatics = this.Informatics.Where(m => m.InformaticsId == emp.Informatics.InformaticsId).FirstOrDefault();
            emp.Informatics = informatics;
            var nation = this.Nation.Where(m => m.NationId == emp.Nation.NationId).FirstOrDefault();
            emp.Nation = nation;
            var nationality = this.Nationality.Where(m => m.NationalityId == emp.Nationality.NationalityId).FirstOrDefault();
            emp.Nationality = nationality;
            var religion = this.Religion.Where(m => m.ReligionId == emp.Religion.ReligionId).FirstOrDefault();
            emp.Religion = religion;
            this.employees.Add(emp);
            this.SaveChanges();
        }
        public void DeleteEmployee(EmployeeBEL emp)
        {
            var deletecustomer = this.employees.Where(c => c.EmployeeId == emp.EmployeeId).FirstOrDefault();
            this.employees.Remove(deletecustomer);
            this.SaveChanges();
        }
        public void EditEmployee(EmployeeBEL emp)
        {
            var editemployee = this.employees.Where(c => c.EmployeeId == emp.EmployeeId).FirstOrDefault();
            this.Entry(editemployee).CurrentValues.SetValues(emp);
            this.SaveChanges();
        }
    }
}
