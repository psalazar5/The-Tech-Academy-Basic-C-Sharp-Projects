using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)

        { //created two employees objects and assigned values to these properties
          //

            Employee emp1 = new Employee() { Id = 1, FirstName = "Joe", LastName = "Bar" };
            Employee emp2 = new Employee() { Id = 1, FirstName = "Tim", LastName = "Doe" };

            if(emp1 == emp2) //compared the two employees using the overload == operator 
            {
                Console.WriteLine("These employees are identical ");
            }
            else
            {
                Console.WriteLine("These employees are not identical");
            }

            Console.WriteLine(emp1 == emp2);

            Console.WriteLine(emp1 != emp2);


            //Comparing again the objects being overloaded 
            Console.WriteLine($"Emp1 and emp 2 are {(emp1 == emp2 ? "equal" : "not equal")}.");
            Console.ReadLine();
        }
    }
}
