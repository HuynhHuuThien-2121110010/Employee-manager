using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class EducationDAL:DBConnection
    {
        public List<EducationBEL> ReadEducationList()
        {
            return Education.ToList();
        }
        public void DeleteEducation(EducationBEL education)
        { }
        public void NewEducation(EducationBEL education)
        { }
        public void EditEducation(EducationBEL education) { }
    }
}
