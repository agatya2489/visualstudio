using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.UsingSuffixes
{
    internal class Suffix
    {
        static void Main(String[] args)
        {
            decimal displayDecimal = 24.58987M;
            long displayLong = 24589696547l;

            Console.WriteLine(displayDecimal);
            Console.WriteLine(displayLong); 

            Debug.WriteLine(displayDecimal);
            Debug.WriteLine(displayLong);   

            Console.ReadLine();
        }
    }
}
