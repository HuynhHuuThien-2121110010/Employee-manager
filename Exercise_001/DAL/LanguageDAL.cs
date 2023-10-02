using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class LanguageDAL:DBConnection
    {
        public List<LanguageBEL> ReadLanguageList()
        {
            return Language.ToList();
        }
        public void DeleteLanguage(LanguageBEL Language)
        { }
        public void NewLanguage(LanguageBEL Language)
        { }
        public void EditLanguage(LanguageBEL Language) { }
    }
}
