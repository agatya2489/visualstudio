using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.DebuggingCode
{
    internal class Class1
    {
        static void Main(String[] args)
        {
            string userName = "johnathan";
            //int[] infoToDisplay = new int[1];
            int[] infoToDisplay = new int[2];

            infoToDisplay[0] = 28;
            infoToDisplay[1] = 18;

            Console.WriteLine(userName + " is " + infoToDisplay[0] + " years old and has sold " + infoToDisplay[1] + " bowls of chilli.");
            Console.ReadLine();
        }
    }
}
