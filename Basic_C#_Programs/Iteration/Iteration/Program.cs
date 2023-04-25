using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; ++i)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------//

            //string[] stringNames = { "Pablo", "David", "John", "Ken" };

            //for (int j = 0; j < stringNames.Length; j++)
            //{
            //    Console.WriteLine(stringNames[j]);
            //    //if(stringNames[j] == "Pablo")
            //    //{
            //    //    Console.WriteLine(stringNames[j]);
            //    //}
            //}

            //---------------------------------------------------------------------------------------------------------//

            //List<int> testscores = new List<int>();
            //testscores.Add(98);
            //testscores.Add(99);
            //testscores.Add(81);
            //testscores.Add(72);
            //testscores.Add(70);

            //foreach (int score in testscores)
            //{
            //    Console.WriteLine(score);
            //    //if (score > 85)
            //    //{
            //    //    Console.WriteLine("Passing test score: " + score);
            //    //}
            //}

            //----------------------------------------------------------------------------------------------------------//

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //    //if(name == "Jesse")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}
            //}

            //----------------------------------------------------------------------------------------------------------//

            //List<int> testscores = new List<int>() {98, 99, 12, 74, 23, 99 };
            //List<int> passingscores = new List<int>();

            //foreach(int score in testscores)
            //{
            //    if(score > 85)
            //    {
            //        passingscores.Add(score);
            //    }
            //}

            //Console.WriteLine(passingscores.Count);

            //-----------------------------------------------------------------------------------------------------------//

            //int[] numberArray = { 10, 50, 60, 90 };

            //for(int j = 0; j < numberArray.Length; j++)
            //    if(numberArray[j] > 20)
            //    {
            //        Console.WriteLine("This number is superior too 20: " + numberArray[j]);
            //    }

            //-----------------------------------------------------------------------------------------------------------//

            //List<string> nameoflosers = new List<string>() { "Justin", "Joel", "Urmom" };

            //foreach (string name in nameoflosers)
            //{
            //    if (name == "Justin")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //-----------------------------------------------------------------------------------------------------------//
            //did in one line

            //string[] stringNames = { "Bob", "Luke", "Patrick", "Will" };
            //Console.WriteLine("Input some text: ");
            //string inputText = Console.ReadLine();
            //foreach(string input in stringNames)        
            //{
            //    string outputText = input + " "; // made a string called outputText that takes in 
            //    outputText += inputText;
            //    //Console.WriteLine(string.Concat(input," ", inputText));
            //    Console.WriteLine(outputText);               
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------//

            //string[] stringNames = { "Bob", "Luke", "Patrick", "Will" };
            //Console.WriteLine("Input some text: ");
            //string inputText = Console.ReadLine(); //This is the input text that user inputs 

            ////A loop that iterates through each string in the array and adds the user's text input to the end of each string.

            //for (int i = 0; i < stringNames.Length; i++) //Goes through loop from 0 - end 
            //{
            //    stringNames[i] += " " + inputText; //stringNames[i] meaning goes through the loop and adds space and additional input text from whatever user inputted               
            //}

            ////second loop that prints off each string in the array one at a time.

            //foreach (string input in stringNames) //for each input inside the string names 
            //{
            //    Console.WriteLine(input); //display the input with the i and the additional input text 
            //}
            //Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------//

            //// An infinite loop then fix it 

            //for (int i = 0; i <= 10; i++)  //just added i++ to stop the infinite loop
            //{
            //    Console.WriteLine(i + " Hello "); //just goes from 0 and adds hello to each index up until 10 

            //} 
            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------------//

            //Loop where comparison thats used to determine to continue iterating the loop is a "<" operator

            //List<int> numberList = new List<int>() { 28, 45, 35, 85, 90, 91, 92 };

            //foreach (int number in numberList)
            //    if (number <= 85)
            //    {
            //        Console.WriteLine("These are bad scores: " + number);
            //    }

            ////another loop where the comparison is used to determine whether to contiue iterating the loop is a "<=" operator.

            //foreach (int number in numberList)
            //    if (85 <= number)
            //    {
            //        Console.WriteLine("These are the passing score numbers: " + number);
            //    }
            //------------------------------------------------------------------------------------------------------------------//
            ////Loop where comparison thats used to determine to continue iterating the loop is a "<" operator

            //int x = 12;

            //while (x < 15)
            //{
            //    Console.WriteLine("X is less than 15");
            //    x++;
            //}

            ////Loop where comparison thats used to determine to continue iterating the loop is a "<" operator

            //int a = 15;

            //while(a <= 20)
            //{
            //    Console.WriteLine("a is less than or equal to 20");
            //    a++;
            //}
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------------------//

            //List<string> foodNames = new List<string>() { "Cookies", "Pizza", "Cheeseburger", "French fries" };
            //Console.WriteLine("Pick \"Pizza\", \"Cookies\", \"French fries\" or \"Cheeseburger\"");
            //string foodItemPicked = Console.ReadLine();

            //if (foodNames.Contains(foodItemPicked)) // if foodnames contain the users itemspicked, do the for loop.
            //{
            //    for (int i = 0; i < foodNames.Count; i++) //This iterates through the foodnames list count 
            //    {
            //        if (foodNames[i] == foodItemPicked) // This shows index on the list 
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        } 
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Input is not on the list."); //else if the if statement doesnt work.
            //}           
            //Console.ReadLine();
            //------------------------------------------------------------------------------------------------------------------//

            //List<string> nameList = new List<string>() { "Pablo", "Justin", "Billy", "Pablo" };



            //Console.WriteLine("Pick a name: Pablo, Justin, or Billy");
            //string namePicked = Console.ReadLine();


            //if (nameList.Contains(namePicked))
            //{
            //    for (int i = 0; i < nameList.Count; i++)
            //    {
            //        if(nameList[i] == namePicked)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //} else
            //{
            //    Console.WriteLine("User is not on the list");
            //}
            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------------------//

            List<string> foodNames = new List<string>() { "Ice cream", "Pizza", "Cookies", "Ice cream" };
            List<string> foodNames1 = new List<string>(); //created another list to go through the list that has a duplicate and add into this new list 
                    

                foreach(string food in foodNames)
                {
                if (foodNames1.Contains(food)) //if statement starts at 244 ends at 250 and goes through the list of items. If it sees that there is already a food item inside the list it will display duplicate.
                {
                    Console.WriteLine(food + " is a duplicate"); //checks if there is a duplicate and will input this line of code into the input 
                } else
                {
                    Console.WriteLine(food + " This item is unique."); // 
                    foodNames1.Add(food); // This adds the items into foodnames.1 empty list 
                }
                }
            Console.ReadLine();
        }
    }
}
