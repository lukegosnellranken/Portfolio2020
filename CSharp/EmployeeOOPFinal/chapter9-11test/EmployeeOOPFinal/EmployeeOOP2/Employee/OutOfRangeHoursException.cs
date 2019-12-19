using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeHoursException : Exception
    {
        private static string msg = "Hours Worked Must Be Between 0 - 84";

        public OutOfRangeHoursException() : base(msg)
        { }
    }
}