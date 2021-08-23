using System;

namespace math_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");

            var z = 3;
            var a = 5;
            var n = 12;

            var sum = z + a + n;
            var mult = z * a * n;
            var diff = n - a - z;
            var div = n / z;

            Console.WriteLine(sum);
            Console.WriteLine(mult);
            Console.WriteLine(diff);
            Console.WriteLine(div);

            Console.WriteLine("Peace");
        }
    }
}
