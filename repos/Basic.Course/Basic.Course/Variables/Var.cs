using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Variables
{

    internal class Basics
    {
        static void Main(string[] args)
        {
            //String= DataType; displayText=Variable Name; =-Assignment operator; Hello World=value
            string displayText = "Hello World";

            Console.WriteLine(displayText);

            Debug.WriteLine(displayText);
            Debug.WriteLine(displayText.Count());  //Extension Methods- Provide additional functionality== Count()
            Console.ReadLine();
        }


    }
}
