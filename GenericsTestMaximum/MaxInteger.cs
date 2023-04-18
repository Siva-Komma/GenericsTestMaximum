using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTestMaximum
{
    class MaxInteger
    {
        public static int GivenInteger(int Firstvalue, int Secondvalue, int Thirdvalue)
        {
            if(Firstvalue.CompareTo(Secondvalue)>0 && Firstvalue.CompareTo(Thirdvalue)>0 ||
               Firstvalue.CompareTo(Secondvalue)>=0 && Firstvalue.CompareTo(Thirdvalue)>0 ||
               Firstvalue.CompareTo(Secondvalue)> 0 && Firstvalue.CompareTo(Thirdvalue)>=0)
            {
                return Firstvalue;
            }
            if (Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) >= 0 && Secondvalue.CompareTo(Thirdvalue) > 0 ||
                Secondvalue.CompareTo(Firstvalue) > 0 && Secondvalue.CompareTo(Thirdvalue) >= 0)
            {
                return Secondvalue;
            }
            if (Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) >= 0 && Thirdvalue.CompareTo(Secondvalue) > 0 ||
               Thirdvalue.CompareTo(Firstvalue) > 0 && Thirdvalue.CompareTo(Secondvalue) >= 0)
            {
                return Thirdvalue;
            }
            return Firstvalue;
        }
    }
}
