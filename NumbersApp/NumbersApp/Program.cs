using System;

namespace NumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers app");


            Random rand = new Random();
            Console.WriteLine("random #= " + rand.Next());

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("die roll= " + rand.Next(1, 7));
            }

            //round to 3 decimal places, half up
            Console.WriteLine(Math.Round(25.3456789, 3, MidpointRounding.AwayFromZero));

        }
    }
}
