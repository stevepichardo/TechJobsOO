using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public abstract class BaseViewModel
    {
        public JobFieldType Column { get; set; }
        public List<JobFieldType> Columns { get; set; }
        public string Title { get; set; } = "";

        protected BaseViewModel()
        {

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }

        }
    }
}
