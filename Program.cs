using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 7;                              // Expected answer better be 7!!!
           
            int eq1 = -1 + 4 * myVar;                   // Expected equation answer 27.
            int eq2 = (35 + 5) % (myVar);               // Expected equation answer 5.
            int eq3 = 14 + -4 * 6 / 12;                 // Expected equation answer 12.
            float eq4 = 2 + 12 / 6 * 1 - myVar % 2;     // Expected equation answer 3.

            
            Console.WriteLine(eq1);
            Console.WriteLine(eq2);
            Console.WriteLine(eq3);
            Console.WriteLine(eq4);

            if (myVar < 10)
            {
                Console.WriteLine("myVar is greater than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");          
            }
        }
    }
}
