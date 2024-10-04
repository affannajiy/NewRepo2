using System.Diagnostics;

static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}

MyMethod();

static void NextMethod(string fname, int age)
{
    Console.WriteLine(fname + " is " + age);
}

NextMethod("Liam", 5);
NextMethod("Jenny", 8);
NextMethod("Anja", 31);