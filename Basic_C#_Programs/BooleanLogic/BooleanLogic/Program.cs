using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            ////or 
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            ////==
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);
            //Console.WriteLine(false == true);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);


            ////XOR operator 
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false); //allows only one false and true for it to be true 
            //Console.WriteLine(false ^ false); //only allows 1 to be true! 

            //Console.WriteLine( true && true && false);
            //Console.WriteLine(false && true && false || true);
            //Console.WriteLine(3 > 5 && 5 > 2 && 5 > 10|| 10 > 6);
            //Console.WriteLine(5 > 2 && 4 > 2 || 5 > 10);


            //Console.WriteLine("What is your age?");
            //int yourAge = Convert.ToInt32(Console.ReadLine()); //converted string into into 

            //Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\"");
            //bool dui = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("How many speeding tickets do you have?");
            //int speedingtickets = Convert.ToInt32(Console.ReadLine());


            //bool qualification = (yourAge > 15 && dui == false && speedingtickets < 3); //Asked is your age greater than 15? & do you have a dui (false) == false (means tru) && do you have more than 3 speeding tickets?
            //Console.WriteLine("Qualified? \n" + qualification); //Wrote on console "Qualified" + the bool statement determining if false or true from the values assigned from the user 


            ////if/else statements
            //string name = "Pablo";


            //if (name == "Pablo")
            //{
            //    Console.WriteLine("Your name is Pablo");
            //}
            //else if (name5 == "Brett")
            //{
            //    Console.WriteLine("Your name is not Pablo");
            //}
            //else
            //{
            //    Console.WriteLine("Your name is not Pablo. Your name is not Brett");
            //}


            //string yourname = "Brett";

            //if (yourname == "Brett")
            //{
            //    Console.WriteLine("Your name is Brett.");
            //}
            //else if (yourname == "Pedro")
            //{
            //    Console.WriteLine("Your name is not Brett but hello Pedro.");
            //}


            ////if not statement 
            //string myname = "Jake";
            //if (myname != "Jake")
            //{
            //    Console.WriteLine("Clearly your name is not Jake!");
            //}
            //else if (name == "Pablo")
            //{
            //    Console.WriteLine("Good job Pablo!");
            //}


            ////Lesser than op 
            //int age = 20;
            //if (age < 21)
            //{
            //    Console.WriteLine("You are not old enough to buy the bottle.");
            //}
            //else if (age > 21)
            //{
            //    Console.WriteLine("The bottle will be $25");
            //}

            //int yourage = 21;

            //if (yourage <= 25)
            //{
            //    Console.WriteLine("You are not able to rent the car");
            //}
            //else if (yourage >= 26) //More than or equal to 26
            //{
            //    Console.WriteLine("You are able to rent out the car.");
            //}

            //////And operator 
            //int num1 = 7;
            //if (true && true && true && true && num1 == 20)
            //{
            //    Console.WriteLine("everything was true");
            //}
            //else
            //{
            //    Console.WriteLine("there was a false somewhere ");
            //}


            ////Or operator 
            //int num5 = 7;
            //if (num5 < 20 || num1 == 12) 
            //{
            //    Console.WriteLine("Atleast one value is true.");
            //}
            //if (num5 == 12 || num1 == 18)
            //{
            //    Console.WriteLine("Atleast one value is true.");
            //}
            //else
            //{
            //    Console.WriteLine("No value is true");
            //}
            //if (num5 == 12 || num5 == 18 || num5 == 20 || num5 == 7)
            //{
            //    Console.WriteLine("Something is true");
            //}


            //Ternary operator 
            int number1 = 7;
            int number2 = 12;

            string result = number1 > number2 ? "number 1 is greater than number 2" : "number 1 is not greater than number2";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
