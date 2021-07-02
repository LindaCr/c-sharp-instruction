using System;

namespace ch4_tip_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tip Calculator!");
            Console.WriteLine();

            Console.WriteLine("Cost of meal: ");
            string costStr = Console.ReadLine();
            double cost = double.Parse(costStr);

            double tip15 = cost * .15;
            double tip20 = cost * .2;
            double tip25 = cost * .25;

            Console.WriteLine("15% tip");
            Console.WriteLine("Tip amount: " + tip15 + " Total amount: " + (cost + tip15));
            Console.WriteLine("20% tip");
            Console.WriteLine("Tip amount: " + tip20 + " Total amount: " + (cost + tip20));
            Console.WriteLine("25% tip");
            Console.WriteLine("Tip amount: " + tip25 + " Total amount: " + (cost + tip25));

            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
