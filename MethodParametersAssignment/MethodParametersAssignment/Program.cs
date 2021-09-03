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
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input a second integer (optional): ");
            bool userNum2IsValid = int.TryParse(Console.ReadLine(), out int userNum2);

            MathOp myNumObj = new MathOp();

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
