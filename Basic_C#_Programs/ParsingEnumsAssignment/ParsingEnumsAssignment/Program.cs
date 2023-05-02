using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {//Prompt user to enter current days of the week 
            try
            { 
                Console.WriteLine("PLease enter a current day of the week: ");
                string userInput = Console.ReadLine();
                //currentDay is the variable created to the Enum just created.
                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput, true); //typeof parameter or name of the type. It does not contain variable. Not allowed to overload typeof operator
                //parse thru the dayofweek enum entered the user input and evaluated it to be true. EnumParse converts user input into instance of the "DaysOfweek". True parameter means in the enum parse tells the method to ignore case when parsing input.
                Console.WriteLine("The current day is: " + currentDay); 

            }
            catch(ArgumentException) //threw an argument exception into catch block to catch any errors
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
        }
    }
}
