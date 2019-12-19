using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativeList
{
    class Relative : IComparable
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        int IComparable.CompareTo(object o)
        {
            int retVal;
            Relative temp = (Relative)o;
            retVal = this.Name.CompareTo(temp.Name);
            return retVal;
        }
    }
}
