using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{
    public abstract class Person //if anything inherits from this person it has to impliment sayname since its set as abstract. 
    {       //will impliment later (template)
        public string FirstName { get; set; } //Properties 
        public string LastName { get; set; }

        public abstract void sayName(); //method to say the persons name , defines the class
    }

   
}
