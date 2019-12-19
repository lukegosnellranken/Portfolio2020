using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RelativeList
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize global constant
            const int ARRAYSIZE = 5;

            //declare and init global variables
            int lcv = 0;
            int val = 0;
            bool bDayFound = false;
            string name = "";
            Relative[] relativeArray = new Relative[ARRAYSIZE];

            for (lcv = 0; lcv < relativeArray.Length; ++lcv)
            {
                Console.Clear();
                //create a new relative array object
                relativeArray[lcv] = new Relative();

                //get info about each relative
                Write("Enter your relative's first name:\t");
                relativeArray[lcv].Name = ReadLine();
                name = relativeArray[lcv].Name;

                Write("Enter your relationship to {0}:\t", name);
                relativeArray[lcv].Relationship = ReadLine();

                Write("Enter your relative's birth month to {0}:\t", name);
                int.TryParse(ReadLine(), out val);
                relativeArray[lcv].Month = val;

                Write("Enter your birth day {0}:\t", name);
                int.TryParse(ReadLine(), out val);
                relativeArray[lcv].Day = val;

                Write("Enter your birth year {0}:\t", name);
                int.TryParse(ReadLine(), out val);
                relativeArray[lcv].Year = val;
            }

            Console.Clear();
            Array.Sort(relativeArray);

            //write out relative list headings and list
            WriteLine("Your sorted relatives list");
            WriteLine("\nNAME        RELATIONSHIP      BIRTH DAY");
            WriteLine("==========================================");

            for (lcv = 0; lcv < relativeArray.Length; ++lcv)
            {
                WriteLine("{0, -15}{1, -15}{2}/{3}/{4}", relativeArray[lcv].Name, relativeArray[lcv].Relationship, relativeArray[lcv].Month, relativeArray[lcv].Day, relativeArray[lcv].Year);
            }
            ReadLine();
            Console.Clear();

            //check to see if there is a relative with the inputted name
            //if so, print out his or her birthday info
            Write("Enter the name of a relative to see their birthday\t");
            name = ReadLine();

            for (lcv = 0; lcv < relativeArray.Length; ++lcv)
            {
                //if name found at this array location, print out the associated birthday info and set bday flag to true
                if (relativeArray[lcv].Name.Equals(name))
                {
                    WriteLine("\nBirthday for {0} is {1}/{2}/{3}", name, relativeArray[lcv].Month, relativeArray[lcv].Day, relativeArray[lcv].Year);
                    bDayFound = true;
                }
            }
            
            if (!bDayFound)
            {
                WriteLine("\n{0} is not in the list of relative names", name);
            }

            ReadLine();
        }
    }
}
