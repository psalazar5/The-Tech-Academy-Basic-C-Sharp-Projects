using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type "string" as its generic parameter, and assign a list of string to its Things property

            Employee<string> emp1 = new Employee<string>();
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";
            emp1.Things.Add("thing1");
            emp1.Things.Add("thing2");
            emp1.Things.Add("thing3");

            //Instantiate an Employee object with type "Int" an its generic parameter, and assign a list of integers to its Things property 
            Employee<int> emp2 = new Employee<int>();
            emp2.Id = 2;
            emp2.FirstName = "Jane";
            emp2.LastName = "Doe";
            emp2.Things.Add(1);
            emp2.Things.Add(2);
            emp2.Things.Add(3);

            //Create a loop that prints all of the Things to the console.
            foreach(string thing in emp1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(int thing in emp2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
