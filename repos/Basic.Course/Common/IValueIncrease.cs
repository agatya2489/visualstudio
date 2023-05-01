using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Generics
{
    public interface IValueIncrease<T> : IValue1Property<T>, IValue2Prorperty<T>,ISumMethod<T>, IProductMethod<T>
    {
    }
}
