using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileDemo
{
    public class FinancedAutomobile
    {
        const int MINIDNUM = 1;
        const int MAXIDNUM = 10000;
        const int DEFCARYEAR = 2000;
        const int MINCARYEAR = 1900;
        const int MAXCARYEAR = 2020;
        const double DEFCARPRICE = 10000;
        const int MINCARPRICE = 1;
        const int MAXCARPRICE = 100000;
        const double DEFCARFINANCED = 0;
        const double MINCARFINANCED = 0;
        const double DEFINTERESTRATE = 0.01;
        const double MININTERESTRATE = 0.01;
        const double MAXINTERESTRATE = 0.20;
        
        Random rnd = new Random();

        //	Declare program instance variables
        public int idNumber;
        public string carMake;
        public int carYear;
        public double carPrice;
        public double financed;
        public double interestRate;


        //************************************************
        //	No-arg constructor
        //************************************************
        public FinancedAutomobile()
        {
            idNumber = rnd.Next(1, 10000);
            carMake = "DCM";
            carYear = DEFCARYEAR;
            financed = DEFCARFINANCED;
        }

        //************************************************
        //	Full-arg constructor
        //************************************************
        public FinancedAutomobile(int id, string cm, int cy,
                        double cp, double fn, double ir)
        {
            this.idNumber = id;
            this.carMake = cm;
            this.carYear = cy;
            this.carPrice = cp;
            this.financed = fn;
            this.interestRate = ir;
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

        //************************************************
        //	Financed getter/setter
        //************************************************
        public double Financed
        {
            get
            {
                return financed;
            }
            set
            {
                bool result = Double.TryParse(value.ToString(), out financed);

                //  Handle non-numeric input
                if (!result)            //  if (result == false)
                {
                    financed = DEFCARFINANCED;
                }
                else if ((financed < MINCARFINANCED) || (financed > carPrice))
                {
                    financed = DEFCARFINANCED;
                }
                else
                {
                    financed = value;
                }
            }
        }

        //************************************************
        //	InterestRate getter/setter
        //************************************************
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                bool result = Double.TryParse(value.ToString(), out interestRate);

                //  Handle non-numeric input
                if (!result)            //  if (result == false)
                {
                    interestRate = DEFINTERESTRATE;
                }
                else if ((interestRate < MININTERESTRATE) || (interestRate > MAXINTERESTRATE))
                {
                    interestRate = DEFINTERESTRATE;
                }
                else
                {
                    interestRate = value;
                }
            }
        }

        //  Declare abstract method:
        //ADD THIS FOR FINANCED CLASS: public abstract double CalculateMonthlyPay();
        //
    }
}
