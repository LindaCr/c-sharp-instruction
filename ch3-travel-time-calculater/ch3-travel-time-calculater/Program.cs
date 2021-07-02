using System;

namespace ch3_travel_time_calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator!");

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter miles: ");
                int miles = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter miles per hour: ");
                int mph = Convert.ToInt32(Console.ReadLine());

                int hours = miles / mph;
                int minutes = miles % mph;

                Console.WriteLine();
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minutes);


                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }



            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
