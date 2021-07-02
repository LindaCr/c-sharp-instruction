using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("LALA");


            String firstName = "Bob";
            string lastName = "Smith";

            int n1 = 5;
            int n2 = 7;
            int sum = n1 + n2;

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("sum "+sum);

            //p 47 var-identifier
            var name1 = "Sam Brown";

            //single line commet

            /*
             * multiline
             * comment
             */

            //p 52
            double price1 = 25.99;

            Console.WriteLine("What's your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Hello " + name2+"!");

            string choice = "y";
            while (choice.Equals("y"))
            {
                
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }

            if (sum > 10)
            {
                Console.WriteLine(">10");
            }
            else
            {
                Console.WriteLine("<10");
            }

        }
    }
}
