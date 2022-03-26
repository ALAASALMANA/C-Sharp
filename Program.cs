using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
      

            Console.WriteLine("Enter the number of hours:");
                var hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter How much per 1 hour:");
                var PerHours = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Salary is in a day:" + (hours*PerHours));
            Console.WriteLine("Salary is in a month:" + (hours * PerHours)*30);
            Console.WriteLine("Salary is in a 6 month:" + (hours * PerHours) * 30*6);
            Console.WriteLine("Salary is in a Year:" + (hours * PerHours)* 30*12);
















        }
    }

}


