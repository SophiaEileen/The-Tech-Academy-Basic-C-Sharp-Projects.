using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();//full employee list

            employees.Add(new Employees { FName = "William", LName = "Shatner", Id = 3 });
            employees.Add(new Employees { FName = "Leonard", LName = "Nimoy", Id = 1 });
            employees.Add(new Employees { FName = "Nichelle", LName = "Nichols", Id = 1774 });
            employees.Add(new Employees { FName = "DeForest", LName = "Kelley", Id = 1774 });
            employees.Add(new Employees { FName = "James", LName = "Doohan", Id = 5862 });
            employees.Add(new Employees { FName = "Joe", LName = "Koenig", Id = 8952 });
            employees.Add(new Employees { FName = "Jeffrey", LName = "Hunter", Id = 2 });
            employees.Add(new Employees { FName = "George", LName = "Takei", Id = 1693 });
            employees.Add(new Employees { FName = "Marianna", LName = "Hill", Id = 1984 });
            employees.Add(new Employees { FName = "Joe", LName = "Campbelle", Id = 3141 });

            List<Employees> theJoes = new List<Employees>();//new list that all of the joes go into.

            //loop that adds any employe whos first name is joe to a new list
            foreach (Employees employee in employees)
            {
                if (employee.FName == "Joe")
                    theJoes.Add(employee);
            }

            //Lambda function to find the first name "Joe" in a list.
            List<Employees> theJoesFNameLambda = employees.Where(x => x.FName.Contains("Joe")).ToList();

            //Lambda function to find the Id of all employees over 5.
            List<Employees> theJoesId = employees.Where(x => x.Id > 5).ToList();


            //Code to check for contents of lists
            //foreach (Employees joe in theJoesId)
            //{
            //    Console.WriteLine(joe.FName + " " + joe.LName + " Id: " + joe.Id);
            //}
        }
        class Employees
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Id { get; set; }
        }

    }
}
