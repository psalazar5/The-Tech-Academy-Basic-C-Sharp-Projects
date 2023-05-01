using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee() //created an object of type IQuittable , created a new instance of Employee(E) and assigning it to a variable of IQuittable. 
            { //I am effectively treating the 'Employee' object as if it were an IQuittable object, this is an example of polymorphism bc you can use the 'employee' object as if it were any other object that impliments the IQuittable interface. 
                FirstName = "Sample", // 
                LastName = "Student", // 
            };
            employee.Quit(); //
            Console.ReadLine();
            
        }
    }
}
