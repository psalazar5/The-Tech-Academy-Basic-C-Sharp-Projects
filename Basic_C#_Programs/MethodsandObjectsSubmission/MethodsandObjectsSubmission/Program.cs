using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    public class Program
    {
        static void Main(string[] args)
        { //defined these two properties with data type string 
            Person person1 = new Person(); //object created person1 
            person1.FirstName = "Pablo"; //named pablo 
            person1.LastName = "Salazar";

            Person person2 = new Person(); // created object person2 
            person2.FirstName = "Jane";
            person2.LastName = "Smith";

            //Instantiate and initialize an Employee object with a first name of " sample " last name of "student"
            Employee employee1 = new Employee(); //object 
            employee1.FirstName = "Sample"; //assigned employee1(object) to the FirstName Sample 
            employee1.LastName = "Student";
            employee1.Id = 12345; //assigned Id to the employee 

            //Call the SayName method on the employee object to write its fullname to the console.
            employee1.SayName(); //Here it calls from Person class the method called SayName

            //Just additional calling methods 
            person1.SayName(); //additional method to call in person1's name 
            employee1.personID(); //additional practice for employee1' ID to be displayed 
            Console.ReadLine();
        }
    }
}
