using Exercise_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_001.DAL
{
    public class JobDAL:DBConnection
    {
        public List<JobBEL> ReadJobList()
        {
            return job.ToList();
        }
        public void DeleteJob(JobBEL job)
        { }
        public void NewJob(JobBEL job)
        { }
        public void EditJob(JobBEL job) { }
    }
}
