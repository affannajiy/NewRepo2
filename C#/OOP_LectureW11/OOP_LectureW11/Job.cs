using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LectureW11
{
    public class Job
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Report
        public void Report()
        {
            Console.WriteLine("Job: " + Name + "Done!");
            Console.WriteLine("Description: " + Description);
        }
    }
}
