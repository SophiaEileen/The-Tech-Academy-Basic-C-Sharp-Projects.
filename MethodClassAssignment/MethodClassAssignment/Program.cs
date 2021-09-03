using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            int myNum2 = 12;

            //instantiate the class
            Method myOp = new Method();

            //Call the method in the class, passing in two numbers.
            myOp.myOperation(myNum, myNum2);

            //Call the method in the class, specifying the parameters by name.
            myOp.myOperation(secondNum: myNum2, firstNum: myNum);
        }
    }
    }
}
