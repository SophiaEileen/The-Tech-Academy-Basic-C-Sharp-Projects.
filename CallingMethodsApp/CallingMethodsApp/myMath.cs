using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsApp
{
    public class myMath
    {
        public int AddInts(int userNum, int userNum2 = 0)
        {
            int newUserNum = userNum + userNum2;
            return newUserNum;
        }
    }
}
