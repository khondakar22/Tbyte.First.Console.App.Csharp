using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTry
{
    public class Class1
    {
        public void PeformanceTest()
        {
            const int Iterations = 1000000;
            Stopwatch stopwatch = new Stopwatch();
            // Test switch statement
            stopwatch.Start();
            for (int i = 0; i < Iterations; i++)
            {
                TestSwitch(5);
            }
            stopwatch.Stop();
            Console.WriteLine($"Switch statement time: {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();

            // Test if-else if statements

            stopwatch.Start();
            for (int i = 0; i < Iterations; i++)
            {
                TestIfElse(5);
            }
            stopwatch.Stop();
            Console.WriteLine($"If-else statement time: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void TestSwitch(int number)
        {
            switch (number)
            {
                case 0:
                    //Console.WriteLine(number);
                    break;
                case 1:
                    //Console.WriteLine(number);
                    break;
                case 2:
                    //Console.WriteLine(number);
                    break;
                case 3:
                    //Console.WriteLine(number);
                    break;
                case 4:
                    //Console.WriteLine(number);
                    break;
                case 5:
                    //Console.WriteLine(number);
                    break;
                case 6:
                    //Console.WriteLine(number);
                    break;
                default:
                    //Console.WriteLine(number);
                    break;

            }
        }
        public void TestIfElse(int number)
        {
            if (number == 1)
            {
                //Console.WriteLine(number);
            }
            else if (number == 2)
            {
                //Console.WriteLine(number);
            }
            else if (number == 3)
            {
                //Console.WriteLine(number);
            }
            else if (number == 4)
            {
                //Console.WriteLine(number);
            }
            else if (number == 5)
            {
                //Console.WriteLine(number);
            }
            else if (number == 6)
            {
                //Console.WriteLine(number);
            }
            else { 
                //Console.WriteLine(number); 
            }
        }
    }
}
