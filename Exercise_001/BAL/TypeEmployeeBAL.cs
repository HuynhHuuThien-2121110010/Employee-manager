using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class TypeEmployeeBAL
    {
        TypeEmployeeDAL typedal = new TypeEmployeeDAL();
        public List<TypeEmployeeBEL> ReadTypeEmployeeList()
        {
            List<TypeEmployeeBEL> lstType = typedal.ReadTypeEmployee();
            return lstType;
        }
        public void NewArea(TypeEmployeeBEL area)
        {
            typedal.NewArea(area);
        }
        public void DeleteArea(TypeEmployeeBEL area)
        {
            typedal.DeleteArea(area);
        }
        public void EditArea(TypeEmployeeBEL area)
        {
            typedal.EditArea(area);
        }
    }
}
