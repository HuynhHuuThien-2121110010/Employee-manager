using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class DegreeBAL
    {
        DegreeDAL degreedal = new DegreeDAL();
        public List<DegreeBEL> ReadDegreeList()
        {
            List<DegreeBEL> lstDegree = degreedal.ReadDegreeList();
            return lstDegree;
        }
        public void NewDegree(DegreeBEL Degree)
        {
            degreedal.NewDegree(Degree);
        }
        public void DeleteDegree(DegreeBEL Degree)
        {
            degreedal.DeleteDegree(Degree);
        }
        public void EditDegree(DegreeBEL Degree)
        {
            degreedal.EditDegree(Degree);
        }
    }
}
