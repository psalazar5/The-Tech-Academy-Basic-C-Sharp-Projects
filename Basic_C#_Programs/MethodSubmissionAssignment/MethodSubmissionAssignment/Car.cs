using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Car
    {
        public int myMethod(int num1, int num2 = 10) //num 2 = 10 means optional parameter 
        {
            return num1 + num2;
        }
    }
}
