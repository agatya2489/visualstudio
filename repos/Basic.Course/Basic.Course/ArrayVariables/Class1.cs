using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.ArrayVariables
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            //int[] values;
            //values = new int[3];

            //values[0] = 3;
            //values[1] = 13;
            //values[2] = 34;

            int[] values = new int[3] { 2, 13, 25 };

            Console.WriteLine(values[0] + values[1] - values[2]);
            Console.ReadLine();
        }
    }
}
