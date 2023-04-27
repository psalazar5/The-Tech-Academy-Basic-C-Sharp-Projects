using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsSubmission
{
    public class Person
    { //defining class with two properties First name and Last name 
        public string FirstName { get; set; } //this is a property 
        public string LastName { get; set; }
       
        public void SayName() //Defined a method called SayName that writes the persons full name to the console 
        {
            Console.WriteLine($"name: {FirstName} {LastName}");
           
        }



    }
}
