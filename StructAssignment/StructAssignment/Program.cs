using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNum = new Number();
            myNum.Amount = 7.7m;
            Console.WriteLine(myNum.Amount);
            Console.ReadLine();
        }
        public struct Number
        {
            public decimal Amount;
        }
    }
}
