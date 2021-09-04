using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.OverloadMethodAssignment
{
    class StaticMathOp
    {
        //using out parameter 
        public void MethodOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 1;
        }
    }
}
