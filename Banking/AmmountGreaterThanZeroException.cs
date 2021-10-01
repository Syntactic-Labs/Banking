using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class AmmountGreaterThanZeroException : Exception          //When you make an exception class you must inherit Exception
    {
        public AmmountGreaterThanZeroException() : base() { }       //1 default

        public AmmountGreaterThanZeroException(string Message) : base(Message) { }      //1 with string

        public AmmountGreaterThanZeroException(string Message, Exception InnerException) : base(Message, InnerException) { }  //1 with the exception
    }
}
