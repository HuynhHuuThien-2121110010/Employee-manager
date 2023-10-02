using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class DegreeDAL:DBConnection
    {
        public List<DegreeBEL> ReadDegreeList()
        {
            return Degree.ToList();
        }
        public void DeleteDegree(DegreeBEL Degree)
        { }
        public void NewDegree(DegreeBEL Degree)
        { }
        public void EditDegree(DegreeBEL Degree) { }
    }
}
