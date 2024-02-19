using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate_2
{
    static class ext_1
    {
        public static void fn_4(this Program p,int a)//binding parameter
        {
            Console.WriteLine($"Fn-4 called..{a}...!!!!!!");
        }

        public static bool isGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
