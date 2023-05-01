using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Polymorphism
{
    internal class Program
    {
        static void Main(String[] args)
        {
            MyClass MyObject = new MyAdditionClass(5, 7, 11);

            Console.Write(MyObject.Total);
            Console.ReadLine(); 
        }
    }
}
