using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class NegativeNumberException : Exception
    {

        public NegativeNumberException()
            : base("negatives not allowed")
        {
        }

        public NegativeNumberException(string message)
            : base(message)
        {
        }

        public NegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
