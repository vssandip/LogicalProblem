using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            int n, n1 = 0, n2 = 1, n3;
            
           Console.WriteLine(n1 + " ");
            Console.WriteLine(n2 + " ");
            for (n = 0; n < 10; n++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }

        }

    }
}
