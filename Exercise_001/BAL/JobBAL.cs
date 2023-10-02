using Exercise_001.DAL;
using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.BAL
{
    public class JobBAL
    {
        JobDAL jobdal = new JobDAL();
        public List<JobBEL> ReadJobList()
        {
            List<JobBEL> lstjob = jobdal.ReadJobList();
            return lstjob;
        }
        public void NewJob(JobBEL job)
        {
            jobdal.NewJob(job);
        }
        public void DeleteJob(JobBEL job)
        {
            jobdal.DeleteJob(job);
        }
        public void EditJob(JobBEL job)
        {
            jobdal.EditJob(job);
        }
    }
}
