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
        private int numTransactions;

        //operation
        public void Init(int size) { transactions = new Transaction[size]; }

        public void Add(Transaction transaction) // add an object to an array
        {
            transactions[numTransactions] = transaction;
        }

        public void Display()
        { 
            for (int i = 0; i < numTransactions; i++) //for loop
            {
                Console.WriteLine(transactions[i]);
            }
        }
    }
}