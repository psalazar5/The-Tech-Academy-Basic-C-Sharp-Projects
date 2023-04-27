using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionVoidAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Please enter a number to divide by two: ");
            int numberPicked = Convert.ToInt32(Console.ReadLine());

            //Call the mymethod from car class and execute the number one as number picked
            car.myMethod(numberPicked);

            //Creating a method with output parameters, call over load myMethod on the car object with the users input(numbersPicked)
            //created an ouput variable called output 

            //int output;
            //car.myMethod(numberPicked, out output);

            ////this outputs the result of the overloaded myMethod to console
            //Console.WriteLine("The output is: " + output );

            Console.ReadLine();


        }
    }
}
