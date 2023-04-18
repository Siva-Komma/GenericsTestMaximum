using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class ExpandMaxMethod
    {
        public static int GivenIntegerforExpandMaxMethod(int Firstvalue, int Secondvalue, int Thirdvalue ,int Fourthvalue)
        {
            if (Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) > 0 && Firstvalue.CompareTo(Fourthvalue)>0||
               Firstvalue.CompareTo(Secondvalue) >= 0 && Firstvalue.CompareTo(Thirdvalue) > 0 && Firstvalue.CompareTo(Fourthvalue) >= 0  ||
               Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) >= 0 && Firstvalue.CompareTo(Fourthvalue) > 0)
            {
                Console.WriteLine($"First number {Firstvalue} is greater than Second Number {Secondvalue} and ThirdNumber {Thirdvalue} and also {Fourthvalue}");
                return Firstvalue;
            }
            if (Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) > 0 && Secondvalue.CompareTo(Fourthvalue)>0 ||
                Secondvalue.CompareTo(Firstvalue) >= 0 && Secondvalue.CompareTo(Thirdvalue) > 0 && Secondvalue.CompareTo(Fourthvalue) >= 0 ||
                Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) >= 0 && Secondvalue.CompareTo(Fourthvalue) > 0)
            {
                Console.WriteLine($"Second number {Secondvalue} is greater than First Number {Firstvalue} and ThirdNumber {Thirdvalue} and also {Fourthvalue}");
                return Secondvalue;
            }
            if (Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) > 0 && Thirdvalue.CompareTo(Fourthvalue)>0 ||
               Thirdvalue.CompareTo(Firstvalue) >= 0 && Thirdvalue.CompareTo(Secondvalue) > 0 && Thirdvalue.CompareTo(Fourthvalue) >= 0 ||
               Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) >= 0 && Thirdvalue.CompareTo(Fourthvalue) > 0)
            {
                Console.WriteLine($"Third number {Thirdvalue} is greater than First Number {Firstvalue} and Second Number {Secondvalue} and also {Fourthvalue}");
                return Thirdvalue;
            }
            if (Fourthvalue.CompareTo(Firstvalue) > 0 && Fourthvalue.CompareTo(Secondvalue) > 0 && Fourthvalue.CompareTo(Thirdvalue) > 0 ||
               Fourthvalue.CompareTo(Firstvalue) >= 0 && Fourthvalue.CompareTo(Secondvalue) > 0 && Fourthvalue.CompareTo(Thirdvalue) >= 0 ||
               Fourthvalue.CompareTo(Firstvalue) > 0 && Fourthvalue.CompareTo(Secondvalue) >= 0 && Fourthvalue.CompareTo(Thirdvalue) > 0)
            {
                Console.WriteLine($"Fourth number {Fourthvalue} is greater than First Number {Firstvalue} and Second Number {Secondvalue} and also {Thirdvalue}");
                return Fourthvalue;
            }
            return Firstvalue;
        }
    }
}

