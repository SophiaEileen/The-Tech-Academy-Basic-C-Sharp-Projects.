﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.OverloadMethodAssignment
{
    public class MathOp
    {
        //void: division operation
      public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        //static: addition operation
        public static int MethodOp(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }

        //usong out parameter 
        public void MethodOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 1;
        }
    }
}
