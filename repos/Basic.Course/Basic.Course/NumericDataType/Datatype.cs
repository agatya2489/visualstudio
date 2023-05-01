using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.NumericDataType
{
    internal class DataTypes
    {
       static void Main(String[] args)
        {
            int typeInt = 23;
            double typeDouble = 25.0034;

            Console.WriteLine(typeInt);
            Console.WriteLine(typeDouble);

            Debug.WriteLine(typeInt);
            Debug.WriteLine(typeDouble);

            Console.ReadLine(); 
        }
    }
}
