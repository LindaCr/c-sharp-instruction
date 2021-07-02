using System;

namespace ch2_rectangle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                int area = length * width;
                int perimeter = 2 * length + 2 * width;


                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
