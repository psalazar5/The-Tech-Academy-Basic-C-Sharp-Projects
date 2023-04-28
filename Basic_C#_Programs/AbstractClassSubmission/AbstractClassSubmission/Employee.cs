using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    class Employee: Person //inherits from the person class 
    {
        public override void sayName() //public overrided the sayname method 
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        } 
    }
}
