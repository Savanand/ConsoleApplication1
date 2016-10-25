using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class InvalidTriangleException : System.Exception
    {
        public InvalidTriangleException() : base() { }
        public InvalidTriangleException(string message) : base(message) { }
        public InvalidTriangleException(string message, double a, double b, double c) : base(message) {
            Console.WriteLine("Triangle is not possible with these sides= "+a+" ,"+b+" ,"+c);
        }

        public InvalidTriangleException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidTriangleException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
