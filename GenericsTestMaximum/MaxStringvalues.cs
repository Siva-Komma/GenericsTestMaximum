using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    internal class MaxStringvalues
    {
        public static string GivenString(string Firstvalue, string Secondvalue, string Thirdvalue)
        {
            if (Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) > 0 ||
               Firstvalue.CompareTo(Secondvalue) >= 0 && Firstvalue.CompareTo(Thirdvalue) > 0 ||
               Firstvalue.CompareTo(Secondvalue) > 0 && Firstvalue.CompareTo(Thirdvalue) >= 0)
            {
                Console.WriteLine($"First string value {Firstvalue} is greater than Second string value {Secondvalue} and Third string value {Thirdvalue}");
                return Firstvalue;
            }
            if (Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) >= 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) >= 0)
            {
                Console.WriteLine($"Second string value {Secondvalue} is greater than First string value {Firstvalue} and Third string value {Thirdvalue}");
                return Secondvalue;
            }
            if (Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) >= 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) >= 0)
            {
                Console.WriteLine($"Third string value {Thirdvalue} is greater than First string value {Firstvalue} and Second string value {Secondvalue}");
                return Thirdvalue;
            }
            return Firstvalue;
        }
    }
}

