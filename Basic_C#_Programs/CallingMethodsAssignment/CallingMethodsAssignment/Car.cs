using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Car
    {
        //This method multiplies the input by 2 and returns result
        public int myMethod(int num)
        {
            return num * 2;
        }

        //
        public int myDivision(int num1)
        {
            return num1 / 5;
        }

        public int addition(int num2)
        {
            if(num2 == 0)
            {
                return 100;
            }
            else
            {
                return num2 + 100;
            }
        }

    }
}
