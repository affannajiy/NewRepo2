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
            
        }
        // creating an object (variable of a certain class type)
        Transaction transaction = new Transaction();

        transaction.setDate(new DateTime(2008, 6, 1));

        transaction.val = -10.5f;

        Console.WriteLine("transaction value is " + transaction.val + " at time " + transaction.date.ToString());
    }

}