using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Generics
{
    static class Program
    {
        static void Main(string[] args)
        {
            IValueIncrease<int> MyMath = new UpdatedIntegerValueIncrease(7, 8);

        }
    }
}
