using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Exercise_001.DAL
{
    public class NationalityDAL:DBConnection
    {
        public List<NationalityBEL> ReadNationalityList()
        {
            return Nationality.ToList();
        }
        public void DeleteNationality(NationalityBEL Nationality)
        { }
        public void NewNationality(NationalityBEL Nationality)
        { }
        public void EditNationality(NationalityBEL Nationality) { }
    }
}
