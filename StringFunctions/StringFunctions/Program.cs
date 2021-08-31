using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-------escape sequences for strings---------

            //string name = "Sophia";
            //// to display quotes, new line and reflect a tab 
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //// to display backslashes "\\" or just use @ -> @"C:\Users\Sophia";
            //String fileName = "C:\\Users\\Sophia";


            ////---- methods to call functions on strings ---- 

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //-------------String Builder-----------------------

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);
            Console.ReadLine();

            

        }
    }
}
