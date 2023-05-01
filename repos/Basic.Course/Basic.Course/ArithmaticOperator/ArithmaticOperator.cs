using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.ArithmaticOperator
{
    internal class ArithmaticOperator
    {
        static void Main(String[] args)
        {
            int a = 10;
            int b = 4;
            int c;

            //Addition
            c = a + b;
            Console.WriteLine(c);

            //Substraction
            c = a - b;
            Console.WriteLine(c);

            //Multiplication
            c = a * b;
            Console.WriteLine(c);   

            //Divide
            c=a/ b;
            Console.WriteLine(c);

            //Remainder
            c = a % b;
            Console.WriteLine(c);

            //Same DataTypes Only
            int d = 10;
            double e = 3;
            double f;

            f = d + e;
            Console.WriteLine(f);   

            Console.ReadLine();

        }
    }
}
