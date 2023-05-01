﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Generics
{
    public class IntegerValueIncrease : Interfaces.IValueIncrease
    {
        public object Value1 { get; set ; }
        public object Value2 { get; set ; }

        public IntegerValueIncrease(int value1, int value2)
        {
            Value1= value1;
            Value2= value2; 
        }

        public object Product()
        {
            return (int)Value1 + (int)Value2;
        }
        public object Sum()
        {
            return (int) Value1+ (int)Value2;
        }
    }
}
