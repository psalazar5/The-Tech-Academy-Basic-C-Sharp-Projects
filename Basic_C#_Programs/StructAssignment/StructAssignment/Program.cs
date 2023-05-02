using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance of the number struct and assign an amount to it 
            Number num = new Number { Amount = 123.45m };

            //print the amount of the number object to the console.
            Console.WriteLine("The amount is: " + num.Amount);
        }
    }
}
