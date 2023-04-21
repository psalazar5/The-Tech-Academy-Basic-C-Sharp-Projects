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

            //console.writeline(true && true && true || false);
            //Console.WriteLine(false && true && true || false || false);


            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine()); //converted string into into 

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingtickets = Convert.ToInt32(Console.ReadLine());

            
            bool qualification = (yourAge > 15 && dui == false && speedingtickets < 3); //Asked is your age greater than 15? & do you have a dui (false) == false (means tru) && do you have more than 3 speeding tickets?
            Console.WriteLine("Qualified? \n" + qualification); //Wrote on console "Qualified" + the bool statement determining if false or true from the values assigned from the user 


            Console.ReadLine();
        }
    }
}
