using System;

namespace ch4_squares_and_cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table!");
            Console.WriteLine();

            string choice = "y";
            while(choice.Equals("y"))
            {
                Console.WriteLine("Enter an integer: ");
                int nbr = Convert.ToInt32(Console.ReadLine());

                int square = nbr * nbr;
                int cube = nbr * nbr * nbr;

                Console.WriteLine();
                Console.WriteLine("Number    Square     Cube");
                Console.WriteLine("-------------------------");
                Console.WriteLine(" " + nbr + "        " + square + "         " + cube);


                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Peace");
        }
    }
}
