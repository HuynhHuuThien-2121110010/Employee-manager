using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class ReligionBAL
    {
        ReligionDAL religiondal = new ReligionDAL();
        public List<ReligionBEL> ReadReligionList()
        {
            List<ReligionBEL> lstReligion = religiondal.ReadReligionList();
            return lstReligion;
        }
        public void NewReligion(ReligionBEL Religion)
        {
            religiondal.NewReligion(Religion);
        }
        public void DeleteReligion(ReligionBEL Religion)
        {
            religiondal.DeleteReligion(Religion);
        }
        public void EditReligion(ReligionBEL Religion)
        {
            religiondal.EditReligion(Religion);
        }
    }
}
