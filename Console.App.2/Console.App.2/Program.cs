using System;

namespace Console.App._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please Enter your name");
            var takeName = System.Console.ReadLine();
            System.Console.WriteLine("Hello " + takeName);
            System.Console.WriteLine("_______________________");
            System.Console.WriteLine("Please Enter your password");
            var password = System.Console.ReadLine();
            System.Console.WriteLine("Welcom " + password);
            System.Console.ReadKey();

        }
    }
}