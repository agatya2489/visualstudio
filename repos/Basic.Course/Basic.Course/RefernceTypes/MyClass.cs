using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.RefernceTypes
{
     class MyClass
    {
        private int Value1 { get; set; }
        private int Value2 { get; set; }

        //public MyClass() 
        //{
        //    Value1 = 6;
        //    Value2 = 4;
        //}

        public MyClass(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public void doMath()
        {
            Console.WriteLine(addTwoInteger(this.Value1, Value2));
            Console.ReadLine();
        }

        public int doMath(int value1, int value2)
        {
            return addTwoInteger(value1, value2);
        }

        public int doMath(int value1, int value2, int maxTotal)
        {
            int total = addTwoInteger(value1, value2);
            if(total > maxTotal) total = maxTotal;
            return total;
        }
        private int addTwoInteger(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;

        }
    }
}
