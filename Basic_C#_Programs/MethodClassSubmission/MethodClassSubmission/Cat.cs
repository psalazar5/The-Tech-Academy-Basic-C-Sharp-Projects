using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Cat
    {
        //void definition: You use void as the return type of a method (or a local function) to specify that the method doesn't return a value.
        public void myMethod(int number1, int number2) //created a void method
        {
            number1 = (number1 * 10); //number 1 = math operation onto screen
            Console.WriteLine(number2); //displays 2nd int onto screen
        }
    }
}
