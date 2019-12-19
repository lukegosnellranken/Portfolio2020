using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paint
{
    class Program
    {
        const int ARRAYSIZE = 8;
        const int MIN = 10;
        const int MAX = 30;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Room[] rooms = new Room[ARRAYSIZE];
            int lcv = 0;
            int len = 0;
            int wid = 0;

            //input the 8 room objects lengths and widths
            for (lcv = 0; lcv < rooms.Length; ++lcv)
            {
                wid = rnd.Next(MIN, MAX);
                len = rnd.Next(MIN, MAX);
                rooms[lcv] = new Room(len, wid);
            }

            //print out 8 rooms objects respective info
            for (lcv = 0; lcv < rooms.Length; ++lcv)
            {
                WriteLine("\n\n\nRoom {0} is {1} feet wide X {2} feet long",
                            (lcv + 1), rooms[lcv].Width, rooms[lcv].Length);
                WriteLine("To paint this {0} total area room, you need {1} gallons of paint",
                            rooms[lcv].Area, rooms[lcv].Gallons);
                WriteLine("\n\n\nPlease hit <enter> to continue");
                ReadLine();
                Console.Clear();
            }

        }
    }
}
