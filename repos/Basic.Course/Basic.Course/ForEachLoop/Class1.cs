using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.ForEachLoop
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            string[] names = new string[5] { "Sam","Martin","Daniel","Mussa","Wiliam"};

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine(); 
        }
    }
}
