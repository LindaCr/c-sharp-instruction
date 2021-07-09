using System;

namespace BowlingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Go Bowling!");

            var game = new Bowling();
            Console.WriteLine($"Game score is {game.Bowl()}!");





            Console.WriteLine("Peace");
        }
    }
}
