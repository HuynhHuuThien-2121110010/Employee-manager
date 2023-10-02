using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class PositionBAL
    {
        PositionDAL posdal = new PositionDAL();
        public List<PositionBEL> ReadPositionList()
        {
            List<PositionBEL> lstposition = posdal.ReadPositionList();
            return lstposition;
        }
        public void NewPosition(PositionBEL position)
        {
            posdal.NewPosition(position);
        }
        public void DeletePosition(PositionBEL position)
        {
            posdal.DeletePosition(position);
        }
        public void EditPosition(PositionBEL position)
        {
            posdal.EditPosition(position);
        }
    }
}
