using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalesTaxDemo
{
    class Sales: IComparable
    {
        //declare constants
        const int MIN = 1;
        const int MAX = 10000;
        const double DEFSALE = 0.1;

        //declare instance variables
        int inventoryNumber;
        double saleAmount;
        double taxOwed;

        //no-arg constructor
        public Sales()
        {
            FillWithDefaults();
        }

        //full-arg constructor
        public Sales(int it, double sa, int to)
        {
            validateInventoryNumber(it);
            validateSaleAmount(sa);
        }

        public int InventoryNumber
        {
            get
            {
                return inventoryNumber;
            }

            set
            {
                validateInventoryNumber(value);
            }
        }

        public double SaleAmount
        {
            get
            {
                return saleAmount;
            }

            set
            {
                validateSaleAmount(value);
            }
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }

        int IComparable.CompareTo(object o)
        {
            int retVal;
            Sales temp = (Sales)o;
            retVal = this.TaxOwed.CompareTo(temp.TaxOwed);
            return retVal;
        }

        private void FillWithDefaults()
        {
            Random rnd = new Random();

            saleAmount = DEFSALE;
            inventoryNumber = rnd.Next(MIN, MAX);
        }

        public void validateInventoryNumber(int it)
        {
            Random rnd = new Random();
            inventoryNumber = ((it >= MIN) && (it <= MAX)) ? it : rnd.Next(MIN, MAX);
        }

        public void validateSaleAmount(double sa)
        {
            saleAmount = (sa >= DEFSALE) ? sa : DEFSALE;
            if (saleAmount < 100)
            {
                taxOwed = (saleAmount * .08);
                taxOwed = Math.Round(taxOwed, 2);
            }
            else
            {
                taxOwed = (saleAmount * .06);
            }
        }
    }
}
