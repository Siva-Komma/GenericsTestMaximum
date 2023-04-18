using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Test Maximum");
            MaxInteger.GivenInteger(20, 30, 40);
            MaxFloatValue.GivenFloat(10.2f, 20.2f, 1.2f);
            Console.ReadLine();
        }
    }
}
