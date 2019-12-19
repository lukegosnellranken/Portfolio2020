using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Custom Multiplication Table!");
            WriteLine("");
            Write("How many rows? : ");
            string rowStr = ReadLine();
            WriteLine("");
            Write("How many columns? : ");
            string columnStr = ReadLine();
            int row = Convert.ToInt32(rowStr);
            int column = Convert.ToInt32(columnStr);

            int i, k, p;

            WriteLine("");

            //top label/////////////////////
            for (i = 1; i <= (column + 1); i++)
            {
                if (i < 2)
                {
                    Write("{0, 5}", " ");
                }
                else
                {
                    Write("{0, 5}", (i-1) + "|");
                }
                
            }
            ////////////////////////////////
            WriteLine("");
            //top dashes////////////////////
            for (i = 1; i <= (column + 1); i++)
            {
                Write("{0, 5}", "-----");
            }
            ////////////////////////////////
            WriteLine("");
            WriteLine("");

            for (i = 1; i <= (row); i++)
            {
                Write("{0, 5}", i + "|"); //left label
                for (k = 1; k <= column; k++)
                {
                    p = i * k;

                    Write("{0, 5}",  p + "|");
                }

                WriteLine("");
            }

            ReadLine();
        }
    }
}
