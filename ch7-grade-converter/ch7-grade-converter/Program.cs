using System;

namespace ch7_grade_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grade Coverter!");
            Console.WriteLine();
            Grade grade = new Grade();
            string Letter = null;

            var choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter Grade: ");
                var nbrGrade = Convert.ToInt32(Console.ReadLine());
                var letterGrade=grade.LetterGrade(nbrGrade);
                Console.WriteLine($"Grade is {letterGrade}");


                choice = GetRequiredString("Continue? y/n", "y", "n");
            }
            Console.WriteLine();
            Console.WriteLine("Peace");

        }


        private static String GetRequiredString(String prompt,
                                        String s1, String s2)
        {
            String str = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(prompt);
                str = Console.ReadLine();
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
    }
}
