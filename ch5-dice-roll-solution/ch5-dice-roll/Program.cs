using System;

namespace ch5_dice_roll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller!");

            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Let's Roll!");

                var roll1 = RollDie();
                Console.WriteLine(roll1);


                Console.WriteLine("Roll again? y/n");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.WriteLine("Peace");
        }

        private static Random RollDie()
        {
           Random rand = new Random(7);
            return rand;
        }
    }
}
