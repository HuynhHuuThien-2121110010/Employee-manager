using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class NationalityBAL
    {
        NationalityDAL ntoltdal = new NationalityDAL();
        public List<NationalityBEL> ReadNationalityList()
        {
            List<NationalityBEL> lstNationality = ntoltdal.ReadNationalityList();
            return lstNationality;
        }
        public void NewNationality(NationalityBEL Nationality)
        {
            ntoltdal.NewNationality(Nationality);
        }
        public void DeleteNationality(NationalityBEL Nationality)
        {
            ntoltdal.DeleteNationality(Nationality);
        }
        public void EditNationality(NationalityBEL Nationality)
        {
            ntoltdal.EditNationality(Nationality);
        }
    }
}
