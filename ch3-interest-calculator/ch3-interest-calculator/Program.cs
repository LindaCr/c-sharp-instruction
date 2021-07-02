using System;

namespace ch3_interest_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator!");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter loan amount: ");
                string amountStr = Console.ReadLine();
                double amount = double.Parse(amountStr);

                Console.WriteLine("Enter interest amount: ");
                string aprStr = Console.ReadLine();
                double apr = double.Parse(aprStr);

                double interest = amount * apr;
                Console.WriteLine("Interest: " + interest);


                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
