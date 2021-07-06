using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");

            
            for (var idx=1; idx<=30; idx++)
            {
                if (idx % 3 == 0 && idx % 5== 0)
                {
                    Console.Write("FIZZBUZZ ");
                    continue;
                }
                 if (idx%3==0) {
                    Console.Write("FIZZ ");
                    continue;
                }
                 if (idx%5==0)
                {
                    Console.Write("BUZZ ");
                    continue;
                }
                else
                {
                    Console.Write($"{idx} ");
                }
            }

        }
    }
}
