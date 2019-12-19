using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Room
    {
        readonly int width;
        readonly int length;
        int area;
        int gallons;

        //create constructor
        public Room(int len, int wid)
        {
            width = wid;
            length = len;
            ComputeArea();
            ComputeGallons();
        }

        //property getters and setters
        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public int Area
        {
            get
            {
                return area;
            }
        }

        public int Gallons
        {
            get
            {
                return gallons;
            }
        }

        private void ComputeArea()
        {
            area = length * width;
        }

        private void ComputeGallons()
        {
            const int ONEBUCKET = 350;
            gallons = area / ONEBUCKET;

            if (area % ONEBUCKET != 0)
            {
                ++gallons;
            }
        }
    }
}
