using System;
using POC;
using POC.Models;

namespace POC
{
	class Program
	{
		static void Main(string[] args)
		{
            using (var context = new PostGres_DbContext())
            {
                
                // Adding data
                var newStudent = new Student
                {
                    first_name = "John",
                    last_name = "Doe",
                    date_of_birth = new DateTime(1995, 5, 15),
                    address = "123 Main St"
                };


                try
                {
                    var temp = context.Students.Find();
                    //context.Students.Add(newStudent);
                }
                catch (Exception ex)
                {

                }
                context.SaveChanges();

            }

            // msql dbcontxt

            Console.ReadLine();
		}
	}
}
