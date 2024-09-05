// See https://aka.ms/new-console-template for more information
// Below was added but the code was more simpler
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hej! "); //write without new line
            Console.WriteLine("I Like Pizza!"); //write with new line
            Console.WriteLine("It's really good!");
            //Console.Beep(); //Loud Ahh Beep

            //"This is a comment" ahh
            /*
             * this
             * is
             * a multiline
             * comment ahh
             */

            Console.WriteLine("\t'Affan"); //tab for indent
            Console.WriteLine("Af\bfan"); //backspace

            int x; //declaration
            x = 123; //initialisation
            int y = 321; //declare + initial
            int z = x + y;
            int age = 19; //whole numbers
            double height = 170.5; //decimals
            bool alive = true; //bool: True or False
            char symbol = '$'; //single quotes for characters
            String name = "Affan";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol: " + symbol);

            String userName = symbol + name;
            Console.WriteLine("Your username: " + userName);

            Console.ReadKey(); //program will end until key is hit
        }
    }
}
