using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimesional Array of strings. Ask user to input some text. Create a loop that goes through each string in the Array, 
            //adding the user's text to the string. Then create a loop that prints off each string in the Array on a separate line.

            string[] myStringArray = { "One", "dimensional", "array", "of", "strings" };

            Console.WriteLine("Please input a small amount of text: ");
            string userText = Console.ReadLine();

            for (int i = 0; i < myStringArray.Length; i++)
            {
                string addUserString = myStringArray[i] + " " + userText;
                Console.WriteLine(addUserString + " " + "\n");
            }
            Console.ReadLine();

            //-------Create an infinite loop------------
            //string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            //for( ; ; )
            //{
            //    Console.WriteLine("Infinite.");
            //}

            //-------Fix an infinite loop----------------
            string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            for (int j = 0; j < infinite.Length; j++)
            {
                Console.WriteLine(infinite[j]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.
            int[] myLoop = { 1, 2, 3, 4, 5 };
            for (int k = 0; k < myLoop.Length; k++)
            {
                Console.WriteLine(myLoop[k]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine(myLoop[l]);
            }
            Console.ReadLine();


            //Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List. 
            //Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            

            List<string> myWords = new List<string>();
            myWords.Add("The");
            myWords.Add("only");
            myWords.Add("true");
            myWords.Add("wisdom");
            myWords.Add("is");
            myWords.Add("in");
            myWords.Add("knowing");
            myWords.Add("you");
            myWords.Add("know");
            myWords.Add("nothing.");

            Console.WriteLine("Type a word from this sentance to find what index that word is contained at. \"The only true wisdom is in knowing you know nothing.\"");
            string userWord = Console.ReadLine();

            //----Loop that will look for a word typed by the user in the List------------------------------------------
            foreach (string word in myWords)
            {
                if (word == userWord)
                {
                    Console.WriteLine("The index of " + "\"" + userWord + "\"" + " is: " + myWords.IndexOf(word));
                    break;
                }
            }

            //catches if the user entered a word that is not in the sentance.
            if (myWords.Contains(userWord) == false)
            {
                Console.WriteLine("You did not enter a word from the sentance.");
            }
            Console.ReadLine();


            //Create a List of strings that has at least two identical strings in the List.
            //Ask the user to select text to search for in the List. Create a loop that iterates through the loop and then
            //displays the indices of the array that contain matching text on the screen.

            List<string> mySong = new List<string>();
            List<int> repeatLyrics = new List<int>();

            mySong.Add("To");
            mySong.Add("see");
            mySong.Add("your");
            mySong.Add("shoes");
            mySong.Add("and");
            mySong.Add("your");
            mySong.Add("spirits");
            mySong.Add("rise");

            Console.WriteLine("Please input a word from the below lyrics: ");
            Console.WriteLine("To see your shoes and your spirits rise");
            string userWordLyric = Console.ReadLine();

            //search List mySong to match the users word with a word(s) in the lyrics then print the index of those words.
            for (int i = 0; i < mySong.Count; i++)
            {
                bool songFound = false;
                if (userWordLyric == mySong[i])
                {
                    songFound = true;
                    Console.WriteLine("The index of the lyric is: " + i);
                }
            }

            //if user word is not in the List display error            
            if (mySong.Contains(userWordLyric) == false)
            {
                Console.WriteLine("The word you typed is not in the lyrics.");
            }
            Console.ReadLine();

            //11. Create a list of strings that has at least two identical strings in the List. Create a foreach loop that evaluates
            //each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> nameList = new List<string>();
            List<string> nameRepeat = new List<string>();

            nameList.Add("Sophia");
            nameList.Add("Patrick");
            nameList.Add("Hazel");
            nameList.Add("Alice");
            nameList.Add("Wyatt");
            nameList.Add("Sophia");

            // loop adds a name to the nameRepeat List and then checks to see if the name is already in the list
            foreach (string name in nameList)
            {
                if (nameRepeat.Contains(name))
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("The name " + name + " has already appeared in the list!");
                }
                else
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("This name " + name + " has not appeared in the list yet!");

                }
            }
            Console.ReadLine();
        }
    }
}
