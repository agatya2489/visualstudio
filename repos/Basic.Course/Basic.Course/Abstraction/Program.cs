using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Abstraction
{
    class Program
    {
        static void Main(String[] args)
        {
            AdditionalClass AddTwoValues = new AddTwoDoubles(3453.4325, 657889.24);
           // AdditionalClass AddTwoValues = new AddTwoIntegers(3453, 7854);
        }
    }
}
