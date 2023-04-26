using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Car
    {
        public int myMathOperation(int number)  //this method takes an integer does math and returns it  
        {
             return(number * 20);
        }
        public int myMathOperation(decimal number) //this method takes in a decimal does math and returns an integer 
        {
            return (Convert.ToInt32(number) + 20);
        }
        public int myMathOperation(string number) //this method takes in a string an does math 
        {
            return (Convert.ToInt32(number) - 20);
        }
    }
}
