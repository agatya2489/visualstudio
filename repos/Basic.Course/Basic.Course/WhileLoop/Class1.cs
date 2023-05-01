using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.WhileLoop
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            int x = 0;

            while (++x < 5)
            {
                Console.WriteLine(x);//Here we are put x and x++ also
                //x++ ;
            }
            Console.ReadLine();
        }
    }
}
