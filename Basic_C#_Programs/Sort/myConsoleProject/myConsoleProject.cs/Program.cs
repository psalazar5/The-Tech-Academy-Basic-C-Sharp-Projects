using System;

namespace myConsoleProject.cs

{
    class Program
    {
        static void Main() //This data type simply refers to a group of strings bundled together and given a name.

        {
            Console.WriteLine("Welcome to Acme Accounting Systems\nRemember, we're \"accounting\" on you!");
        string name = Console.ReadLine(); //another method of the System namespace, similar to Console.WriteLine(). But instead of printing to the screen, it takes input from the screen.
        Console.WriteLine("Hello, " + name + "!");
        Console.Read();
        }
    }
}



