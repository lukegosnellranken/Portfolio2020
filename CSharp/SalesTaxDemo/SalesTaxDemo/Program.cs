using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalesTaxDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            const int SALESARRAYSIZE = 10;

            int lcv = 0;
            int val = 0;
            Sales[] salesArray = new Sales[SALESARRAYSIZE];

            for (lcv = 0; lcv < salesArray.Length; ++lcv)
            {
                Console.Clear();
                //create a new sale array object
                salesArray[lcv] = new Sales();

                //get info about each sale
                Write("Enter inventory number:\t");
                int.TryParse(ReadLine(), out val);
                salesArray[lcv].InventoryNumber = val;

                Write("Enter sale amount: \t$");
                int.TryParse(ReadLine(), out val);
                salesArray[lcv].SaleAmount = val;

            }

            Console.Clear();
            Array.Sort(salesArray,
            delegate (Sales x, Sales y) { return x.TaxOwed.CompareTo(y.TaxOwed); });
            Array.Reverse(salesArray);

            //write out sale list headings and list
            WriteLine("\nInv. Number      Sale Amount    Tax Owed");
            WriteLine("===========================================");

            for (lcv = 0; lcv < salesArray.Length; ++lcv)
            {
                WriteLine("{0, -18}{1, -15}{2, -18}", salesArray[lcv].InventoryNumber, "$" + salesArray[lcv].SaleAmount, "$" + salesArray[lcv].TaxOwed);
            }
            ReadLine();
            Console.Clear();

        }
    }
}
