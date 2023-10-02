using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class InformaticsDAL:DBConnection
    {
        public List<InformaticsBEL> ReadInformaticsList()
        {
            return Informatics.ToList();
        }
        public void DeleteInformatics(InformaticsBEL Informatics)
        { }
        public void NewInformatics(InformaticsBEL Informatics)
        { }
        public void EditInformatics(InformaticsBEL Informatics) { }
    }
}
