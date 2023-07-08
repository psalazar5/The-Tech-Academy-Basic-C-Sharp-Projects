using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        { //asking user to input their age 
            Console.WriteLine("What is your age? I am going to guess your birth year!");
            string input = Console.ReadLine();

            try //now display users year they were born 
            {
                int age = int.Parse(input); //parse is another way of Convert.ToInt32

                //Display the year the user was born 

                int currentYear = DateTime.Now.Year; //int current year by DateTime.Now.Year (CurrentYear)
                int birthYear = currentYear - age; // int birthYear would we're doing currentYear - age to get their birth year.
                Console.WriteLine($"You were born in {birthYear}"); //displays birthyear from the currentYear - age = birthYear.

            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input: Please enter a number.");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Invalid age: Please enter a positive number.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
