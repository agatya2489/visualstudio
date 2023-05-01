// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Course.WritingYourFirstCode
{
    static class Program
    {
        static void Main(string[] args)
        {
            String displayText;
            displayText = "Hello World!";

            Console.WriteLine(displayText);
            //Console.ReadLine();

            Debug.WriteLine(displayText);
            Debug.WriteLine(displayText.Count());
            Console.ReadLine();
        }
    }
}
