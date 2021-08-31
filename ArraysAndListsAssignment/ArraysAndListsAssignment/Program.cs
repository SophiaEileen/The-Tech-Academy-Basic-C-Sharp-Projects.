﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional Array of strings and ask user to select an index and then display the string at the index on the screen.
            string[] myArray1 = { "I", "think", "therefore", "I", "Am", "Descartes." };
            Console.WriteLine("Select and index between 0 and 5: ");
            string userSelectStr1 = Console.ReadLine();
            int userSelect1 = Convert.ToInt32(userSelectStr1);


            if (userSelect1 < 6 && userSelect1 > -1)
            {
                Console.WriteLine("The string at index " + userSelect1 + " is: " + myArray1[userSelect1]);
            }
            else
            {
                Console.WriteLine("Index does not exist");
            }
            Console.ReadLine();

            //Create a one-dimensional Array of integers and ask user to select an index and then display the integer at the index on the screen.
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Please select and index between 0 and 8: ");
            string userSelectStr = Console.ReadLine();
            int userSelect = Convert.ToInt32(userSelectStr);

            if (userSelect < 9 && userSelect > -1)
            {
                Console.WriteLine("The string at index " + userSelect + " is: " + myArray[userSelect]);
            }
            else
            {
                Console.WriteLine("Index does not exist");
            }
            Console.ReadLine();

            //Create a List of strings and ask the user to select an index of the list. Display the content at that index.
            List<string> myList = new List<string>();
            myList.Add("To live is to suffer, ");
            myList.Add("to survive is to find ");
            myList.Add("some meaning in the suffering.");

            Console.WriteLine("Select and index between 0 and 2: ");
            string userSelectStr2 = Console.ReadLine();
            int userSelect2 = Convert.ToInt32(userSelectStr2);


            if (userSelect2 < 9 && userSelect2 > -1)
            {
                Console.WriteLine("The string at index " + userSelect2 + " is: " + myList[userSelect2]);
            }
            else
            {
                Console.WriteLine("Index does not exist");
            }
            Console.ReadLine();
        }
    }
}
