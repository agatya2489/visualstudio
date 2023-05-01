using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.ElseIfStatement
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int x = 7;
             if(x == 6)
            {
                Console.WriteLine("X is 6");
                Console.ReadLine();
            }
             else if(x == 5)
            {
                Console.WriteLine("X is 5");
                Console.ReadLine();
            }
             else if(x == 7)
            {
                Console.WriteLine("x is 7");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The condition is false");
                Console.ReadLine();
            }
        }
    }
}
