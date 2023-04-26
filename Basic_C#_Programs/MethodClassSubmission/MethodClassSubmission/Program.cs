using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); //instantiation

            cat.myMethod(10, 20);

            cat.myMethod(number1: 10, number2: 20); //specifying the parameters by name 

            Console.ReadLine();
        }
    }
}
