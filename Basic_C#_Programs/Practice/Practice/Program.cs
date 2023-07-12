using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("House 1 : ");
            Console.WriteLine("Enter the year the house was built: ");

            int yearBuilt1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of the house: ");
            string size1 = Console.ReadLine();

            House house = new House(yearBuilt1, size1);

            Console.WriteLine("\nHouse #2 details:");
            Console.WriteLine("Enter the year the house was bullt:");

            int yearbuilt2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of the house:");
            string size2 = Console.ReadLine();

            House house2 = new House(yearbuilt2, size2);

            house.DisplayDetails("\nHouse 1");

            house2.DisplayDetails("\nHouse 2");
            Console.ReadLine();
        }     
    }
}




