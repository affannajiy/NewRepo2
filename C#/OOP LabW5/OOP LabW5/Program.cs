using System.Diagnostics;

/*
//Functions
static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}

MyMethod();

//Functions with Parameters
static void NextMethod(string fname, int age)
{
    Console.WriteLine(fname + " is " + age);
}

NextMethod("Liam", 5);
NextMethod("Jenny", 8);
NextMethod("Anja", 31);

//Function Overloading
static int PlusMethodInt(int x, int y)
{
    return x + y;
}

static double PlusMethodDouble(double x, double y)
{
    return x + y;
}

int MyNum1 = PlusMethodInt(8, 5);
double MyNum2 = PlusMethodDouble(4.3, 6.26);
*/

//1 -------------------------------------------------------
static void CISD(string name, int ID, string course)
{
    Console.WriteLine(name + " " + ID + " " + course);
}

CISD("John", 22010101, "Computer Science");

//2 -------------------------------------------------------
/*Difference between Encapsulation and Abstract
 * Encapsulation:
 *   Encapsulation is the process of wrapping data and the methods that work on the data within one unit.
 *   This puts restrictions on accessing the data only through the declared methods.
 * Abstract:
 *   Abstract is a process of hiding the implementation details and showing only the functionality to the user.
 *   This is achieved by using abstract keyword.
 *   This makes the class abstract and cannot be instantiated.
 */