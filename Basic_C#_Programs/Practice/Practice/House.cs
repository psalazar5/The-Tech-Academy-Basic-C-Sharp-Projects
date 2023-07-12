using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    //Writing a house class the year it was built and the size to initialize object 
    public class House
    {
        //filled the constructor arguments into properties and made sure the object held the data using the debugger
        public int yearBuilt { get; set; }//instead of private int yearBuilt;
        public string size { get; set; } //instead of private string size;

        public House(int yearBuilt, string size)
        {
            this.yearBuilt = yearBuilt;
            this.size = size;
        }

        public void DisplayDetails(string houseName)
        {
            Console.WriteLine($"{houseName} was built in: {yearBuilt}");
            Console.WriteLine($"The size of {houseName} is : {size}");
            Console.WriteLine($"Can the house be sold within 15 years of owner ship? {CanBeSold()}");
        }
         private int HowOld()
         {
             int currentYear = DateTime.Now.Year;
             return currentYear - yearBuilt;
         }
        public bool CanBeSold()
        {
            int age = HowOld();
            return age > 15; 
        }

    }
}
