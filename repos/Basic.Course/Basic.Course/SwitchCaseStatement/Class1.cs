using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.SwitchCaseStatement
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int x = 5;

            switch(x)
            {
                case 6:
                    Console.WriteLine("X is 6");
                    Console.ReadLine();
                    break;

                case 5:
                case 7:
                    Console.WriteLine("x is either 5 or 7");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("x was not found");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
