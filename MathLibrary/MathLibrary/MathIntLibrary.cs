using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class MathIntLibrary
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Modulus(int a, int b)
        {
            return a % b;
        }
        public static int Factorial(int a)
        {
            var f = 1;
            for (var idx=a;idx>=2;idx--)
            {
                f *= idx;
            }
            return f;
        }

        public static int Zero()
        {
            return 0;
        }


    }
}
