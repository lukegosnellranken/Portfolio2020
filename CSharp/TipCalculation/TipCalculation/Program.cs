using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nCall #1 to showBillAndTip()");
            showBillAndTip(100.00, -10.00);

            WriteLine("\nCall #2 to showBillAndTip()");
            showBillAndTip(100.00, 00.15);

            WriteLine("\nCall #3 to showBillAndTip()");
            showBillAndTip(100.00, 20.00);

            WriteLine("\nCall #4 to showBillAndTip()");
            showBillAndTip(100.00, -20.00);

            WriteLine("\nCall #5 to showBillAndTip()");
            showBillAndTip(100.00, 25);

            ReadLine();
        }

        static void showBillAndTip(double bill, double tipPercent)
        {
            double tipAmt = 0.0;
            double totalBill = 0.0;

            if (bill < 0)
            {
                bill = bill;
            }

            if (tipPercent < 0)
            {
                tipPercent = -tipPercent;
            }

            if (tipPercent > 1)
            {
                tipPercent /= 100;
            }

            tipAmt = bill * tipPercent;
            totalBill = bill + tipAmt;

            WriteLine("The bill before your tip was: " + bill.ToString("c"));
            WriteLine("The total amount of the tip is: " + tipAmt.ToString("c"));
            WriteLine("Thetip percentage of the bill is: " + tipPercent.ToString("c"));
            WriteLine("The total amount of the bill is: " + totalBill.ToString("c"));

        }

        static void showBillAndTip(double bill, int tip)
        {
            double totalBill = 0.0;
            double tipPercentage = 0.0;

            if (bill < 0)
            {
                bill = -bill;
            }

            if (tip < 0)
            {
                tip = -tip;
            }

            totalBill = bill + tip;

            tipPercentage = (double)tip / bill;

            WriteLine("The bill before your tip was: " + bill.ToString("c"));
            WriteLine("The total amount of the tip is: " + tip.ToString("c"));
            WriteLine("Thetip percentage of the bill is: " + tipPercentage.ToString("c"));
            WriteLine("The total amount of the bill is: " + totalBill.ToString("c"));
        }
    }
}
