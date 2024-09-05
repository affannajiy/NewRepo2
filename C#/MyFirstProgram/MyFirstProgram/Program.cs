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

            int y = 321;

            int z = x + y;

            int age = 19;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey(); //program would not end until key is hit
        }
    }
}
