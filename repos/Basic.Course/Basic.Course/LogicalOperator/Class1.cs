using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.LogicalOperator
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int x = 5;

            //Console.WriteLine( (x > 5 && x < 10) || x == 20 || (x != 13 && x>=0) );
            Console.WriteLine( (x > 5 || x < 10) && (x >= 4 && x <= 4));
            
            Console.ReadLine();
        }
    }
}
