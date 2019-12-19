using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bank
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
            bool personFound = false;
            string lastName = "";
            BankAccount[] personArray = new BankAccount[ARRAYSIZE];

            for (lcv = 0; lcv < personArray.Length; ++lcv)
            {
                Console.Clear();
                //create a new person array object
                personArray[lcv] = new BankAccount();

                //get info about each person
                Write("Enter first name:\t");
                personArray[lcv].FirstName = ReadLine();

                Write("Enter last name:\t");
                personArray[lcv].LastName = ReadLine();
                lastName = personArray[lcv].FirstName;

                Write("Enter account number\t");
                int.TryParse(ReadLine(), out val);
                personArray[lcv].AcctNumber = val;

                Write("Enter account balance\t");
                int.TryParse(ReadLine(), out val);
                personArray[lcv].InitialBal = val;

            }

            Console.Clear();
            Array.Sort(personArray);

            //write out person list headings and list
            WriteLine("\nNAME      ACCOUNT NUMBER    BALANCE");
            WriteLine("=====================================");

            for (lcv = 0; lcv < personArray.Length; ++lcv)
            {
                WriteLine("{0, -15}{1, -15}{2, -15}", personArray[lcv].LastName + ", " + personArray[lcv].FirstName, personArray[lcv].AcctNumber, personArray[lcv].InitialBal);
            }
            ReadLine();
            Console.Clear();

            //check to see if there is a person with the inputted name
            //if so, print out his or her info
            Write("Enter the last name of a person to see their info: \t");
            lastName = ReadLine();

            for (lcv = 0; lcv < personArray.Length; ++lcv)
            {
                //if name found at this array location, print out the associated info and set personFound flag to true
                if (personArray[lcv].LastName.Equals(lastName))
                {
                    WriteLine("\nNAME      ACCOUNT NUMBER    BALANCE");
                    WriteLine("=====================================");
                    WriteLine("{0, -15}{1, -15}{2, -15}", personArray[lcv].LastName + ", " + personArray[lcv].FirstName, personArray[lcv].AcctNumber, personArray[lcv].InitialBal);
                    personFound = true;
                }
            }

            if (!personFound)
            {
                WriteLine("\n{0} is not in the list of people", lastName);
            }

            ReadLine();
        }
    }
}
