using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class NationDAL:DBConnection
    {
        public List<NationBEL> ReadNationList()
        {
            return Nation.ToList();
        }
        public void DeleteNation(NationBEL Nation)
        { }
        public void NewNation(NationBEL Nation)
        { }
        public void EditNation(NationBEL Nation) { }
    }
}
