using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FineForOverdueBooks
{
    class Program
    {
        const double OVERDUEFINE1 = .10;
        const double OVERDUEFINE2 = .20;

        static void Main(string[] args)
        {
            int books = 0;
            int daysOverdue = 0;
            string dstr = "";
            string bstr = "";

            double totalFine = 0.0;

            Write("\nPlease enter the number of overdue books: ");
            bstr = ReadLine();
            Write("\nPlease enter the number of days overdue: ");
            dstr = ReadLine();

            if ((isNumeric(dstr)) && (isNumeric(bstr)))
            {
                books = Convert.ToInt32(bstr);
                daysOverdue = Convert.ToInt32(dstr);
                totalFine = calculateTotalFine(totalFine, books, daysOverdue);
            }

            WriteLine("\n" + books.ToString() + " books at " + daysOverdue.ToString() + " days overdue is " + totalFine.ToString("C") + ".");
            ReadLine();
        }

        static double calculateTotalFine(double totalFine, int books, int daysOverdue)
        {
            if (daysOverdue <= 7)
            {
                return totalFine = (books * daysOverdue * OVERDUEFINE1);
            }
            else
            {
                totalFine = (books * 7 * OVERDUEFINE1);
                return totalFine = (totalFine + (books * (daysOverdue-7) * OVERDUEFINE2));
            }
        }

        static bool isNumeric(String input)
        {
            int test;
            return int.TryParse(input, out test);
        }

    }
}
