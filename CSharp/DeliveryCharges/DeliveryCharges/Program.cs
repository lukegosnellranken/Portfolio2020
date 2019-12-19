using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        const int ARRAYSIZE = 10;

        static string[] zipCodes = { "63366", "54784", "57302", "22091", "55555", "20967", "10857", "88878", "99112", "10000" };
        static double[] charges = { 3.56, 4.78, 2.78, 9.5, 4.5, 3.24, 1.12, 4.98, 4.65, 6.62 };
        static Random random = new Random();

        static void Main(string[] args)
        {
            for (; ; )
            {
                userPrompt();
            }
        }

        static void userPrompt()
        {
            string userInput = "";

            Write("\nEnter a 5-digit zip code: ");
            userInput = ReadLine();

            double deliveryPrice = 0.0;

            if (isNumeric(userInput) && (userInput.Length == 5))
            {
                if (zipCodes.Contains(userInput))
                {

                    for (int i = 0; i < zipCodes.Length; i++)
                    {
                        if (zipCodes[i] == userInput)
                        {
                            deliveryPrice = charges[i];
                            break;
                        }
                    }

                    WriteLine("\nWe can make deliveries to " + userInput + ".");
                    WriteLine("\nThe price of delivery is $" + deliveryPrice + ".");
                }

                else
                {
                    WriteLine("\nSorry, we do NOT make deliveries to " + userInput + ".");
                }

                userPrompt();
            }

            else
            {
                userPrompt();
            }
        }



        static bool isNumeric(String input)
        {
            int test;
            return int.TryParse(input, out test);
        }
    }
}
