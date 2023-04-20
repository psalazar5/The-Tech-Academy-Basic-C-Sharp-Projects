using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?"); //Writeline asking the question 
            //string yourName = Console.ReadLine(); //readline grabs writeline inout that user inserts
            //Console.WriteLine("Your name is: " + yourName); //Consolewriteline in quotation marks and displays string value of users input 
            //Console.ReadLine(); //Executes the readline 

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber); //Casted from string to int hence(convert.toint32)
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //Console.WriteLine("My name is: ");
            //string myName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + myName);
            //Console.ReadLine();

            //diff data types

            //bool isStudying = false; 
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char randomLetter = 'X';
            //char questionMark = '\u2103';

            //decimal moneyInBank = 100.5m;

            //double heightInCentimeters = 211.30202092;

            //float secondsLeft = 2.62f;

            //short temperatureOnMars = -341;

            //string myName = "Jesse";

            ////int to string

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();

            ////Converting boolean 

            //bool isRaining = true;
            //string rainingstatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingstatus);
            //Console.ReadLine();

            //Console.WriteLine("The Tech Academy\n"); //Writeline of the tech academy 
            //Console.WriteLine("Student Daily Report"); //Daily Report Write line 
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine(); //string for the response given 
            //Console.WriteLine("Awesome " + yourName + "!");



            //Console.WriteLine("What course are you on?");
            //string yourCourse = Console.ReadLine(); //readline reads the string user enters 
            //Console.WriteLine("Great!"); //This spits out the consoles response to this answer


            //Console.WriteLine("What page number?");
            //string pageNumber = Console.ReadLine();
            //int urpageNumber = Convert.ToInt32(pageNumber); //converted the string into an int number 
            //Console.Write("Spectacular!\n");
            ////int urpageNumber = convert.ToInt32(console.readline()); this makes it into one line of code instead of 2 

            //Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
            //string Answer = Console.ReadLine();
            //bool yourAnswer = Convert.ToBoolean(Answer);
            //Console.WriteLine("You answered" + Answer + " we will answer back soon.");
            ////bool yourAnswer = convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            //string experiences = Console.ReadLine(); //console readline exams the users response 
            //Console.WriteLine("Thank you for sharing your experience "); //spitting back out my response 


            //Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //string feedback = Console.ReadLine();
            //Console.WriteLine("We will do everything in our power to keep you satisfied.");


            //Console.WriteLine("How many hours did you study today?");
            //string numberHours = Console.ReadLine();
            //int yourHours = Convert.ToInt32(numberHours); //conver string to int 
            //Console.WriteLine("Your hours are our satisfaction, good job on " + yourHours + " hours today, thank you for your answers and an instructor will respond to\nyou shortly. Have a great day!");
            //Console.ReadLine(); //reads line and keeps responses and questions in the commaand 
            ////int yourHours = Convert.ToInt32(Console.ReadLine());
           

            //Addition total 
            int num1 = 1827823; 
            int num2 = 13749284;
            int total = num1 + num2;
            Console.WriteLine(total);

            //Subtraction (difference)
            int num3 = 379283;
            int num4 = 29248;
            int difference = num3 - num4;
            Console.WriteLine(difference);

            //Multiplication(product)
            int num5 = 27739;
            int num6 = 92974;
            int product = num5 * num6;
            Console.WriteLine(product);
            //Or i can do console.writeline(num5 * num6);

            //Division(quotient)
            int num7 = 356288;
            int num8 = 343;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);

            //Math operation on a string 
            string name = "Luke";
            int number = 10;
            Console.WriteLine(name + number);
            Console.ReadLine();
        }
    }
}
