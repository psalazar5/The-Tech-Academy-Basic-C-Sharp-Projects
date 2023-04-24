using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name = "Jesse";
            //string quote = "The man said, \\hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\psala"; //@ means everything is part of the string even the backslash otherwise with no @ u need double backslashes.

            //bool trueOrfalse = name.Contains("s"); //asking is the string name has the letter 's' ... Is that true or false on the bool 
            //trueOrfalse = name.EndsWith("s"); //re assigning it here.. this is how you re assign name it the same string and enter its value onces again.. Good when parsing files.

            //int length = name.Length; //Property of a string.. grabbing the length of the string called 'name' up above
            //name = name.ToUpper(); //converts everything to upper case within name
            //name = name.ToLower(); //converts everything to lower case within name

            ////inmutable string means once created you cannot change them, allocated to memory.


            //StringBuilder urmom = new StringBuilder();

            //urmom.Append("Urmom");

            string line1 = "Pablo is "; //created 3 strings here to concatenate later 
            string line2 = "an awesome person who";
            string line3 = " loves to workout and talk with friends.";

            line1 = line1.ToUpper();

            StringBuilder sp = new StringBuilder(); //string builder to create a sentence at a time , basically concatenated here with 3 append/appendlines
            sp.Append(line1); 
            sp.Append(line2); 
            sp.AppendLine(line3); //appendline right after append will still be in the same line but another appendline right after the first appendline will start on a brand new line.

            Console.WriteLine(sp);
            
            Console.ReadLine();

        }
    }
}
