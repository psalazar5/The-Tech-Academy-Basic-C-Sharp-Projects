using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your fav num?");
            //int favnum = Convert.ToInt32(Console.ReadLine());

            //string results = favnum == 12 ? "You have a fav num" : "You do not have a fav num";
            //Console.WriteLine(results);



            //int roomtemperature = 70;

            //Console.WriteLine("Hi, what is your name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + " what is the temperature where you are?");
            //int currenttemperature = Convert.ToInt32(Console.ReadLine());

            //if (currenttemperature == roomtemperature)
            //{
            //    Console.Write("It is exactly room temp");
            //}
            //else if (currenttemperature > roomtemperature)
            //{
            //    Console.Write("it is warmer than room temp");
            //}
            //else if (roomtemperature > currenttemperature)
            //{
            //    Console.WriteLine("It is colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhh... something went wrong");
            //}




            //int currenttemperature = 80;
            //int roomtemperature = 70;


            ////Terinary operator
            //string comparisonresult = currenttemperature == roomtemperature ? "It is exactly room temp" : "It is not room temp";
            //Console.WriteLine(comparisonresult);


            //if (currenttemperature == roomtemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currenttemperature > roomtemperature)
            //{
            //    Console.WriteLine("It is warmer than room temp. ");
            //}
            //else if (roomtemperature > currenttemperature)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp");
            //}
            //else
            //{
            //    Console.WriteLine("This is not exactly room temperature");
            //}


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight:");
            int packageweight = Convert.ToInt32(Console.ReadLine());
            if (packageweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else 
            {
                Console.WriteLine("Please enter package width: ");
                int packagewidth = Convert.ToInt32(Console.ReadLine()); //enters width and converts

                Console.WriteLine("Please enter package height : "); //enters height and converts
                int packageheight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length : "); //enters length and converts
                int packagelength = Convert.ToInt32(Console.ReadLine());

                int packagedimensions = packagewidth + packageheight + packagelength; //makes an int to add all dimensions
                
                if (packagedimensions > 50) //grabs those dimensions and makes statement if these dimensions are larger than 50 run this if 
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                //else if (packagedimensions == 45)
                //{
                //    Console.WriteLine("Goodluck");
                //    Console.ReadLine();
                //    Environment.Exit(0);
                //}
                else //if they are not larger give them this quote i created below and a thankyou 
                {
                    int quote = (packageheight * packagewidth * packagelength) * packageweight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThankyou");
                    
                }
            }
           

            
            Console.ReadLine();

        }
    }
}
