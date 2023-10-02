using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class TypeEmployeeDAL:DBConnection
    {
        public List<TypeEmployeeBEL> ReadTypeEmployee()
        {
            return typeemployee.ToList();
        }
        public void DeleteArea(TypeEmployeeBEL area)
        { }
        public void NewArea(TypeEmployeeBEL area)
        { }
        public void EditArea(TypeEmployeeBEL area) { }
    }
}
