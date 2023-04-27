using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    public class Employee : Person // Define a class called employee that inherits from the Person class 
    {
        public int Id { get; set; } //Add an additional property to the Employee class called ID with a data type of int 

        public void personID() //I made an additional method for the persons Id for practice 
        {
            Console.WriteLine($"Persons Id: {Id}");
        }
    }
}
