using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssigment
{    
    class Program
    {
        //Const variable 
        const int myConstVariable = 40;
        static void Main(string[] args)
        { //declaring a variable using var keyword 

            var myVariable = "Hello";

            //Chaining two constructors together.

            myClass myObject = new myClass("Pablo", 40); //two constructors 

            Console.WriteLine("Variable: " + myConstVariable); //const variable from above 
            Console.WriteLine("Variable: " + myConstVariable );
            Console.WriteLine("Name: " + myObject.Name);
            Console.WriteLine("Age: " + myObject.Age); //grabbing from the chaained constructors 

            Console.ReadLine();
        }
    }
}
