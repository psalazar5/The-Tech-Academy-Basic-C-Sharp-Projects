using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Employee
    {
        public int Id { get; set; } //defined properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overloaded the == operator to compare the employees based on ID 
        public static bool operator ==(Employee emp1, Employee emp2)
        { 
            //if(ReferenceEquals(emp1, emp2)) //check the two objects are the same instance with the reference equals. Reference equality means that two object references refer to the same underlying object.
            //{
            //    return true;
            //}
            //if(emp1 is null || emp2 is null) // checks if either employee object are null
            //{
            //    return false;
            //}
            return emp1.Id == emp2.Id; //compares the Id property of two employee objects 
        }
        //Overload the != operator to negate the result of ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            //returns the negation of the == operator result
            //return !(emp1 == emp2);
            return emp1.Id != emp2.Id;
        }
    }
}
