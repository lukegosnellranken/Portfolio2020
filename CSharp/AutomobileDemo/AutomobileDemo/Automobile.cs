using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    public class Automobile: IComparable
    {
        const int MINIDNUM = 1;
        const int MAXIDNUM = 10000;
        const int DEFCARYEAR = 2000;
        const int MINCARYEAR = 1900;
        const int MAXCARYEAR = 2020;
        const double DEFCARPRICE = 10000;
        const int MINCARPRICE = 1;
        const int MAXCARPRICE = 100000;
        Random rnd = new Random();

        //	Declare program instance variables
        public int idNumber;
        public string carMake;
        public int carYear;
        public double carPrice;

        //************************************************
        //	No-arg constructor
        //************************************************
        public Automobile()
        {
            idNumber = rnd.Next(1, 10000);
            carMake = "DCM";
            carYear = DEFCARYEAR;
        }

        //************************************************
        //	Full-arg constructor
        //************************************************
        public Automobile(int id, string cm, int cy,
                        double cp)
        {
            this.idNumber = id;
            this.carMake = cm;
            this.carYear = cy;
            this.carPrice = cp;
        }

        //************************************************
        //	ID getter/setter
        //************************************************
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                bool result = Int32.TryParse(value.ToString(), out idNumber);

                if (!result)
                {
                    idNumber = rnd.Next(1, 10000);
                }
                else if ((idNumber < MINIDNUM) || (idNumber > MAXIDNUM))
                {
                    idNumber = rnd.Next(1, 10000);
                }
                else
                {
                    idNumber = value;
                }
            }
        }

        //************************************************
        //	Make getter/setter
        //************************************************
        public string CarMake
        {
            get
            {
                return carMake;
            }
            set
            {
                CarMake = (value == string.Empty) ? "*" : value;
            }
        }

        //************************************************
        //	Year getter/setter
        //************************************************
        public int CarYear
        {
            get
            {
                return carYear;
            }
            set
            {
                bool result = Int32.TryParse(value.ToString(), out carYear);

                if (!result)
                {
                    carYear = DEFCARYEAR;
                }
                else if ((carYear < MINCARYEAR) || (carYear > MAXCARYEAR))
                {
                    carYear = DEFCARYEAR;
                }
                else
                {
                    carYear = value;
                }
            }
        }


        //************************************************
        //	Price getter/setter
        //************************************************
        public double CarPrice
        {
            get
            {
                return carPrice;
            }
            set
            {
                bool result = Double.TryParse(value.ToString(), out carPrice);

                //  Handle non-numeric input
                if (!result)            //  if (result == false)
                {
                    carPrice = DEFCARPRICE;
                }
                else if ((carPrice < MINCARPRICE) || (carPrice > MAXCARPRICE))
                {
                    carPrice = DEFCARPRICE;
                }
                else
                {
                    carPrice = value;
                }
            }
        }

        //  Declare abstract method:
        //ADD THIS FOR FINANCED CLASS: public abstract double CalculateMonthlyPay();

        //************************************************
        //	Overridden ToString()
        //************************************************
        public override string ToString()
        {   //  Begin public override string ToString()
            string outputStr = "";

            outputStr += "ID Number: " + IdNumber.ToString() + "\n";
            outputStr += "Make:  " + CarMake + "\n";
            outputStr += "Year: " + CarYear.ToString() + "\n";
            outputStr += "Price: $" + CarPrice.ToString("f2");

            return outputStr;
        }   //  End   public override string ToString()

        public int CompareTo(object o)
        {
            int retVal;
            Automobile temp = (Automobile)o;
            retVal = this.IdNumber.CompareTo(temp.IdNumber);
            return retVal;
        }
    }
}
