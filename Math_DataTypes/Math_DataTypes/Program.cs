using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 7;
            //float num2 = 5.5f;
            ////??? total = num1 + num2;

            //float total = num1 + num2;

            //int total = num1 + (Int32)num2;


            //double num1 = 7.03230923;
            //float num2 = 5.9f;
            //double total = num1 + num2;   //must cast (Cannot implicitly convert type 'double' to 'float'.)
            //Console.WriteLine(total);
            //Console.ReadLine();
            //output = 12.9323093253674

            //A “float” is 32-bit and a “double” is 64-bit. In other words, a “float” is no more than
            //7 digits long, and a “double” is no more than 15-16 digits long. So a “double” is the more precise choice.

            //-------------------------------

            //If we wanted to go the other way and convert a “double” to a “float,”
            //we would have to do an “explicit conversion” on the “double” value.//

            //double num1 = 7.03230923;
            //float num2 = 5.9f;
            //float total = (float)num1 + num2;
            //Console.WriteLine(total);
            //Console.ReadLine();
            ////The output is 12.93231 

            //------Casting Math ------------------------------------------------- //
            //implicitly cast from integer data types like “int” to a “decimal” this way:
            //decimal num1 = 7.03230923m;
            //int num2 = 5;
            //decimal total = num1 + num2;
            //Console.WriteLine(total);
            //The output is 12.03230923

            //Or

            //decimal num1 = 7.03230923m;
            //sbyte num2 = 5;
            //decimal total = num1 + num2;
            //Console.WriteLine(total);
            //The output is 12.03230923

            //------Math with Strings--------------------------------------------//
            string firstName = "Jesse";
            string lastName = "Johnson";
            Console.WriteLine(firstName + lastName);
            Console.ReadLine();
            //output is JesseJohnson  <-- This is called string concatenation. 


            //Implicit conversion of data types: 
            string name = "Jesse";
            int number = 5;
            Console.WriteLine(name + number);
            Console.ReadLine();
            //output is Jesse5

            //Converting to string is probably the easiest and most consistent conversion available to you in C#.
            //Addition is the only “math” operator available to strings.







        }
    }
}
