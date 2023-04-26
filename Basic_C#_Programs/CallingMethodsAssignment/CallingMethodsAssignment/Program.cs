using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("Pick a number you want to use for math operations:"); //asking user to input digits
            int numberPicked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(car.addition(numberPicked)); // Called in method and inside the method parameter called what the user inputted 
            Console.WriteLine(car.myDivision(numberPicked));
            Console.WriteLine(car.myMethod(numberPicked));
        }
    }
}
