using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bank
{
    class BankAccount: IComparable
    {
        //declare constants
        const int MIN = 1000;
        const int MAX = 10000;
        const int INITIALBAL = 25;
        const string DEFFN = "UFirst";
        const string DEFLN = "ULast";

        //declare instance variables
        string firstName;
        string lastName;
        int acctNumber;
        double initialBal;

        //no-arg constructor
        public BankAccount()
        {
            FillWithDefaults();
        }

        //full-arg constructor
        public BankAccount(string fn, string ln, int an, int ab)
        {
            validateFirstName(fn);
            validateLastName(ln);
            validateAcctNumber(an);
            validateAccountBalance(ab);
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                validateFirstName(value);
            }
        }
   
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                validateLastName(value);
            }
        }
        public int AcctNumber
        {
            get
            {
                return acctNumber;
            }

            set
            {
                validateAcctNumber(value);
            }
        }
        public double InitialBal
        {
            get
            {
                return initialBal;
            }

            set
            {
                validateAccountBalance(value);
            }
        }

        int IComparable.CompareTo(object o)
        {
            int retVal;
            BankAccount temp = (BankAccount)o;
            retVal = this.LastName.CompareTo(temp.LastName);
            return retVal;
        }

        private void FillWithDefaults()
        {
            Random rnd = new Random();

            firstName = DEFFN;
            lastName = DEFLN;
            acctNumber = rnd.Next(MIN, MAX);
            initialBal = INITIALBAL;
        }

        public void validateFirstName(string fn)
        {
            firstName = (fn != "") ? fn : DEFFN;
        }

        public void validateLastName(string ln)
        {
            lastName = (ln != "") ? ln : DEFLN;
        }

        public void validateAcctNumber(int an)
        {
            Random rnd = new Random();
            acctNumber = ((an >= MIN) && (an <= MAX)) ? an : rnd.Next(MIN, MAX);
        }

        public void validateAccountBalance(double ab)
        {
            initialBal = (ab >= INITIALBAL) ? ab : INITIALBAL;
        }

        public void depositFunds(int funds)
        {
            if (funds > 0)
            {
                initialBal = initialBal + funds;
            }
            else
            {
                WriteLine("Please enter a positive number");
            }
        }

        public void withdrawFunds(int funds)
        {
            if (initialBal - funds > INITIALBAL)
            {
                initialBal = initialBal - funds;
            }
            else
            {
                WriteLine("Account must always have at least $25");
            }
        }

        public override string ToString()
        {
            string str = "\nFirst Name: " + firstName;
                   str += "\nLast Name: " + lastName;
                   str += "\nAccount Number: " + acctNumber;
                   str += "\nAccount Balance: " + initialBal;

            return str;
        }
    }
}
