using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Branching -----------------//
            //if (true)
            //{
            //    Console.WriteLine("Hello!");
            //    Console.ReadLine();
            //}

            //-----------IF/Else statements--------//
            //if (1 == 1)
            //{
            //    Console.WriteLine("1 equals 1!");
            //}
            //else
            //{
            //    Console.WriteLine("1 does not equal 1");
            //}
            //Console.ReadLine();

            //---------------------

            //string name = "Brett";

            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            //Console.ReadLine();

            //------------Else Statements------------------//
            //string name = "Erik";

            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");
            //}

            //---------Operator !=----------------------//
            //if (1 !=2)
            //{
            //    Console.WriteLine("All is right with the universe");
            //}
            //else 
            //{
            //    Console.WriteLine("We live in a bizzaro world");
            //    Console.ReadLine();
            //}

            //--------Greater Than Operator-------------//
            //int num1 = 12;
            //int num2 = 14;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("The frist number is larger");
            //}
            //else
            //{
            //    Console.WriteLine("The second numner is larger");
            //}

            //----------Lesser Than----------------------//
            //int age 19;
            //if (age < 21)
            //{
            //    Console.WriteLine("No, you may not purchase that bottle of wine");
            //}
            //else
            //{
            //    Console.WriteLine("That will be $23.71");
            //}

            //----------The AND operator-----------------//
            //int num1 = 7;
            //int num2 = 18;
            //int num3 = 12;
            //if (num2 > num1 && num3 < num2)
            //{
            //    Console.WriteLine("The second number is larger than the others.");
            //}

            //int num1 = 7;
            //if (true && true && true && true && num1 == 20)
            //{
            //    Console.WriteLine("Everything was true!");
            //}
            //else
            //{
            //    Console.WriteLine("There was a false somewhere!");
            //}

            //int packageWeight = 50;
            //int packageLength = 25;
            //if (packageWeight > 40 && packageLength > 20)
            //{
            //    Console.WriteLine("The package is too big to ship");
            //}

            //---------OR operator--------------------------//

            //int num1 = 7;

            //if (num1 < 7 || num1 ==12)
            //{
            //    Console.WriteLine("At least one value is true.");
            //}

            //if (num1 == 12 || num1 == 18)
            //{
            //    Console.WriteLine("At least one value is true.");
            //}
            //else
            //{
            //    Console.WriteLine("No value is true");
            //}
            //if (num1 == 12 || num1 ==18 || num1 == 20 || num1 == 7)
            //{
            //    Console.WriteLine("Something is true");
            //}

            //string role = "admin";
            //if (role == "admin" || role == "administrator")
            //{
            //    Console.WriteLine("You may have access to the entire software system");
            //}

            //Ternary Operator 
            int num1 = 7;
            int num2 = 12;

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);

            Console.ReadLine();



        }
       
    }
}
