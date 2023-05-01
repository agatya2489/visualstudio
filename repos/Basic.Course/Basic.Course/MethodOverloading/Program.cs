using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject;
            MyObject= new MyClass(8, 3);

            MyObject.doMath();
            //Console.WriteLine(MyObject.doMath(5, 9, 11));
            //Console.ReadLine();
        }
    }
}
