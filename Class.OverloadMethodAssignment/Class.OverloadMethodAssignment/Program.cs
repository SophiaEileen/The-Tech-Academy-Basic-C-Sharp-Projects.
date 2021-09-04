using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.OverloadMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate MathOp class
            MathOp myNumObj = new MathOp();

            //user input is divided by 2 and output is displayed
            Console.WriteLine("Input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            myNumObj.myMethodOp(userNum);

            //static overload method with an out parameter 
            int myNum = 1;
            Console.WriteLine("Your number plus my number is: " + MathOp.MethodOp(userNum, myNum));
            myNumObj.MethodOut(userNum, out int extraNum);
            Console.WriteLine("That number plus one is: " + extraNum);

            Console.ReadLine();
        }
    }
}
