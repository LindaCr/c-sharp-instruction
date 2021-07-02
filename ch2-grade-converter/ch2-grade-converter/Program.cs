using System;

namespace ch2_grade_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Converter!");
            Console.WriteLine();

            string choice = "y";
            while (choice.Equals("y"))
            {

                Console.WriteLine("Enter the numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade >= 67)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else
                    Console.WriteLine("Letter Grade: F");


                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }

        }
    }
}
