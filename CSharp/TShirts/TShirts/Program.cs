using System;
using static System.Console;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRICE = 14.99;
            const double TAX = 0.08;
            var name = "";
            var address = "";
            var city = "";
            var state = "";
            var zip = "";
            double shirts = 0;
            double total = 0.0;
            double personalTax = 0.0;
            double grandTotal = 0.0;

            Write(" Enter your name: ");
            name = Convert.ToString(ReadLine());

            Write(" Street address: ");
            address = Convert.ToString(ReadLine());

            Write(" City: ");
            city = Convert.ToString(ReadLine());

            Write(" State: ");
            state = Convert.ToString(ReadLine());

            Write(" Zip: ");
            zip = Convert.ToString(ReadLine());

            Write(" How many T-Shirts did you want to order? ");
            shirts = Convert.ToDouble(ReadLine());

            total = (shirts * PRICE);
            personalTax = (total * TAX);
            grandTotal = (total + (total * TAX));

            WriteLine("\n\n Reciept for: \n " + name);
            WriteLine(" " + address);
            WriteLine(" " + city + ", " + state + " " + zip);
            WriteLine(" " + shirts + " shirts ordered @ " + PRICE.ToString("C2") + " each");
            WriteLine("\n Total:\t " + total.ToString("C2"));
            WriteLine(" Tax:\t " + personalTax.ToString("C2"));
            WriteLine("----------------");
            WriteLine(" Due:\t " + grandTotal.ToString("C2"));
            WriteLine(" Press any key to continue  .  .  .");


            ReadLine();
        }
    }
}
