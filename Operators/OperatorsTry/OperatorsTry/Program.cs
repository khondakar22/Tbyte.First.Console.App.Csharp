using OperatorsTry;
using System;
using System.Diagnostics;
//class A
//{
//    protected int x = 123;
//}

class Program 
{
   


    static void Main()
    {
        //const int Iterations = 10000000;

        //Stopwatch stopwatch = new Stopwatch();

        //// Test switch statement
        //stopwatch.Start();
        //for (int i = 0; i < Iterations; i++)
        //{
        //    TestSwitch(5);
        //}
        //stopwatch.Stop();
        //Console.WriteLine($"Switch statement time: {stopwatch.ElapsedMilliseconds} ms");

        //stopwatch.Reset();
        //var a = new A();
        //var b = new Program();

        //a.x = 10;

        //b.x = 10;

        //int i = 1;
        //do
        //{
        //    if (i % 2 == 0)
        //        continue;
        //    else if (i == 7)
        //        break;
        //    else
        //        Console.WriteLine(i);
        //    i++;
        //}
        //while (i <= 10);
        int i = 0;
        do
        {
            i++;
            if (i == 3)
                break;
            Console.WriteLine(i);
        } while (i < 5);

        //// Test if-else if statements
        //stopwatch.Start();
        //for (int i = 0; i < Iterations; i++)
        //{
        //    TestIfElse(5);
        //}
        //stopwatch.Stop();
        //Console.WriteLine($"If-else statement time: {stopwatch.ElapsedMilliseconds} ms");


        // Simple If else

        //int voteCount = 0;
        //string result = null;

        //if(voteCount > 150)
        //{
        //    result = "Won";

        //} else
        //{
        //    result = "lost";
        //}

        //Console.WriteLine($"Vote count has beenn completed. Party {result}");

        // Simple If Branch
        //voteCount += 151;
        //var result = voteCount > 150 ? "Majority Seat Won" : "Lost";
        //Console.WriteLine($"Vote count has beenn completed. Party {result}");
        // Multi-Nested If branch
        //int number = 0;
        //string? numberResult = null;

        //if (number > 0)
        //{
        //    if (number % 2 == 0)
        //    {
        //        numberResult = "Positive Even Number";
        //    }
        //    else
        //    {
        //        numberResult = "Positive Odd Number";
        //    }
        //}
        //else if (number < 0)
        //{
        //    numberResult = "Negative Number";
        //}
        //else
        //{
        //    numberResult = "Zero";
        //}



        //numberResult = number > 0 
        //                        ? number % 2 == 0 
        //                            ? "Positive Even Number" 
        //                                : "Positive Odd Number" 
        //               : number < 0 
        //                    ? "Negative Numvber" 
        //                        : "Zero";

        //Console.WriteLine($"Number {number} is {numberResult}");
        // Multi-branching 

        //int score = 85;
        //string grade; 

        //if(score >= 90)
        //{
        //    grade = "Outstanding";
        //} else if(score >= 80)
        //{
        //    grade= "Good";
        //}else if(score >= 70)
        //{
        //    grade = "Average";
        //} else if (score >= 60)
        //{
        //    grade = "Below Average";
        //} else
        //{
        //    grade = "Bad Performer";
        //}
        //Console.WriteLine($"You are {grade}");
        //grade = score >= 90 ? "A" : score >= 80 ? "B" : score >= 70 ? "C" : score >= 60 ? "D" : "F";

        //The null coalescing operator (??) in C# provides a concise way to handle null values.
        //It returns the left-hand operand if it is not null, or the right-hand operand otherwise. 

        //string? myName = null;
        //string yourName = myName ?? "Muhammad";
        //Console.WriteLine(yourName);
        //int x = 5;
        //int y = 10;

        //int? result = (x > y) ? x : ((y > x) ? y : null) ?? 0;

        ////Console.WriteLine(result);
        //int x= 5;
        //int y = 10;

        //int result = x > y ? (x / y) : (y / x) ?? 0;

        //Console.WriteLine(result);
        //string? name = null;
        //string message = $"Welcome {(name ?? "Guest")}, enjoy your stay!";
        //Console.WriteLine(55/15);


        // Known Number of Iterations in advance
        // Syntax;
        //for(initialization;condition; increment / decrement)
        //{
        //    // Code to be executed
        //}
        //for(int counter = 0; counter < 10; counter+=2)
        //{
        //    Console.WriteLine(counter + 1);
        //}

        // String Reversal
        //string str = "Hello";
        //string reversed = "";
        //Console.WriteLine(str.Length);
        //Console.WriteLine(str.Length - 1);
        //for (int i = str.Length-1; i>=0; i--) {
        //    Console.WriteLine(i);
        //    reversed += str[i];
        //}
        //Console.WriteLine(reversed);

        // ForEach Loop
        // Iterate over elemens like array or collection or list

        // Syntax: 
        //foreach(var item in collection)
        //{
        //Code Executated
        //}

        // Palindromes
        // String ke ulto korle same string ashbe jemon, MOM, level

        //string[] wordCollection = { "level", "hello", "mom", "racecar", "world" };

        //foreach (string word in wordCollection) {
        //    bool isPalindrom = true; 


        //    for(int i = 0; i < word.Length / 2; i++)
        //    {
        //        if (word[i]  != word[word.Length-1-i])
        //        {
        //            isPalindrom = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine($"{word} is {(isPalindrom ? "a palindrome" : "not a palindrome")}");
        //}

        /// Today class

        // Ternary Operator C# Builtin method
        //string input = "level";


        //string[] wordCollection = { "level", "hello", "mom", "racecar", "world" };

        //foreach (string word in wordCollection)
        //{
        //    bool isPalindrome = input.SequenceEqual(word.Reverse());
        //    Console.WriteLine($"{word} is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
        //}

        //string result = isPalindrome ? "Palindrome" : "Not Palindrome";

        //Console.WriteLine(result);  // Output: Palindrome


        // Break and Continue

        //for(int counter = 0; counter < 10; counter++)
        //{
        //    Console.WriteLine(counter);
        //    if (counter == 3)
        //    {
        //        Console.WriteLine("At 3 we stop");
        //        break;
        //    }
        //}


        //for (int counter = 0; counter < 10; counter++)
        //{

        //    if (counter %2 == 0)
        //    {
        //        Console.WriteLine("Next one is odd number");
        //        continue;
        //    }
        //    Console.WriteLine(counter);
        //}
        //Console.WriteLine("Loop break");

        // While Loop
        // Repeatedly executes a block of code as long as specified condition is true.
        // Syntax
        //initalization
        //while(condition) {
        // incremeant 
        // }

        // Integer Reversal
        //int number = 123456;
        //int reversedNumber = 0;

        //while (number != 0) {
        //    int remainder = number % 10;
        //    Console.WriteLine(remainder);
        //    reversedNumber = reversedNumber * 10 + remainder;
        //    Console.WriteLine(reversedNumber);
        //    number /= 10; 
        //}
        //Console.WriteLine(reversedNumber);

        // Do-While Loop
        // Similar While loop // code block will be executated at least once before
        // checking the condition


        //do
        //{
        //    Console.WriteLine(reversedNumber);
        //}
        //while (number != 0);

        //int i = 1;
        //do
        //{
        //    if (i % 3 == 0 && i % 5 == 0)
        //        Console.WriteLine("FizzBuzz");
        //    else if (i % 3 == 0)
        //        Console.WriteLine("Fizz");
        //    else if (i % 5 == 0)
        //        Console.WriteLine("Buzz");
        //    else
        //        Console.WriteLine(i);
        //    i++;
        //} while (i <= 100);


        //int counter = 0;
        //do
        //{
        //    Console.WriteLine(counter);
        //    counter++;
        //} while (counter < 5);

        // OOP - more 
        // build database of User object
        // User information class ( properties, member)

        // Class 
        // prototype of object by creating class
        // A class is a blue print of an Object
        // It has actions/abilities - so called member functions or methods (console)
        // and it has properties- so called member variables
        // Inheritance possible
        // Can be used like a Datatype (e.g String is a class)




        //int i = 1;
        //while (i <= 5)
        //{
        //    if (i == 3)
        //    {
        //        i++;
        //        continue;
        //    }

        //    Console.Write(i + " ");

        //    if (i == 4)
        //        break;

        //    i++;
        //}

        //int i = 1;
        //do
        //{
        //    if (i % 2 == 0)
        //    {
        //        i++;
        //        continue;
        //    }

        //    Console.Write(i + " ");

        //    if (i == 7)

        //        break;

        //    i++;
        //} while (i <= 10);




        //int i = 1;
        //do
        //{
        //    Console.Write(i + " ");

        //    if (i == 3)
        //        break;

        //    i++;
        //} while (i <= 5);


        // Object create object out of class
        // Porperties: HP, Color, wheels Doors
        // Abilities: Drive, Break, Automatic window
        // Inheritance. E.g. A5 < Audi < Class


        // A class in c# (and most other OOp is a blue print for creating object 
        // It defines a set of properties(data attributes) and methods that an object of an class will be used

        // Call Car
        // New key, used to instantiate a new object and allocate memory in heap of new object
        // It is called the constructor to iniatlize the object and then return an reference to the object
        // this ref can used later one
        //Car mercedez = new Car( "mercedez", default);
        //mercedez.Drive();
        //mercedez.Details();
        //Car opel = new Car("opel", 350, Color.Blue);
        //opel.Drive();
        //opel.Details();
        //Console.WriteLine("Press 1 to stop the car!");
        //string userInput = Console.ReadLine();
        //if(userInput == "1")
        //{
        //    mercedez.Stop();
        //} else if(userInput == "2")
        //{
        //    Console.WriteLine("Car drives indefinetly");
        //}

        //Box box = new Box();
        ////box.lenght = 3;
        //box.SetLength(10);
        //box.width = 5;
        ////box.height = 6;
        //box.Height = 4;
        //box.GetLength();

        //box.DisplayInfo();

    }

    static void TestSwitch(int value)
    {
        switch (value)
        {
            case 1:
                // Code block for case 1
                break;
            case 2:
                // Code block for case 2
                break;
            case 3:
                // Code block for case 3
                break;
            case 4:
                // Code block for case 4
                break;
            case 5:
                // Code block for case 5
                break;
            // Add more cases as needed
            default:
                // Code block for default case
                break;
        }
    }

    static void TestIfElse(int value)
    {
        if (value == 1)
        {
            // Code block for value 1
        }
        else if (value == 2)
        {
            // Code block for value 2
        }
        else if (value == 3)
        {
            // Code block for value 3
        }
        else if (value == 4)
        {
            // Code block for value 4
        }
        else if (value == 5)
        {
            // Code block for value 5
        }
        // Add more if-else statements as needed
        else
        {
            // Code block for default case
        }
    }
}