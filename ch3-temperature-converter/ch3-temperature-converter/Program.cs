using System;

namespace ch3_temperature_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter!");

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter degrees in Farenheit: ");
                string fs = Console.ReadLine();
                double f = double.Parse(fs);

                double c = (f - 32) * 5 / 9;

                Console.WriteLine("Degrees in Celsius: " + c);

                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }


            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
