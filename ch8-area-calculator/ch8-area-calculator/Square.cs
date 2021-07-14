using System;
using System.Collections.Generic;
using System.Text;

namespace ch8_area_calculator
{
    public class Square : Shape
    {
        public double Length { get; set; }


        public Square()
        {

        }

        public double GetArea(double Length)
        {
            double area = Length * Length;
            return area;
        }

    }
}
