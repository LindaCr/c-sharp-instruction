using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            do
            {
                var nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 1) throw new OddNumberException(nbr);
                Console.WriteLine("Continue? y/n");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Peace!");

        }
    }
}
