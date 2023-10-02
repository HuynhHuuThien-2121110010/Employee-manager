using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class PositionDAL:DBConnection
    {
        public List<PositionBEL> ReadPositionList()
        {
            return position.ToList();
        }
        public void DeletePosition(PositionBEL position)
        { }
        public void NewPosition(PositionBEL position)
        { }
        public void EditPosition(PositionBEL position) { }
    }
}
