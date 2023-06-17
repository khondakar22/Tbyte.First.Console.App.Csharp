using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTry
{
    internal class Box
    {
        // Properties

        // member variable
        private int length = 3;
        private int height;
        //public int width;
        public int volumn;

        // setter and getter
        public void SetLength(int length)
        {
            this.length = length;
        }

        //

        public int Width { get; set; }

        public int Height
        {
            get { return height; } 
            set { height = value; }
        }

        public int Height1 { get; set; } = 0;

        public int GetLength()
        {
            return this.length;
        }
        public Box() { }

        //public void DisplayInfo()
        //{
        //    Console.WriteLine("Length is {0} and height is {1}, width is {2}, volumn {3}", lenght, height, width, lenght * height* width );
        //}
    }
}
