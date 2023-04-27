using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionVoidAssignment
{
    class Car
    {
        //created a void method called myMethod takes an integer parameter 
        //and outputs the result of dividing the parameter by 2 #1
         public void myMethod(int number1) 
        {
            int result = number1 / 2;
            Console.WriteLine(result);
        }

        //created an overload version of myMethod that takes in an integer parameter and an output parameter that will be used to output the result #5 Overload method 
        public void myMethod(int number1, out int result)
        {
            //Divide the number1 parameter by 2 and assign the result to the output parameter
            result = number1 / 2;
        }
    }
}
