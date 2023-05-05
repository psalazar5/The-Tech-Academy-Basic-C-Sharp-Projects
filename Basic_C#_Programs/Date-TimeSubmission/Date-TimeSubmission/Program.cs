using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_TimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        { //This prints current date time 

            DateTime now = DateTime.Now;
            Console.WriteLine("Current date and time: " + now);

            //asking user for a number 
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int x = int.Parse(number);

            //print time in x hours 

            DateTime futureTime = now.AddHours(x); //takes in from parsing time 
            Console.WriteLine("Time in " + x + " hours: " + futureTime);
            Console.ReadLine();
        }
    }
}
