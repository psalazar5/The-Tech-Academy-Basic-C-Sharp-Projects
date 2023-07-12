using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trueOrnot = false;

            do
            {
                try
                {
                    Console.WriteLine("Pick a number");
                    int numberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pick a second number");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dividing the two... ");
                    int numberThree = numberOne / numberTwo;
                    Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree); //concatenated three strings into saying number one / number two = numberthree
                    Console.ReadLine();
                    trueOrnot = true;
                }
                catch (FormatException) // If the info above doesnt execute and there should be an error here would be the error. (Format exception)
                {
                    Console.WriteLine("Please type a whole number.");

                }
                catch (DivideByZeroException) //if divided by 0...
                {
                    Console.WriteLine("Please dont divide by zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Click Enter to continue ");
                    Console.ReadLine();
                }
            } while (!trueOrnot);
            Console.WriteLine("Emerged from try/catch block click enter to exit:");

            Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------------//

            //List<int> listNumbers = new List<int>() { 0, 3, 6, 8 };
            //foreach (int numbers in listNumbers) //here I listed all numbers from the list on the console app
            //{
            //    Console.WriteLine(numbers); //wrote all nubers out 
            //}
            //Console.WriteLine("Pick a number of your own to divide all the numbers in the list above:"); //told user to pick a number of their own 
            //try //meaning try 
            //{
            //    int numberPicked = Convert.ToInt32(Console.ReadLine()); // users input converted 
            //    foreach (int number in listNumbers) //for each number in the list divide by watever the user inputed: 
            //    {
            //        Console.WriteLine(number / numberPicked); //number inside the lists divided by numbers picked from the int above. 
            //    }
            //}
            //catch (FormatException) //if any errors happen catch these blocks
            //{
            //    Console.WriteLine("Please enter a whole number: ");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Please dont divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Click Enter");
            //}

            //-----------------------------------------------------------------------------------------------------------------//

            Console.ReadLine();
        }

    }
}
