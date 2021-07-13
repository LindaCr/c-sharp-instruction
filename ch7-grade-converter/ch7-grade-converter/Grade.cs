using System;
using System.Collections.Generic;
using System.Text;

namespace ch7_grade_converter
{
    class Grade
    {
        public int Number { get; set; }
        public string Letter { get; set; }

        public Grade()
        {
            Number = 0;
        }

        public Grade(int Number)
        {
            this.Number = Number;
        }

        public string LetterGrade(int Number)
        {
            this.Number = Number;
            if (Number >= 90)
            {
                Letter = "A";
            }
            else if (Number >= 80)
            {
                Letter = "B";
            }
            else if (Number >= 70)
            {
                Letter = "C";
            }
            else if (Number >= 60)
            {
                Letter = "D";
            }
            else
            {
                Letter = "F";
            }
            return Letter;
        }

    }
}
