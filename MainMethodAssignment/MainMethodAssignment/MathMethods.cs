using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethods
    {
        //will receive int parameter and do an addition operation on it and return as an integer.
        public int myOpperation(int userNum)
        {
            int myNum = userNum;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        //Second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
        public int myOpperation(decimal userNum)
        {
            int myNum = Convert.ToInt32(userNum);
            int myNumMult = myNum * 10;
            return myNumMult;
        }

        //will recieve a string parameter, convert to integer then divide by 10 then return an integer.
        public int myOpperation(string userNum)
        {
            int myNum = Convert.ToInt32(userNum);
            int myNumDivide = myNum / 10;
            return myNumDivide;
        }
    }
}
