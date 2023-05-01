using Basic.Course.CreatingAClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.RefernceTypes
{
    internal class Program
    {
        static void Main(String[] args) 
        {
            //int x = 7;
            //int y = x;

            //y++;

            //Console.WriteLine(x);
            //Console.ReadLine();
        
            MyClass MyObject = new MyClass(8, 3);

            MyClass MyObject2 = MyObject;

            MyObject2.
            MyObject.doMath();
        
        }
    }
}
