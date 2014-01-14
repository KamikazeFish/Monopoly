using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    // http://msdn.microsoft.com/en-us/library/87cdya3t(v=vs.110).aspx
    class InvalidArrayLengthException : Exception
    {
        public InvalidArrayLengthException()
        {

        }

        public InvalidArrayLengthException(string message)
            : base(message)
        {

        }

        public InvalidArrayLengthException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
