using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    public class OneTimeJobs : Job
    {
        //Inheritance from superclass Job
        //We want to show OneTimeJobs as a kind of Job (subclass)
        public DateTime Date { get; set; }

    }
}
