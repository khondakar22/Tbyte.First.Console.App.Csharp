using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTry
{

    public enum Color
    {
        Red,
        Green, 
        Blue,
        Black,
        Yellow,
    }
    // Access withing the same assembly
    internal class Car
    {
        // Constructor
        // Default
        // Similar to method that will be called once we crate a object of blue prit class 
        // member fields
        private string _name; // private field typically used for storing data.
        private int _hp;
        private Color _color;


        // default constructor
        public Car()
        {
            _name = string.Empty;
            _hp = 0;
            _color = default;
        }
   

        

        // Full Specification Constructor
        public Car(string name, int hp = 0, Color color = default)
        {
            _name = name;
            Console.WriteLine($"{_name} is created");
            _hp = hp;
            _color = color;
        }

        // Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine($"{_name} is created");
            _hp = hp;
            _color = default;
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} is Stoped");
        }

        public void Details()
        {
            Console.WriteLine($"The {_color} Car {_name} has {_hp} horsePower");
        }

        // Access Modifier

        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

        // 
        //public
        //protected 
        //internal
        //private
        //file


    //    public: Access isn't restricted.
    //protected: Access is limited to the containing class or types derived from the containing class.
    //internal: Access is limited to the current assembly.
    //protected internal: Access is limited to the current assembly or types derived from the containing class.
    //private: Access is limited to the containing type.
    //private protected: Access is limited to the containing class or types derived from the containing class within the current assembly.
    //file: The declared type is only visible in the current source file.File scoped types are generally used for source generators.

    }
}
