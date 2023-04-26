using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car(); // instantiation
            Console.WriteLine("Please enter one number:"); //asks the user to input a number
            int num1 = Convert.ToInt32(Console.ReadLine());
            try //then tries to enter another number and if they dont it goes into the catch 
            {
                Console.WriteLine("Please enter another number if you want too: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(car.myMethod(num1, num2)); //grabs the car my method from car class and grabs num1 and num2 optionally 
            }
            catch //if try fails then car my method will take in only num1 and optionally adds 10 to it (num2)
            {
                Console.WriteLine(car.myMethod(num1)); //calls in the method in the class, if no one puts in a number (10)
            }

            Console.ReadLine();


        }
    }
}
