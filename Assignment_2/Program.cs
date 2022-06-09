using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Program
    {

        static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            calc.SetLength((10 / 2) - 2);
            calc.SetWidth((calc.GetPerimeter() / 2) - calc.GetLength());

            Console.WriteLine(calc.GetLength());
            Console.WriteLine(calc.GetWidth());

            Console.ReadKey();
        }
    }
}
