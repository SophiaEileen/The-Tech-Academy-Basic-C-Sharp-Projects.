using System;

namespace OperatorsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee();
            //employee1.firstName = "Sample";
            //employee1.lastName = "Student";
            //employee1.SayName();
            //Console.ReadLine();
            //employee1.Quit();
            //Console.WriteLine(employee1.firstName + "... " + employee1.lastName);
            //Console.ReadLine();

            Employee employee2 = new Employee();
            employee2.firstName = "Sophia";
            employee2.lastName = "Eileen";
            employee2.employeeID = 8956;

            Employee employee3 = new Employee();
            employee3.firstName = "Patrick";
            employee3.lastName = "Howle";
            employee3.employeeID = 8956;

            bool doesEqual = employee2 == employee3; //overloaded operater method. 

            Console.ReadLine();
        }
    }
}