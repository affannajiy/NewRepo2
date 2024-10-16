using System;
using TransactionPackage;

class Program
{
    static void Main(string[] args) //Static Main
    {
        Transaction transaction = new Transaction();
        transaction.Val = 1;
        transaction.Date = DateTime.Now;
        transaction.Employee = new Employee();

        Console.WriteLine("Maximum number of transactions allowed = " + TransactionList.MAX);

        TransactionList transactionList = new TransactionList(); //Create Object
        transactionList.Add(transaction);

        Business business = new Business();
        business.initFirestore();

        //Async, you can't just call it
        //var is data type if you don't care
        //Task is a trading unit, make sure app not freeze
        //Lambda Expression; (async () => await business.SaveTransaction(transaction))
        //Run(): Run in a separate thread
        var task2 = Task.Run(async () => await business.SaveTransaction(transaction));
        task2.Wait(); //Blocks until task is done
    }
}