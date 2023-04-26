using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //instantiation 
            
            Console.WriteLine(car.myMathOperation(8)); //int method
            Console.WriteLine(car.myMathOperation(2.5m)); //decimal method 
            Console.WriteLine(car.myMathOperation("2")); //string method
        }
    }
}
