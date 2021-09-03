using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate Methods class
            Methods newMethod = new Methods();

            //User number is divided by two and is output within the method
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            newMethod.MethodsOp(userNum);

            //static overload method with an out parameter
            int myNum = 1;
            Console.WriteLine("Your number plus my number is: " + Methods.MethodsOp(userNum, myNum));
            newMethod.MethodsOut(userNum, out int extraNum);

            Console.WriteLine("That number plus one is: " + extraNum);
            Console.ReadLine();
        }
       
    }
}
