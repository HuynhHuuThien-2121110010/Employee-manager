using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class LanguageBAL
    {
        LanguageDAL lagdal = new LanguageDAL();
        public List<LanguageBEL> ReadLanguageList()
        {
            List<LanguageBEL> lstLanguage = lagdal.ReadLanguageList();
            return lstLanguage;
        }
        public void NewLanguage(LanguageBEL Language)
        {
            lagdal.NewLanguage(Language);
        }
        public void DeleteLanguage(LanguageBEL Language)
        {
            lagdal.DeleteLanguage(Language);
        }
        public void EditLanguage(LanguageBEL Language)
        {
            lagdal.EditLanguage(Language);
        }
    }
}
