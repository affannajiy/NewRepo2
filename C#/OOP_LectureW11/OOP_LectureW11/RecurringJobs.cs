using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    public class RecurringJobs : Job
    {
        public DateTime LastDone { get; set; } //Property: a cover for smth that's private
        public TimeSpan TimeBeforeNext { get; set; }
        //TimeSpan: struct, that represents a time interval
    }
}
