using System;

namespace ch2_student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration");
            Console.WriteLine();

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Welcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + year);
        }
    }
}
