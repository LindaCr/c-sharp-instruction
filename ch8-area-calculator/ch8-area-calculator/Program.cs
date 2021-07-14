using System;

namespace ch8_area_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area Calculator!");
            Console.WriteLine();
			Circle circle = new Circle();
			Square square = new Square();
			Rectangle rectangle = new Rectangle();


			double area = 0;
            string choice = "y";
            while (choice.Equals("y"))
            {
				var shape = GetRequiredString("Calculate the area of a circle, square, or rectangle? c/s/r", "c", "s", "r");
				if (shape.Equals("c"))
                {
                    Console.WriteLine("Enter radius: ");
					double Radius = Double.Parse(Console.ReadLine());
					area = circle.GetArea(Radius);
                    Console.WriteLine($"Area= {area}");
                }
				if (shape.Equals("s"))
                {
                    Console.WriteLine("Enter length: ");
					double Length = Double.Parse(Console.ReadLine());
					area = square.GetArea(Length);
                    Console.WriteLine($"Area= {area}");
                }
				if (shape.Equals("r"))
                {
                    Console.WriteLine("Enter length: ");
					double Length = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width: ");
					double Width = Double.Parse(Console.ReadLine());
					area = rectangle.GetArea(Length, Width);
                    Console.WriteLine($"Area= {area}");
                }



				choice = GetRequiredString("Continue? y/n", "y", "n");
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

		private static String GetRequiredString(String prompt,
										String s1, String s2, string s3)
		{
			String str = "";
			bool isValid = false;
			while (!isValid)
			{
                Console.WriteLine(prompt);
				str = Console.ReadLine().ToLower();
				if (!str.Equals(s1) && !str.Equals(s2) && !str.Equals(s3))
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
