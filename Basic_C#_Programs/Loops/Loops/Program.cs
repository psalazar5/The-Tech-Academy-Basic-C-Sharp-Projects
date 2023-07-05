using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            ////C# switch
            //int year = 4;
            //switch (year)
            //{
            //    case 1:
            //        Console.WriteLine("2000");
            //        break;
            //    case 2:
            //        Console.WriteLine("2001");
            //        break;
            //    case 3:
            //        Console.WriteLine("2002");
            //        break;
            //    case 4:
            //        Console.WriteLine("2003");
            //        break;
            //    case 5:
            //        Console.WriteLine("2004");
            //        break;
            //    case 6:
            //        Console.WriteLine("2005");
            //        break;

            //} ////outputs 2003

            //console.writeline("guess a number.");
            //int number = convert.toint32(console.readline());
            //bool isguessed = number == 12;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            console.writeline("you guessed 62. try again.");
            //            console.writeline("guess a number.");
            //            number = convert.toint32(console.readline());
            //            break;
            //        case 29:
            //            console.writeline("you guessed 29. try again.");
            //            console.writeline("guess a number.");
            //            number = convert.toint32(console.readline());
            //            break;
            //        case 55:
            //            console.writeline("you guessed 55. try again.");
            //            console.writeline("guess a number.");
            //            number = convert.toint32(console.readline());
            //            break;
            //        case 12:
            //            console.writeline("you have guessed 12. that is correct.");
            //            isguessed = true;
            //            break;
            //        default:
            //            console.writeline("you are wrong.");
            //            console.writeline("guess a number.");
            //            number = convert.toint32(console.readline());
            //            break;
            //    }
            //}
            //while (!isguessed);


            //while(!isguessed)  ////This is just the while loop alone, when u enter 12 and its correct it wont display you are correct or anything just sits there 
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You have guessed 12. That is correct.");
            //            isguessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //---------------------- CONSOLE APP SUBMISSION ASSIGNMENT ------------------------------//

            //Console app that does boolean comparison using while and a dowhile loop. //This below will be a demonstration of a while loop itself, after im going to do a "do while" statement

            //Console.WriteLine("Pick my favorite number:");
            //int mynumber = Convert.ToInt32(Console.ReadLine());
            //bool myfavorite = mynumber == 25;

            //while (!myfavorite)
            //{
            //    switch (mynumber)
            //    {
            //        case 55:
            //            Console.WriteLine("Number 55 is not my number. Try again");
            //            Console.WriteLine("Pick my favorite number:");
            //            mynumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 44:
            //            Console.WriteLine("44 is not my number. Try again.");
            //            Console.WriteLine("Pick my favorite number:");
            //            mynumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("12 is not my number. Try again");
            //            Console.WriteLine("Pick my favorite number:");
            //            mynumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 25:
            //            Console.WriteLine("You guessed my favorite! Awesome!");
            //            myfavorite = true;
            //            break;
            //        default:
            //            Console.WriteLine("Wrong number!");
            //            Console.WriteLine("Pick my favorite number:");
            //            mynumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //Heres the do while statement now on my number, meaning when i enter the right answer to begin with it'll give me my response that i need. While loop would be more common than the do while 

            Console.WriteLine("Pick my favorite number:");
            int mynumber = Convert.ToInt32(Console.ReadLine());
            bool myfavorite = mynumber == 25;

            do
            {
                switch (mynumber)
                {
                    case 55:
                        Console.WriteLine("Number 55 is not my number. Try again");
                        Console.WriteLine("Pick my favorite number:");
                        mynumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 44:
                        Console.WriteLine("44 is not my number. Try again.");
                        Console.WriteLine("Pick my favorite number:");
                        mynumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("12 is not my number. Try again");
                        Console.WriteLine("Pick my favorite number:");
                        mynumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("You guessed my favorite! Awesome!");
                        myfavorite = true;
                        break; 

                    default:
                        Console.WriteLine("Wrong number!");
                        Console.WriteLine("Pick my favorite number:");
                        mynumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!myfavorite);
                

            Console.ReadLine();

        }
    }
}
