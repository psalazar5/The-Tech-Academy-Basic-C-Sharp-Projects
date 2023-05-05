using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssigment
{
    class myClass
    { //two props
        public string Name { get; set; }
        public int Age { get; set; }


        //default constructor calls parameterized constructor
        public myClass() : this("idk", 0)
        {

        }

        //Parameterized constructor 
        public myClass(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

    }
}
