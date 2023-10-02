using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL dal = new EmployeeDAL();
        public List<EmployeeBEL> ReadEmployee()
        {
            List<EmployeeBEL> lstEmp = dal.ReadEmployee();
            return lstEmp;
        }
        public void NewEmployee(EmployeeBEL emp)
        {
            dal.NewEmployee(emp);
        }
        public void DeleteEmployee(EmployeeBEL emp)
        {
            dal.DeleteEmployee(emp);
        }
        public void EditEmployee(EmployeeBEL emp)
        {
            dal.EditEmployee(emp);
        }
    }
}
