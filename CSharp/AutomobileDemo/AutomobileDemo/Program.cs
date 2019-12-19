using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace AutomobileDemo
{
    class Program
    {
        //const int DEMO1ARRAYSIZE = 8;
        //const int DEMO2ARRAYSIZE = 4;
        //Automobile[] demo1Array = new Automobile[DEMO1ARRAYSIZE];
        //Automobile[] demo2Array = new Automobile[DEMO2ARRAYSIZE];
        public static ArrayList demo1Array = new ArrayList();
        public static ArrayList demo2Array = new ArrayList();

        static void Main(string[] args)
        {

            presentMenu();
        }

        static void presentMenu()
        {

            int menuChoice = 0;

            WriteLine("\nEnter a 1 to enter data for 8 vehicles");
            WriteLine("\nEnter a 2 to enter data for 4 financed vehicle.");
            WriteLine("\nEnter a 3 to quit the program");
            WriteLine("");
            menuChoice = Convert.ToInt16(ReadLine());

            while ((menuChoice != 1) && (menuChoice != 2) && (menuChoice != 3))
            {
                Console.Clear();
                presentMenu();
            }

            switch (menuChoice)
            {
                case 1:
                    for (int runs = 0; runs < 8; runs++)
                    {
                        Console.Clear();
                        WriteLine("Car " + (runs + 1));
                        choiceAutomobileDemo();
                        WriteLine();
                        //iterateDemo1();
                    }

                    demo1Array.Sort();

                    iterateDemo1();

                    presentMenu();

                    break;

                case 2:
                    for (int runs = 0; runs < 4; runs++)
                    {
                        choiceAutomobileDemo2();
                    }

                    iterateDemo2();

                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        public static void choiceAutomobileDemo()
        {
            buildGenericObject(1);
        }

        static void choiceAutomobileDemo2()
        {
            Console.Clear();

            buildGenericObject(2);

            presentMenu();
        }

        public static void buildGenericObject(int code)
        {
            int idNum = 0;
            string enteredIdNum = "";
            string enteredCarYear = "";
            string enteredCarPrice = "";
            string make = "";
            int year = 0;
            int price = 0;
            string total = "";

            writeIdNumber();

            void writeIdNumber()
            {
                Write("Enter ID Number: ");
                enteredIdNum = ReadLine();
                bool idFlag = false;

                idFlag = int.TryParse(enteredIdNum, out idNum);
                if (!idFlag)
                {
                    idNum = -999;
                }

                //if (!(demo1Array.Contains(idNum)))
                //{
                //    total += idNum.ToString() + "\n";
                //}
                //else
                //{
                //    writeIdNumber();
                //}

                if (demo1Array.Contains(idNum))
                {
                    writeIdNumber();
                }
                else
                {
                    total += idNum.ToString() + "\n";
                }
            }
            

            Write("Enter Car Make: ");
            make = ReadLine().ToUpper();
            total += make + "\n";

            Write("Enter Car Year: ");
            enteredCarYear = ReadLine();
            bool yearFlag = false;

            yearFlag = int.TryParse(enteredCarYear, out year);
            if (!yearFlag)
            {
                year = -999;
            }
            total += year.ToString() + "\n";

            Write("Enter Car Price (1 - 10,000): ");
            enteredCarPrice = ReadLine();
            bool priceFlag = false;

            priceFlag = int.TryParse(enteredCarPrice, out price);
            if (!priceFlag)
            {
                price = -999;
            }
            total += price.ToString("f2") + "\n";

            switch (code)
            {
                case 1:
                    inputDemo1Properties(total);
                    break;
                case 2:
                    inputFinancedAutomobile(total);
                    break;
                default:
                    break;
            }
        }

        public static void inputDemo1Properties(string t)
        {
            instantiateDemo1(t);
        }

        public static void instantiateDemo1(string t)
        {
            string[] values = t.Split('\n');
            Automobile am = null;

            am = new Automobile(Convert.ToInt32(values[0]), values[1], Convert.ToInt32(values[2]), Convert.ToDouble(values[3]));

            fillUpDemo1Array(am);
        }

        public static void fillUpDemo1Array(Automobile am)
        {
            demo1Array.Add(am);
        }


        public static void inputFinancedAutomobile(string t)
        {
            string enteredFinance = "";
            string enteredInterestRate = "";
            double finance = 0;
            double interest = 0;
            string total = "";

            financed();

            void financed()
            {
                Write("Enter Finance Amount: ");
                enteredFinance = ReadLine();
                bool financeFlag = false;
                string[] values = t.Split('\n');

                financeFlag = Double.TryParse(enteredFinance, out finance);
                if (!financeFlag)
                {
                    finance = -999;
                }

                if (!(Convert.ToInt32(enteredFinance) > Convert.ToDouble(values[3])))
                {
                    total += finance.ToString("f2") + "\n";
                }
                else
                {
                    financed();
                }
            }

            Write("Enter Interest Rate (0.01 - 2): ");
            enteredInterestRate = ReadLine();
            bool interestFlag = false;

            interestFlag = Double.TryParse(enteredInterestRate, out interest);
            if (!interestFlag)
            {
                interest = -999;
            }
            total += interest.ToString("f2") + "\n";

            instantiateDemo2(t);
        }

        public static void instantiateDemo2(string t)
        {
            string[] values = t.Split('\n');
            FinancedAutomobile amf = null;

            amf = new FinancedAutomobile(Convert.ToInt32(values[0]), values[1], Convert.ToInt32(values[2]), Convert.ToDouble(values[3]), Convert.ToDouble(values[4]), Convert.ToDouble(values[5]));
            
            fillUpDemo2Array(amf);
        }

        public static void fillUpDemo2Array(FinancedAutomobile amf)
        {
            demo2Array.Add(amf);
        }

        public static void iterateDemo1()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < demo1Array.Count; ++lcv)
            {
                WriteLine("Automobile " + (lcv + 1) + ":\n" + demo1Array[lcv].ToString());
                WriteLine();
            }
            WriteLine();
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }

        public static void iterateDemo2()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < demo2Array.Count; ++lcv)
            {
                WriteLine("Financed Automobile " + lcv + ":\n" + demo2Array[lcv].ToString());
            }
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }
    }
}
