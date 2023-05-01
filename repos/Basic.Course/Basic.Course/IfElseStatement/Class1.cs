using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.IfElseStatement
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            //Boolean condition = true;
            if (5 != 6) //in this braces we write multiple Relational Operators
            {
                Console.WriteLine("The condition is true!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The condition is false!");
                Console.ReadLine();
            }
        }
    }
}
