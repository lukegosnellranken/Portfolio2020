using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class OutOfRangeWeeklySalesException: Exception
    {
        private static string msg = "Weekly Sales Must Be Between 0.10 - 0.33";

        public OutOfRangeWeeklySalesException() : base(msg)
        { }
    }
}
