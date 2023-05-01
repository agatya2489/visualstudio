using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Generics
{
    internal class UpdatedIntegerValueIncrease : IValueIncrease<int>
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public UpdatedIntegerValueIncrease(int value1, int value2)
        {
            Value1 = value1;    
            Value2 = value2;        
        }
        public int Product()
        {
            return (int)Value2 + (int)Value1;
        }
        public int Sum()
        {
            return (int)Value2 + (int)Value1;
        }
    }
}
