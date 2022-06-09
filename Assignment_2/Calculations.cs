using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Calculations
    {
        private int length = 0;
        private int width = 0;

        public Calculations() { }

        public int GetLength() { return length; }
        public void SetLength(int input) { length = input; }
        public int GetWidth() { return width; }
        public void SetWidth(int input) { width = input; }
        public int GetPerimeter() { return 2 * (length + width); }
        public int GetArea() { return GetLength() * GetWidth(); }
    }
}
