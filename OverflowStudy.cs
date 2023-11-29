using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralTypes
{
    class OverflowStudy
    {
        public void overflowEx()
        {
            uint a = uint.MaxValue;
            Console.WriteLine(a);
            a = a + 1;
            Console.WriteLine(a);

            int b = int.MaxValue;
            Console.WriteLine(b);
            b = b + 1;
            Console.WriteLine(b);
            string multiline = @"dk
ssd
u";
            Console.WriteLine(multiline);

        }
    }
}