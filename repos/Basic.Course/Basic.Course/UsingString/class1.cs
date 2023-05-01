using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.UsingString
{
    static class class1
    {
        static void Main(String [] args)
        {
            //string userName = "Tom";
            //string greetings = "Hello there! ";

            //Console.WriteLine(greetings + userName);
            //Console.ReadLine();

            //decimal length1= 31.54445887m ;
            //decimal length2 = 458.1457854m;

            //String totalLength= (length1 + length2).ToString(); 
            
            //Console.WriteLine(totalLength);
            //Console.ReadLine(); 



            Process myProcess= new Process();
            myProcess.StartInfo.FileName = "mspaint.exe";
            myProcess.StartInfo.Arguments = "\"C:\\program files\\img4.jpg\"";
            myProcess.Start();


        }
    }
}
