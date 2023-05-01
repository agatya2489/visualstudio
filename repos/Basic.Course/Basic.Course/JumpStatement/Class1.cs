using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.JumpStatement
{
    internal class Class1
    {    static void Main(String[] args)
        {
            string[] names = new string[5] { "Sam", "Martin", "Daniel", "Mussa", "Wiliam" };

            foreach (string name in names)
            {
                if (name == "Mussa")
                {
                    //continue;
                    //break;
                    //goto theEnd;
                    //return;
                    throw new ApplicationException();
                }
                Console.WriteLine(name);
            }

            //theEnd:
            Console.ReadLine();
        }
    }
}
