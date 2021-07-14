using System;
using System.Collections.Generic;
using System.Text;

namespace ch8_area_calculator
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public double GetArea(double Radius)
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }
    }
}
