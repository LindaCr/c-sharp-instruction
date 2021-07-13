using System;

namespace ch5_guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          Welcome to the Guess the Number Game!             ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it!");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {
                Random rnd = new Random();
                var nbr = rnd.Next(0, 101);
                var guess = 0;
                var count = 0;
               
                while(guess!=nbr)
                {
                    guess = GetIntWithinRange("Enter a number: ", 0, 101);
                    count++;

                    int diff = guess - nbr;
                    if (diff < -10)
                    {
                        Console.WriteLine("Way too low!");
                    }
                    else if (diff < 0)
                    {
                        Console.WriteLine("Too low.");
                    }
                    else if (diff > 10)
                    {
                        Console.WriteLine("Way too high!");
                    }
                    else if (diff > 0)
                    {
                        Console.WriteLine("Too high.");
                    }

                }

                PrintWinner(count);
                Console.WriteLine();
                choice = GetRequiredString("Play again? y/n", "y", "n");
            }
            Console.WriteLine();
            Console.WriteLine("Peace!");
        }

        private static void PrintWinner(int count)
        {
            Console.WriteLine("You got it in " + count + " tries.");
            if (count <= 3)
            {
                Console.WriteLine("Great job! You are awesome!");
            }
            else if (count <= 7)
            {
                Console.WriteLine("Not too bad! You have some potential!");
            }
            else
            {
                Console.WriteLine("What took you so long?");
            }
        }
        private static String GetRequiredString( String prompt,
                                                String s1, String s2)
        {
            String str = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                str = Console.ReadLine().ToLower();
                if (!str.Equals(s1) && !str.Equals(s2))
                {
                    Console.WriteLine("Invalid Entry, try again.");
                }
                else
                {
                    isValid = true;
                }
            }

            return str;
        }
        public static int GetIntWithinRange( String prompt,
                int min, int max)
        {
            int i = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                i = Convert.ToInt32(Console.ReadLine());
                if (i <= min)
                {
                    Console.WriteLine (
                            "Error! Number must be greater than " + min + ".");
                }
                else if (i >= max)
                {
                    Console.WriteLine (
                            "Error! Number must be less than " + max + ".");
                }
                else
                {
                    isValid = true;
                }
            }
            return i;
        }
  
    }
}
