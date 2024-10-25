/*Delagates C#
 *Def: It is a method which can be passed as an argument to another method.
 */

class Program
{
    //Step 1 : Declaring a delegate
    public delegate bool CheckSmartPhone(string smartPhoneName);
    static void Main(string[] args)
    {
        //Step 2 : Creating a delegate instances
        CheckSmartPhone isThisSmartPhone = new CheckSmartPhone(GetIPhoneX);

        //Step 3 : calling the methods using the delegate objects
        bool checkSmartPhone = isThisSmartPhone("IPhoneX");
        if (checkSmartPhone)
        {
            System.Console.WriteLine("It is an Apple smart phone!!!");
        }
        else
        {
            System.Console.WriteLine("It is not an Apple smart phone!!!");
        }

        //Android Phone Delegate Objects
        CheckSmartPhone isThisSmartPhone2 = new CheckSmartPhone(GetSamsungGalaxyS24);
        bool checkSmartPhone2 = isThisSmartPhone2("Samsung Galaxy S24");
        if (checkSmartPhone2)
        {
            System.Console.WriteLine("It is an Android smart phone!!!");
        }
        else
        {
            System.Console.WriteLine("It is not an Android smart phone!!!");
        }
    }

    //Apple Phone
    private static bool GetIPhoneX(string name)
    {
        if (name == "IPhoneX")
            return true;
        else
            return false;
    }

    //Android Phone
    private static bool GetSamsungGalaxyS24(string name)
    {
        if (name == "Samsung Galaxy S24")
            return true;
        else
            return false;
    }
}