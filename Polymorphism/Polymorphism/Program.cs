using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();
            person1.FirstName = "Sample";
            person1.LastName = "Student";
            person1.SayName();

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            person1.Quit();

            Console.ReadLine();
        }
    }
}
