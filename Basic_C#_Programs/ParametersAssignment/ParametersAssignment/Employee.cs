using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    public class Employee<T>
    {
        // Define the properties of the Employee class, including a List<T> property called "things"
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> Things { get; set; }

        // Define a constructor that initializes the "things" property with an empty list
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
