using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;


namespace CodeFirstChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                
                //Adding student
                Student stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.Write("Student Saved Successfully");
            }
        }
    }
}
