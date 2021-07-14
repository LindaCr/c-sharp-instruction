using System;
using System.Collections.Generic;
using System.Text;

namespace ch8_area_calculator
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(double Width, double Length)
        {

        }

        public double GetArea(double Width, double Length)
        {
            double area = Width * Length;
            return area;
        }
    }
}
