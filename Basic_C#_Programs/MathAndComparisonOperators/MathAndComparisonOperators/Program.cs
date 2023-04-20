using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //Console.WriteLine(combined); //Console.WriteLine("Five plus ten = " + total.ToString());
            //Console.ReadLine();

            ////subtraction
            //int difference = 10 - 5;
            //Console.WriteLine("ten minus 5  = " + difference.ToString());
            //Console.ReadLine();

            //Multiplication 
            //int product = 43 * 49;
            //Console.WriteLine(product);
            //Console.ReadLine();

            ////Division
            //int quotient = 294 / 2;
            //Console.WriteLine(quotient);
            //Console.ReadLine();
            ////double quotient = 100.0 / 17.0; 
            ////Console.WriteLine(quotient);
            ////Console.ReadLine();

            ////Remainder modulus operator 
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool TrueorFalse = 12 > 5;
            //Console.WriteLine(TrueorFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //Console.WriteLine("Please enter a number");
            //int yourNumber = Convert.ToInt32(Console.ReadLine()); //converted code in one line instead of two 
            //Console.WriteLine(yourNumber * 50);


            //Console.WriteLine("Please enter another number");
            //int anotherNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(anotherNumber + 25);

            //Console.WriteLine("Another");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number2 / 12.5);

            //Console.WriteLine("Again"); //just displaying what needs to be said next 
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number3 <= 50); //created a bool statement true or false 

            //Console.WriteLine("and again...");
            //int number4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(number4 % 7); //used modulus operator


            //Console.ReadLine(); //read line is at the end so that it doesnt get stuck on the command prompt 


            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate?");
            int hourlyrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursworked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2\nHourly Rate?");
            int hourlyrate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursworked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(hourlyrate * hoursworked);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(hourlyrate2 * hoursworked2);

            Console.WriteLine("Does person 1 make more money than Person 2?");
            int Person1 = hourlyrate * hoursworked;
            int Person2 = hourlyrate2 * hoursworked2;
            Console.WriteLine(Person1 >= Person2);

            Console.ReadLine();

        }
    }
}
