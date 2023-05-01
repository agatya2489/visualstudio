﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Abstraction
{
    class AddTwoDoubles : AdditionalClass
    {
        private double _total;
        public override object Total
        {
            get 
            {
                return _total;
            }
        }
        public AddTwoDoubles(double value1, double value2)
        {
            _total = (double)this.AddTwoValues(value1, value2);
        }

        protected override object AddTwoValues(object Value1, object Value2)
        {
            double sum = (double)Value1 + (double)Value2;
            return sum;     
        }
    }
}
