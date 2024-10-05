using OOP_LabW5;
namespace OOP_LabW5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1: Calculate Circle Area Class
            CircleCalculator calc = new CircleCalculator();
            double radius = 5;

            Console.WriteLine($"Circle Area: {calc.CalculateArea(radius)}");

            //2: UTP Class
            UTP utp = new UTP("'Affan Najiy", "Computer Science", "C#", " May 2023", 4.0);
            Console.WriteLine($"Student Name: {utp.Name}");
            Console.WriteLine($"Department: {utp.Dept}"); 
            Console.WriteLine($"Course: {utp.Course}");
            Console.WriteLine($"Intake: {utp.Intake}");
            Console.WriteLine($"CGPA: {utp.CGPA}");

            //3: Person Class
            Person person = new Person("Affan", "Najiy", 100);
            person.Display();

            //4: Student Class
            Student student = new Student("Affan", 22010453);
            student.UpdateGPA(4.0);
            student.Display();

            //5: Shape Class
            Shape circle = new Circle(5); //(radius)
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Shape rectangle = new Rectangle(5, 10); //(width, height)
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }
}
