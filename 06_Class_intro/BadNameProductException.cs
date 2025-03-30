using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Class_intro
{
    internal class BadDateProductException : ApplicationException
    {
        public DateTime errorDate;
        public BadDateProductException(string message, DateTime dl)
            :base(message)
        {
            errorDate = dl;
        }
    }
}
