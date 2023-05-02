using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            { //Create a list of Employees(10)
                new Employee { Id = 1, FirstName = "Jane", LastName = "Bob"},
                new Employee { Id = 2, FirstName = "Bob", LastName = " Jones"},
                new Employee { Id = 3, FirstName = "Quinn", LastName = " Tally"},
                new Employee { Id = 4, FirstName = "Joe", LastName = " Jamoli"},
                new Employee { Id = 5, FirstName = "Carry", LastName = "Jack"},
                new Employee { Id = 6, FirstName = "Joe", LastName = " Huberty"},
                new Employee { Id = 7, FirstName = "Cam", LastName = " Sam"},
                new Employee { Id = 8, FirstName = "Sam", LastName = " Jack"},
                new Employee { Id = 9, FirstName = "Bryan", LastName = " Sall"},
                new Employee { Id = 10, FirstName = "Sall", LastName = " Hendricks"}
            };

            //Create a new list of all employees with the first name "Joe" using foreach loop
            List<Employee> joes = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if(emp.FirstName == "Joe") // if emp in list of employees == Joe, add that emp(employees)
                {
                    joes.Add(emp); //adds that emp from employee into the list of employees named joes
                }
            }

            //Console.WriteLine("Employees with the first name \"Joe\"(using foreach loop):");
            //foreach(Employee joe in joes)
            //{
            //    Console.WriteLine($"Id: {joe.Id}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            //}

            //Creates a new list of all employees with the first name "Joe" using a lambada expression . The new list here is joesLambda
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"Id: {joe.Id}, FirstName: {joe.FirstName}, LastName: {joe.LastName}");
            }

            //Creates a new list of employees with an Id greater than 5 
            List<Employee> highIdEmployees = employees.Where(emp => emp.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
