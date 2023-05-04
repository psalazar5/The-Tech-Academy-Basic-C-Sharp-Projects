using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        { //prompting user to enter number 
            Console.WriteLine("Hello, pick a number please: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            //opening file in writer mode and writing the user input to it , logging to a text file 
            using (StreamWriter sw = new StreamWriter(@"C:\Users\psala\OneDrive\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\number.txt", true))
            {
                sw.WriteLine(answer);
            }
            //prints the numbers back to user 
            using (StreamReader SR = new StreamReader(@"C:\Users\psala\OneDrive\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\number.txt", true))
            {
                Console.WriteLine("Here is the number you entered: " + SR.ReadToEnd());
            }
            Console.ReadLine();

        }
    }
}
