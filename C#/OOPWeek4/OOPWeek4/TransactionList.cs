using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWeek4
{
    internal class TransactionList
    {
        //data
        private Transaction[] transactions; //array: DatType[] arrayName, transactions is an array object
        
        //operation
        public void Init(int size) { transactions = new Transaction[size]; }
    }
}
