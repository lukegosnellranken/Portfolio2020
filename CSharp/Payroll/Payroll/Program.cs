using System;
using static System.Console;

namespace ProjectedRaisesInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName1 = "";
            var lastName1 = "";
            double hoursWorked1 = 0.0;
            double hourlyRate1 = 0.0;
            double grossPay1 = 0.0;
            var firstName2 = "";
            var lastName2 = "";
            double hoursWorked2 = 0.0;
            double hourlyRate2 = 0.0;
            double grossPay2 = 0.0;
            double totPayroll = 0.0;

            Write("Please enter first name for employee 1: ");
            firstName1 = Convert.ToString(ReadLine());

            Write("Please enter last name for employee 1: ");
            lastName1 = Convert.ToString(ReadLine());

            Write("Please enter hours worked for employee 1: ");
            hoursWorked1 = Convert.ToDouble(ReadLine());

            Write("Please enter hourly rate for employee 1: ");
            hourlyRate1 = Convert.ToDouble(ReadLine());

            grossPay1 = (hourlyRate1 * hoursWorked1);

            WriteLine("\n\t\t First name: " + firstName1
                + "\n\t\t Last name: " + lastName1
                + "\n\t\t Hours worked: " + hoursWorked1.ToString("F2")
                + "\n\t\t Hourly rate: " + hourlyRate1.ToString("C2")
                + "\n\t\t Gross pay: " + grossPay1.ToString("C2"));

            Write("\nPlease enter first name for employee 2: ");
            firstName2 = Convert.ToString(ReadLine());

            Write("Please enter last name for employee 2: ");
            lastName2 = Convert.ToString(ReadLine());

            Write("Please enter hours worked for employee 2: ");
            hoursWorked2 = Convert.ToDouble(ReadLine());

            Write("Please enter hourly rate for employee 2: ");
            hourlyRate2 = Convert.ToDouble(ReadLine());

            grossPay2 = (hourlyRate2 * hoursWorked2);

            WriteLine("\n\t\t First name: " + firstName2
                + "\n\t\t Last name: " + lastName2
                + "\n\t\t Hours worked: " + hoursWorked2.ToString("F2")
                + "\n\t\t Hourly rate: " + hourlyRate2.ToString("C2")
                + "\n\t\t Gross pay: " + grossPay2.ToString("C2"));

            totPayroll = (grossPay1 + grossPay2);

            WriteLine("\n\n\t\t Total gross pay: " + totPayroll.ToString("C2"));


            ReadLine();
        }
    }
}
