using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class Refactor1<T> where T : IComparable<T>
    {
        public T Firsvalue, SecondValue, ThirdValue;
        public Refactor1(T Firsvalue, T SecondValue, T ThirdValue)
        {
            this.Firsvalue = Firsvalue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }
        public static T UsingDifferentDatatypesFindMaxValue(T Firstvalue, T Secondvalue, T Thirdvalue)
        {
            if (Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) > 0 ||
               Firstvalue.CompareTo(Secondvalue) >= 0 && Firstvalue.CompareTo(Thirdvalue) > 0 ||
               Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) >= 0)
            {
                Console.WriteLine($"First number {Firstvalue} is greater than Second Number {Secondvalue} and ThirdNumber {Thirdvalue}");
                return Firstvalue;
            }
            if (Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) >= 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) >= 0)
            {
                Console.WriteLine($"Second number {Secondvalue} is greater than First Number {Firstvalue} and ThirdNumber {Thirdvalue}");
                return Secondvalue;
            }
            if (Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) >= 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) >= 0)
            {
                Console.WriteLine($"Third number {Thirdvalue} is greater than First Number {Firstvalue} and Second Number {Secondvalue}");
                return Thirdvalue;
            }
            return Firstvalue;
        }
    }
}
