using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Do_WhileLoop
{
    internal class Class1
    {
       static void Main(string[] args)
        {
            int x = 6;

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 6);
            Console.ReadLine();
        }
    }
}
