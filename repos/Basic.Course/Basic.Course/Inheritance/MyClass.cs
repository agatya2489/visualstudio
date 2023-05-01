using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Inheritance
{
    internal class MyClass
    {
        private int _total;
        public int Total
        {
            get { return _total; } 
        }
        public MyClass(int value1, int value2)
        {
            _total = addTwoIntegers(value1, value2);
        }

        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
