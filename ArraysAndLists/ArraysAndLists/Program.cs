using System;
using System.Collections.Generic;


class Program
{
    static void Main()
     {
        //-----------Methods in Lists-----------------------------
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10)


        Console.WriteLine(intList[0]);
        Console.ReadLine();

        // use byte array to store very large quantity 
        //byte[] byteArray = new byte[5050];

        //------Initilize a new instance of an array/object--
        //------Use array when you have fixed quantity-------

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;
        ////----------------------------------------------

        ////---------Same way to do the above but more concise
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////---------to change index 5--------------------
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
     }
}

