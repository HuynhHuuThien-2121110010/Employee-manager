using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class DepartmentDAL:DBConnection
    {
        public List<DepartmentBEL> ReadDepartmentList()
        {
            return department.ToList();
        }
        public void DeleteDepartment(DepartmentBEL department)
        { }
        public void NewDepartment(DepartmentBEL department)
        { }
        public void EditDepartment(DepartmentBEL department) { }
    }
}
