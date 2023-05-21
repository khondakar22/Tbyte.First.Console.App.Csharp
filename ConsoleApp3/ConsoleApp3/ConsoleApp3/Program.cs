using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        // Starting point of our program
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.Clear();
            //Console.WriteLine("Prints and puts the cursor in the next line"); 
            //Console.Write("Prints and puts the cursor in the same line");
            //Console.Write("Hello Come");
            //Console.Read();
            //Console.Read(); //"Takes a single input of type string and it returns the ASCII value of the input"
            //// https://www.asciitable.com/
            //Console.ReadLine(); // Takes a string or integer input and returns it as the Output
            //Console.ReadKey(); // Takes a single input of type string and it returns the key info.

            //decimal newDecimal = 1.23544654654654564m;
            //float newFloat = 1.23231154f;
            ////double newDouble = 1.235465465454454d;
            //string str1 = "Hello";
            //string str2 = "Hello";
            //bool result = (str1 == str2);
            //Console.WriteLine(result);
            //Console.Read();

            long value = -1000_00_00_45_65_44;
            int result = (int)value;
            Console.WriteLine(result);
           // output = -1316591456
            Console.Read();
        }
    }

    //// Naming Convention
    //// Clas names like ProductInvoice 
    //class ProductInvocie
    //{
    //    //https://www.dofactory.com/csharp-coding-standards
    //    // Method name like CalculateValues
    //    static void Main(string[] args)
    //    {
    //        // local variables like itemCount
    //        // use userControl instead of useCtr

    //        // don't use numbers at the start of variable names
    //       int  3acs = 0;
    //        int acs_to = 4;

    //        // Correct
    //        string myName;
    //        int lastNum;
    //        bool isSaved;

    //        // Avoid 
    //        // String myName;
    //        // Int32 lastNum;
    //        // Boolean isSaved;
    //    }
    //}

    //// Convert to value or cast implicit and explicit

    //public class Conversation
    //{
    //    static void Main(string[] args )
    //    {
    //        double myDouble = 13.37;
    //        int myInt;

    //        // Explicit converstion; 
    //        // cast double to int;
    //        myInt = (int)myDouble;

    //        Console.WriteLine(myInt);
    //        Console.Read();


    //        // Implicit conversion

    //        int num = 1390532;
    //        long bigNum = num;

    //        float myFloat = 13.37f;
    //        double myNewDouble = myFloat;

          
    //        // TypeConversion
    //        string myString = myDouble.ToString(); // "13.37"
    //       //boolean
    //       bool areYouMotivate = false;
    //        string boolString = areYouMotivate.ToString();

    //        // Parsing String to Integer

    //        string myNewString = "15";
    //        string myAnotherString = "13";

    //        // Exception 

    //        int num1 = Int32.Parse(myNewString);
    //        int num3 = Int32.Parse(myAnotherString);

    //        string result = myNewString + myAnotherString;
    //        int resultInt = num1 + num3;

    //    }
    //}
}
