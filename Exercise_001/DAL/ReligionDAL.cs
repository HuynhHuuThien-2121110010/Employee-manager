using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class ReligionDAL:DBConnection
    {
        public List<ReligionBEL> ReadReligionList()
        {
            return Religion.ToList();
        }
        public void DeleteReligion(ReligionBEL Religion)
        { }
        public void NewReligion(ReligionBEL Religion)
        { }
        public void EditReligion(ReligionBEL Religion) { }
    }
}
