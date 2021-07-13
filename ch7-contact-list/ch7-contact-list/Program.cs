using System;

namespace ch7_contact_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List Application!");
            Console.WriteLine();
            Contact contact = new Contact();


            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter first name: ");
                var fName = Console.ReadLine();
                contact.FirstName= fName;
                Console.WriteLine("Enter last name: ");
                var lName = Console.ReadLine();
                contact.LastName = lName;
                Console.WriteLine("Enter phone number: ");
                var phone = Console.ReadLine();
                contact.Phone = phone;
                Console.WriteLine("Enter email: ");
                var email = Console.ReadLine();
                contact.Email = email;


                Console.WriteLine("--------------------------------------");
                Console.WriteLine("---------Current Contact--------------");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Phone Number: {contact.Phone}");
                Console.WriteLine($"Email: {contact.Email}");


                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Peace");
        }
    }
}
