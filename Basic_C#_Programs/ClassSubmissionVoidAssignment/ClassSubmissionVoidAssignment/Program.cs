using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionVoidAssignment
{
    static class Program //#6 declared class to be static : allows the Main method to be called without having to instantiate an object of the Program class.
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //#2

            Console.WriteLine("Please enter a number to divide by two: ");
            int numberPicked = Convert.ToInt32(Console.ReadLine()); //#3 ask user to enter a number 

            //Call the mymethod from car class and execute the number one as number picked
            car.myMethod(numberPicked); //#3 display the output to the screen , and called the method

            //Creating a method with output parameters, call over load myMethod on the car object with the users input(numbersPicked)
            //created an ouput variable called output #4

            int output;
            car.myMethod(numberPicked, out output);

            //this outputs the result of the overloaded myMethod to console
            Console.WriteLine("The output is: " + output );

            Console.ReadLine();


        }
    }
}
