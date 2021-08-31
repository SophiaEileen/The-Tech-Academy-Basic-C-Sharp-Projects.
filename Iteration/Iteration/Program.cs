using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //----array of test scores--------------------------------------------
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            ////irritrate over array -log passing grades to console which is 85
            //// For loop (three conditions) 

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //---------string list-------------------------------------------------

            //string[] names = { "Sophia", "Patrick", "Hazel", "Wyatt" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    //if (names [i] == "Sophia")
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}
            //Console.ReadLine();

            //------------INT List-------------------------------------------------
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            ////iterate over list - log passing scores to console > 85 
            ////Useing Foreach loop 

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test scrore: " + score);
            //    }
            //}
            //Console.ReadLine();

            //----------String List----------------------------------------------

            //List<string> names = new List<string>() { "Sophia", "Patrick", "Hazel", "Wyatt" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //---------INT string with foreach -------------

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if  (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();

        }
    }
}
