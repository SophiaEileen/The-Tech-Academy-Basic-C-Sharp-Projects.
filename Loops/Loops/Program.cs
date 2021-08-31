using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------switch statments, do while loop, and while loop--------
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            
            //do while loop - ahead of while so loop hits at least once 
            do
            {
                //switch statements will revolve around below cases
                switch (number)
                {
                    // For case statements - if case = "number" then writeline.
                    // Break is required to end switch statement 
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guess 55. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            //while loop is executed after do while loop.
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
