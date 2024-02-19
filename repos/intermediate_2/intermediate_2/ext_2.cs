using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intermediate_2
{
    internal class ext_2
    {
        static void Main()
        {
            //to ryn this file main..
            //right click on soltion explorer --> properties --> startup object...select file name where main is...

            Program program= new Program();
            program.fn_original();//from program original class
            program.fn_4(15);//extended
            //chk intellisence after '.' you will see a down arrow on the fn icon whcih tells that this method is added by extension

            int number = 10;
            Console.WriteLine(number.isGreaterThan(12));

            //we can extend .Net built-in classes...like we extend struct int
        }
    }
}
