using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Course
{
    internal class Practise1
    {
        static void Main(String[] args)
        {
            String typeText;
            typeText = "Hello World! Welcome to C# .Net";

            Console.WriteLine(typeText);

            Debug.WriteLine(typeText);
            Debug.WriteLine(typeText.Count());
            Console.ReadLine();
        }
    }
}
