using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class NationBAL
    {
        NationDAL ntodal = new NationDAL();
        public List<NationBEL> ReadNationList()
        {
            List<NationBEL> lstNation = ntodal.ReadNationList();
            return lstNation;
        }
        public void NewNation(NationBEL Nation)
        {
            ntodal.NewNation(Nation);
        }
        public void DeleteNation(NationBEL Nation)
        {
            ntodal.DeleteNation(Nation);
        }
        public void EditNation(NationBEL Nation)
        {
            ntodal.EditNation(Nation);
        }
    }
}
