using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparrisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            //----Addition------
            //int total = 5 + 10;
            //Console.WriteLine("Five plus ten = " + total.ToString());
            //Console.ReadLine();

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            ////---Subtraction-----
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            ////---multiplication--- 
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //----division-------- 
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //modulus operator 
            //----remainnder (even or odd)------
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine(); 

            //----comparrison operators ---------//
            //output a boolean 

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();



        }
    }
}
