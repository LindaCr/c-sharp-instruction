using System;

namespace ch4_factorial_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the Factorial Calculator");
			Console.WriteLine();

			String choice = "y";
			while (choice.Equals("y"))
			{

				Console.WriteLine("Enter an integer that's greater than 0 and less than 10:");
				int number = Convert.ToInt32(Console.ReadLine());

				long factorial = 1;
				for (int i = 1; i <= number; i++)
				{
					factorial *= i;
				}
				Console.WriteLine("The factorial of " + number + " is " + factorial);

				Console.WriteLine();
				Console.WriteLine("Continue? y/n");
				choice = Console.ReadLine();
			}
			Console.WriteLine();
			Console.WriteLine("Peace");



		}
    }
}
