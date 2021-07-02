using System;

namespace ch3_change_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the Change Calculator");
			Console.WriteLine();

			string choice = "y";
			while (choice.Equals("y"))
			{

				Console.WriteLine("Enter number of cents(0-99): ");
				int cents = Convert.ToInt32(Console.ReadLine());

				int quarters = cents / 25;
				int remainder = cents % 25;

				int dimes = remainder / 10;
				remainder = remainder % 10;

				int nickels = remainder / 5;
				remainder = remainder % 5;

				Console.WriteLine("Quarters: " + quarters);
				Console.WriteLine("Dimes: " + dimes);
				Console.WriteLine("Nickels: " + nickels);
				Console.WriteLine("Pennies: " + remainder);

				Console.WriteLine("\nContinue? (y/n)? ");
				choice = Console.ReadLine();
			}

			Console.WriteLine();
			Console.WriteLine("Peace");

		}
    }
}
