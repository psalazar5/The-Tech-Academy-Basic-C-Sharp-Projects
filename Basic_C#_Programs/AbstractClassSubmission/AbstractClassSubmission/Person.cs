using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void sayName(); //method to say the persons name , defines the class
    }

   
}
