using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class DepartmentBAL
    {
        DepartmentDAL dpmdal = new DepartmentDAL();
        public List<DepartmentBEL> ReadDepartmentList()
        {
            List<DepartmentBEL> lstDpm = dpmdal.ReadDepartmentList();
            return lstDpm;
        }
        public void NewDepartment(DepartmentBEL department)
        {
            dpmdal.NewDepartment(department);
        }
        public void DeleteDepartment(DepartmentBEL department)
        {
            dpmdal.DeleteDepartment(department);
        }
        public void EditDepartment(DepartmentBEL department)
        {
            dpmdal.EditDepartment(department);
        }
    }
}
