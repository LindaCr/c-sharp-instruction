using System;

namespace ch8_person_manager
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Person Manager App!");
            Console.WriteLine();
			Customer customer = new Customer();
			Employee employee = new Employee();


			string choice = "y";
			while(choice.Equals("y"))
            {
				var person = GetRequiredString("Are you entering a customer or employee? c/e", "c", "e");
				if (person.Equals("c"))
                {
                    Console.WriteLine("Enter first name: ");
					var FirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
					var LastName = Console.ReadLine();
                    Console.WriteLine("Enter customer number: ");
					var CustomerNumber = Console.ReadLine();
					customer = new Customer(FirstName, LastName, CustomerNumber);
                    Console.WriteLine("You entered new customer.");
                    Console.WriteLine($"Customer name: {FirstName} {LastName} \n Customer number: {CustomerNumber}");
                }
				if (person.Equals("e"))
                {
					Console.WriteLine("Enter first name: ");
					var FirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
					var LastName = Console.ReadLine();
                    Console.WriteLine("Enter ssn: ");
					string Ssn = Console.ReadLine();
					employee = new Employee(FirstName, LastName, Ssn);
					int startIndex = 6;
					int length = 4;
					string substring = Ssn.Substring(startIndex, length);
                    Console.WriteLine("You entered a new employee.");
                    Console.WriteLine($"Employee name: {FirstName} {LastName} \n SSN: xxx-xx-{substring}");
                }	


				choice = GetRequiredString("Add another person? y/n", "y", "n");
            }
            Console.WriteLine();
            Console.WriteLine("Peace!");
		}



		private static String GetRequiredString(String prompt,
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
	}
}
