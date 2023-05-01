using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.TryCatchBlock
{
    internal class Class1 
    {
        static void Main(String[] args)
        {
			try
			{
				int x = 0;
				int y = 7/x;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: "+ex.Message);
				//throw;
			}
			Console.ReadLine();
        }
    }
}
