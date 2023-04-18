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
            MaxStringvalues.GivenString("Hello", "Hi", "Hru");
            Refactor1<int>.UsingDifferentDatatypesFindMaxValue(10, 20, 30);
            Refactor1<float>.UsingDifferentDatatypesFindMaxValue(10.5f, 10.55f, 10.555f);
            Refactor1<string>.UsingDifferentDatatypesFindMaxValue("Welcome","Hru","Fine");
            Console.ReadLine();
        }
    }
}
