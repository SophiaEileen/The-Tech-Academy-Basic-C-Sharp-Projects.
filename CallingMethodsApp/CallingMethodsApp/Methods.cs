using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsApp
{
    public class Methods
    {
        public void MethodsOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        public static int MethodsOp(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }

        //using out parameter
        public void MethodsOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 1;
        }
    }
}
