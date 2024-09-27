// See https://aka.ms/new-console-template for more 
/*
int myNum = 220101017;

Console.WriteLine(Convert.ToString(myNum));
*/

/*
double CGPA = 4.01;

Console.WriteLine(Convert.ToDouble(CGPA));
*/

/*
bool value = true;
Console.WriteLine(Convert.ToString(value));
*/

/*
int x = 2;
Console.WriteLine(x &= 3); //2
Console.WriteLine(x |= 3); //3
Console.WriteLine(x ^= 3); //0
Console.WriteLine(x >>= 3); //0
Console.WriteLine(x <<= 3); //0
*/

/*
int x = 5;
Console.WriteLine(x > 3 && x < 10);

Console.WriteLine("Ahoy There, What is your name?");
string username = Console.ReadLine();
Console.WriteLine("\nHello " + username + "!");
Console.WriteLine("Pirate Status: Active");

//
if (username == "Iman Hazim" )
{
    Console.WriteLine("You are Muse!");
    Console.WriteLine("Boom Shakalaka!");
}

string text = "Iman Hazim Ahmed Sulastry";
Console.WriteLine("The Length of String is " + text.Length);
*/

/*
string firstName = "Dior";
string lastName = "Savage";
string name = $"My favourite perfume is: {firstName} {lastName}"; //parking lot method
Console.WriteLine(name);
*/

/*
string txt = "We are the so-called \"Vikings\" from the north.";
Console.WriteLine(txt);
*/

/*
Console.WriteLine("What is your age?");
int input = Convert.ToInt32(Console.ReadLine());
int imanAge = 19;

if (input >= imanAge)
{
    Console.WriteLine("You are older than Iman Hazim!");
}
else
{
    Console.WriteLine("You are younger than Iman Hazim!");
}
*/

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hello Iman Hazim");
}
*/

/*
int[] marks = new int[10];
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("What are the student marks?");
    marks[i] = Convert.ToInt32(Console.ReadLine());
    sum += marks[i];
}

Console.WriteLine("Total marks: " + sum);
*/

int[,] val = { { 1, 2, 3 }, 
               { 4, 5, 6 }, 
               { 7, 8, 9 } };

Console.WriteLine(val[1, 2]);