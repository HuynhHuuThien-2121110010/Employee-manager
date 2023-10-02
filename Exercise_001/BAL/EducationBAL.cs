using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class EducationBAL
    {
        EducationDAL edcdal = new EducationDAL();
        public List<EducationBEL> ReadEducationList()
        {
            List<EducationBEL> lsteducation = edcdal.ReadEducationList();
            return lsteducation;
        }
        public void NewEducation(EducationBEL education)
        {
            edcdal.NewEducation(education);
        }
        public void DeleteEducation(EducationBEL education)
        {
            edcdal.DeleteEducation(education);
        }
        public void EditEducation(EducationBEL education)
        {
            edcdal.EditEducation(education);
        }
    }
}
