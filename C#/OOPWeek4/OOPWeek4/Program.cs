// See https://aka.ms/new-console-template for more information


using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many transactions todday?");
        string numStr = Console.ReadLine(); 
        int num = Int32.Parse(numStr); //cast from string to int

        for (int i = 0; i < 10; i++) {
            Transaction transaction;
            transaction = new Transaction(); // creating an object (variable of a certain class type)

            transaction.setDate(new DateTime(2008, 6, 1));

            transaction.setVal(10.5f);

            Console.WriteLine("transaction value is " + transaction.setVal + " at time " + transaction.setDate.ToString());
        }
    }
}