namespace ConsoleClassMethods
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        //Console.Clear();
    //        //Console.BackgroundColor = ConsoleColor.Cyan;
    //        //Console.ForegroundColor = ConsoleColor.Yellow;
    //        //Console.WriteLine("Hello, World!"); // Cursor move in the next line
    //        //Console.Write("Display and puts the cursor in the same line");
    //        Console.Write("Hello Universe!");
    //        //Console.Read();
    //        //var userInput = Console.ReadLine();
    //        //Console.WriteLine(userInput);
    //        //Console.ReadKey();
    //        //Console.Clear();
    //        //Console.Read();
    //    }
    //}

    // Naming Convention and Codding Standard
    //public class ProductInvoice
    //{
    //    static void Main(string[] args)
    //    {
    //        int 4age = 0;
    //        int acs_to = 4;
    //        int acsTo = 0;

    //        string myName = "Riyad";
    //        String myUserName = "Riyad";
    //    }
    //}

    public class ProductCasting
    {
        static void Main(string[] args)
        {
            float myDoubleAge = 13.37f;
            int myIntAge;

            // Explicit Conversion
            myIntAge = (int)myDoubleAge;

            Console.WriteLine(myIntAge);
            // String to Integer
            string myStringAge = "18";

            int num1 = 4;
            int num2 = 5;
            Console.WriteLine( num1 + num2);

            string number1 = "4";
            string number2 = "6";

            int numInt1 = Int32.Parse(number1);
            int numInt2 = Int32.Parse(number2);

            Console.WriteLine(numInt1 + numInt2);
            
            //int myAge = Int32.Parse(myStringAge); 
            //Console.WriteLine(myAge);
            Console.Read();
        }
    }

}