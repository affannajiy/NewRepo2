using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionPackage //declare the collection where a class belongs to avoid conflict
{

    public class Transaction
    {
        public float Val { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; } 
    }
}