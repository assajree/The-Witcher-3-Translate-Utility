using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Classes
{
    public class KnowException : Exception
    {
        public KnowException() : base()
        {
        }
        public KnowException(string message) : base(message)
        {

        }
        public KnowException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
