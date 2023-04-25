using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------------//

            //List<string> newlist = new List<string>();
            //newlist.Add("Pablo");
            //newlist.Add("Salazar");


            //List<int> List = new List<int>();
            //List.Add(4);
            //List.Add(10);
            //List.Remove(10); //removes 10 
            //byte[] bytearray = new byte[5000];

            //Console.WriteLine(newlist[0]);
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------------//
            //------array of strings and ask the user to select an index of the array to display on screen--------------//

            string[] nameArray = new string[] { "Pablo", "Justin", "Joel" }; //here is an array of strings created from 0-2 index 
            Console.WriteLine("Pick an index and a name will represent: ");
            int forname = Convert.ToInt32(Console.ReadLine());
            bool isnamefalseortrue = false;

            do
            {
                if (forname < 0 || forname > nameArray.Length - 1) // if forname int is less than 0 or forname in is more than the array length do this. else give the correct answer 
                {
                    Console.WriteLine("Please pick a number between 0-2:");
                    forname = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(nameArray[forname]);
                    isnamefalseortrue = true;

                }
            }
            while (!isnamefalseortrue);
            
            

            int[] numberArray = new int[] { 20, 40, 60, 80, 100 }; //created array of integers 

            Console.WriteLine("Now enter a index number to recieve a number from the array from 0 - 4:");
            int indexnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberArray[indexnumber]); //displays numberarray and the index number the user has inputted.

            if (indexnumber > 4) //saying is user picks a number after 4 that there is no number available
            {
                Console.WriteLine("That number does not exist in the array, sorry.");
            }


            List<string> foodList = new List<string>(); //Here the list of strings is created indicating food strings from index 0-3
            foodList.Add("Ice cream");
            foodList.Add("Pizza");
            foodList.Add("Cookies");

            Console.WriteLine("Pick an index number from my Food List :");
            int foodint = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(foodList[foodint]); //// this will give an error because we're putting a number out of the range.

            bool foodintoutofrange = false;

            do
            {
                if (foodint < 0 || foodint > foodList.Count - 1) 
                {
                    Console.WriteLine("Please pick a number between 0-2:");
                    foodint = Convert.ToInt32(Console.ReadLine());
                } else
                {
                    Console.WriteLine(foodList[foodint]);
                    foodintoutofrange = true;
                }
             
             
            }
            while (!foodintoutofrange);           


            Console.ReadLine();



        }
    }
}
