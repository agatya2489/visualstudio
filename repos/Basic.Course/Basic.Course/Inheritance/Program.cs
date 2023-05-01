using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Inheritance
{
    internal class Program
    {
        static void Main(String[] args)
        {
            MyClass MyObject = new MyAdditionClass(5, 7);

            Console.WriteLine(MyObject.Total);
            Console.ReadLine();
        }
    }
}
