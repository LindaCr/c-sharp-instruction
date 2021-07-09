using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class OddNumberException : Exception
    {
        public int OddNumber { get; set; }


        //default constructor, must also call Base class (Parent Class) Constructor (added nbr after)
        public OddNumberException (int Nbr) 
            : base() {
            OddNumber = Nbr;
        }

        //constructor with 1 parameter
        public OddNumberException(string Message)
            : base(Message) { }

        //constructor with 2 parameters
        public OddNumberException(string Message, Exception InnerException)
            : base(Message, InnerException) { }

    }
}
