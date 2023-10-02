using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class InformaticsBAL
    {
        InformaticsDAL informaticsdal = new InformaticsDAL();
        public List<InformaticsBEL> ReadInformaticsList()
        {
            List<InformaticsBEL> lstInformatics = informaticsdal.ReadInformaticsList();
            return lstInformatics;
        }
        public void NewInformatics(InformaticsBEL Informatics)
        {
            informaticsdal.NewInformatics(Informatics);
        }
        public void DeleteInformatics(InformaticsBEL Informatics)
        {
            informaticsdal.DeleteInformatics(Informatics);
        }
        public void EditInformatics(InformaticsBEL Informatics)
        {
            informaticsdal.EditInformatics(Informatics);
        }
    }
}
