using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes int as parameter
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //takes int as parameter (optional)
            Console.WriteLine("Please input a second integer (optional): ");
            bool userNum2IsValid = int.TryParse(Console.ReadLine(), out int userNum2);
            
            //instantiate class
            MathOp myNumObj = new MathOp();

            //if two numbers - will add them otherwise it will return input int. 
            int result = 0;
            if (userNum2IsValid)
            {
                result = myNumObj.AddInts(userNum, userNum2);
            }
            else
            {
                result = myNumObj.AddInts(userNum);
            }


            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}
