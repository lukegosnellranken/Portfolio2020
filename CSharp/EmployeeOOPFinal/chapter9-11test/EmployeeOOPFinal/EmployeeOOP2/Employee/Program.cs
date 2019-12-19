using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

//************************************************
//  Due 12 noon Thursday, 3/7/2019.
//************************************************

namespace Employee
{   //  Begin namespace Employee

    class Program
    {   //  Begin class Program

        //Create global array lists
        public static ArrayList hourlyArray = new ArrayList();
        public static ArrayList salariedArray = new ArrayList();
        public static ArrayList pieceWorkerArray = new ArrayList();
        public static ArrayList commisionArray = new ArrayList();

        //global array list consts
        const double WEEKSINYEAR = 52.1429;


        static void Main(string[] args)
        {   //  Begin static void Main(string[] args)
            //  Call to Full-Arg Constructor

            ///HOURLY FLUFF///

            var goodNoOTEmployee0 = new Hourly();

            //fills goodNoOTEmployee0 with defaults

            //  Call to No-Arg Constructor
            var goodNoOTEmployee1 = new Hourly();

            //  Calls to associated setters
            goodNoOTEmployee1.FirstName = "Jeffrey";
            goodNoOTEmployee1.MiddleInit = "P";
            goodNoOTEmployee1.LastName = "Scott";
            goodNoOTEmployee1.IsUnion = false;
            goodNoOTEmployee1.EmpNum = 1111;
            goodNoOTEmployee1.HoursWorked = 40.0;
            goodNoOTEmployee1.HourlyRate = 25.0;
            goodNoOTEmployee1.CalculateEarnings();



            //  Call to No-Arg Constructor
            var goodOTEmployee = new Hourly();

            //  Calls to associated setters
            goodOTEmployee.FirstName = "Mary";
            goodOTEmployee.MiddleInit = "K";
            goodOTEmployee.LastName = "Jones";
            goodOTEmployee.IsUnion = true;
            goodOTEmployee.EmpNum = 2222;
            goodOTEmployee.HoursWorked = 50.0;
            goodOTEmployee.HourlyRate = 20.0;
            goodOTEmployee.CalculateEarnings();



            //  Call to No-Arg Constructor
            var badFNEmployee = new Hourly();

            //  Calls to associated setters
            badFNEmployee.FirstName = "";
            badFNEmployee.MiddleInit = "G";
            badFNEmployee.LastName = "Wilson";
            badFNEmployee.IsUnion = true;
            badFNEmployee.EmpNum = 3333;
            badFNEmployee.HoursWorked = 45.0;
            badFNEmployee.HourlyRate = 30.0;
            badFNEmployee.CalculateEarnings();

            

            //  Call to No-Arg Constructor
            var badMIEmployee = new Hourly();

            //  Calls to associated setters
            badMIEmployee.FirstName = "Kiley";
            badMIEmployee.MiddleInit = "";
            badMIEmployee.LastName = "Fleming";
            badMIEmployee.IsUnion = false;
            badMIEmployee.EmpNum = 4444;
            badMIEmployee.HoursWorked = 40.0;
            badMIEmployee.HourlyRate = 40.0;
            badMIEmployee.CalculateEarnings();

            

            //  Call to No-Arg Constructor
            var badLNEmployee = new Hourly();

            //  Calls to associated setters
            badLNEmployee.FirstName = "John";
            badLNEmployee.MiddleInit = "J";
            badLNEmployee.LastName = "";
            badLNEmployee.IsUnion = true;
            badLNEmployee.EmpNum = 5555;
            badLNEmployee.HoursWorked = 10.0;
            badLNEmployee.HourlyRate = 10.0;
            badLNEmployee.CalculateEarnings();

            

            //  Call to No-Arg Constructor
            var badENEmployee = new Hourly();

            //  Calls to associated setters
            badENEmployee.FirstName = "Mark";
            badENEmployee.MiddleInit = "B";
            badENEmployee.LastName = "Bronson";
            badENEmployee.IsUnion = false;
            badENEmployee.EmpNum = 66666;
            badENEmployee.HoursWorked = 10.0;
            badENEmployee.HourlyRate = 10.0;
            badENEmployee.CalculateEarnings();

            ///END HOURLY FLUFF///

            //  Hourly Exception Testing
            //OOR hours worked
            var badHWEmployee = new Hourly();

            try
            {
                //  Calls to associated setters
                badHWEmployee.FirstName = "Jerry";
                badHWEmployee.MiddleInit = "J";
                badHWEmployee.LastName = "Granger";
                badHWEmployee.IsUnion = false;
                badHWEmployee.EmpNum = 8888;
                badHWEmployee.HoursWorked = -100.0;
                badHWEmployee.HourlyRate = 10;
                badHWEmployee.CalculateEarnings();
            }
            catch (OutOfRangeHoursException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //OOR hourly rate
            var badHREmployee = new Hourly();

            try
            {
                //  Calls to associated setters
                badHREmployee.FirstName = "Cari";
                badHREmployee.MiddleInit = "J";
                badHREmployee.LastName = "Granger";
                badHREmployee.IsUnion = false;
                badHREmployee.EmpNum = 8888;
                badHREmployee.HoursWorked = 50.0;
                badHREmployee.HourlyRate = -10000.0;
                badHREmployee.CalculateEarnings();
            }
            catch (OutOfRangeHourlyRateException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //Salary Exception Testing
            var badWSalaryEmployee = new Salaried();

            try
            {
                badWSalaryEmployee.FirstName = "John";
                badWSalaryEmployee.MiddleInit = "M";
                badWSalaryEmployee.LastName = "Stokes";
                badWSalaryEmployee.IsUnion = false;
                badWSalaryEmployee.EmpNum = 1111;
                badWSalaryEmployee.WeeklySalary = -10.0;
                badWSalaryEmployee.CalculateEarnings();
            }
            catch (OutOfRangeWeeklySalaryException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //PieceWorker Exception Testing
            //OOR pieces per hour
            var badPPHEmployee = new PieceWorker();

            try
            {
                badPPHEmployee.FirstName = "Alyssa";
                badPPHEmployee.MiddleInit = "T";
                badPPHEmployee.LastName = "Stockton";
                badPPHEmployee.IsUnion = false;
                badPPHEmployee.EmpNum = 1111;
                badPPHEmployee.PiecesPerHour = -10;
                badPPHEmployee.PricePerPiece = .5;
                badPPHEmployee.CalculateEarnings();
            }
            catch (OutOfRangePiecesPerHourException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //OOR price per piece
            var badPPPEmployee = new PieceWorker();

            try
            {
                badPPPEmployee.FirstName = "Dwayne";
                badPPPEmployee.MiddleInit = "S";
                badPPPEmployee.LastName = "Johnson";
                badPPPEmployee.IsUnion = false;
                badPPPEmployee.EmpNum = 2222;
                badPPPEmployee.PiecesPerHour = 50;
                badPPPEmployee.PricePerPiece = -10.0;
                badPPPEmployee.CalculateEarnings();
            }
            catch (OutOfRangePricePerPieceException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //Commission Exception Testing
            //OOR commission rate
            var badCREmployee = new Commission();

            try
            {
                badCREmployee.FirstName = "Josh";
                badCREmployee.MiddleInit = "T";
                badCREmployee.LastName = "Lang";
                badCREmployee.IsUnion = false;
                badCREmployee.EmpNum = 1111;
                badCREmployee.CommissionRate = -10.0;
                badCREmployee.WeeklySales = 5000;
                badCREmployee.CalculateEarnings();
            }
            catch (OutOfRangeCommissionRateException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            //OOR weekly sales
            var badWSalesEmployee = new Commission();

            try
            {
                badWSalesEmployee.FirstName = "Liza";
                badWSalesEmployee.MiddleInit = "L";
                badWSalesEmployee.LastName = "Koshy";
                badWSalesEmployee.IsUnion = false;
                badWSalesEmployee.EmpNum = 2222;
                badWSalesEmployee.CommissionRate = .20;
                badWSalesEmployee.WeeklySales = -10;
                badWSalesEmployee.CalculateEarnings();
            }
            catch (OutOfRangeWeeklySalesException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }




            //  Call to No-Arg Commission Constructor
            var commEmployeeNoArg = new Commission();

            //  Call to getter
            //WriteLine("Employee 9:\n" + commEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var commEmployeeFullArg = new Commission("John", "J", "Jennings", false, 98766, 0.2, 2500);

            //  Call to getter
            //WriteLine("Employee 10:\n" + commEmployeeFullArg);

            //  Call to No-Arg Salaried Constructor
            var salEmployeeNoArg = new Salaried();

            //  Call to getter
            //WriteLine("Employee 11:\n" + salEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var salEmployeeFullArg = new Salaried("Helen", "H", "Hansen", false, 87654, 5500);

            //  Call to getter
            //WriteLine("Employee 12:\n" + salEmployeeFullArg);

            //  Call to No-Arg Salaried Constructor
            //var pwEmployeeNoArg = new PieceWorker();

            //  Call to getter
            // WriteLine("Employee 13:\n" + pwEmployeeNoArg);

            //  Call to No-Arg Commission Constructor
            //var pwEmployeeFullArg = new PieceWorker("Frank", "F", "Phillips", true, 76543, 58, 0.33);

            //  Call to getter
            //WriteLine("Employee 14:\n" + pwEmployeeFullArg);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //CREATE DEFAULT OBJECTS FOR EACH ARRAY LIST (5 each)

            //hourlyArray defaults
            //fluff
            hourlyArray.Add(goodNoOTEmployee0);
            hourlyArray.Add(goodNoOTEmployee1);
            hourlyArray.Add(badENEmployee);
            hourlyArray.Add(badFNEmployee);

            //exceptions
            hourlyArray.Add(badHREmployee);
            hourlyArray.Add(badHWEmployee);

            //salariedArray defaults
            salariedArray.Add(badWSalaryEmployee);
            salariedArray.Add(salEmployeeNoArg);

            //pieceWorkerArray defaults
            pieceWorkerArray.Add(badPPHEmployee);
            pieceWorkerArray.Add(badPPPEmployee);

            //commissionArray defaults
            commisionArray.Add(badCREmployee);
            commisionArray.Add(badWSalesEmployee);
            commisionArray.Add(commEmployeeNoArg);


            presentMenu();

        }   
        //  End   static void Main(string[] args)

        static void presentMenu()
        {

            int menuChoice = 0;

            WriteLine("\nEnter a 1 to create a new hourlyEmployee");
            WriteLine("\nEnter a 2 to create a new salariedEmployee");
            WriteLine("\nEnter a 3 to create a new pieceWorkerEmployee");
            WriteLine("\nEnter a 4 to create a new commissionEmployee");
            WriteLine("\nEnter a 5 to iterate through (print out) the complete hourlyEmployee arraylist");
            WriteLine("\nEnter a 6 to iterate through (print out) the complete salariedEmployee arraylist");
            WriteLine("\nEnter a 7 to iterate through (print out) the complete pieceWorkerEmployee arraylist");
            WriteLine("\nEnter an 8 to iterate through (print out) the complete commissionEmployee arraylist");
            WriteLine("\nEnter a 9 to quit the program");
            WriteLine("");
            menuChoice = Convert.ToInt16(ReadLine());

            while ((menuChoice != 1) && (menuChoice != 2) && (menuChoice != 3) && (menuChoice != 4) && (menuChoice != 5) && (menuChoice != 6) && (menuChoice != 7) && (menuChoice != 8) && (menuChoice != 9))
            {
                //WriteLine("Please enter a number 1-9. Press enter now.");
                //ReadLine();
                Console.Clear();
                presentMenu();
            }

            switch (menuChoice)
            {
                case 1:
                    createNewHourlyEmployee();
                    break;

                case 2:
                    createNewSalariedEmployee();
                    break;

                case 3:
                    createNewPieceWorkerEmployee();
                    break;

                case 4:
                    createNewCommissionEmployee();
                    break;

                case 5:
                    iteratehourlyEmployee();
                    break;

                case 6:
                    iterateSalariedEmployee();
                    break;

                case 7:
                    iteratePieceWorkerEmployee();
                    break;

                case 8:
                    iterateCommissionEmployee();
                    break;

                case 9:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        public static void createNewHourlyEmployee()
        {
            Console.Clear();

            buildGenericObject(1);

            presentMenu();
        }

        static void createNewSalariedEmployee()
        {
            Console.Clear();

            buildGenericObject(2);

            presentMenu();
        }

        static void createNewPieceWorkerEmployee()
        {
            Console.Clear();

            buildGenericObject(3);

            presentMenu();
        }

        static void createNewCommissionEmployee()
        {
            Console.Clear();

            buildGenericObject(4);

            presentMenu();
        }

        public static void buildGenericObject(int code)
        {
            string first = "";
            string mid = "";
            char mi = ' ';
            string last = "";
            string unionStr = "";
            bool union = false;
            int enumb = 0;
            string thenum = "";
            string total = "";

            Write("Enter a first name: ");
            first = ReadLine().ToUpper();
            total += first + "\n";

            Write("Enter a middle initial: ");
            mid = ReadLine().ToUpper();
            mi = mid[0];
            total += mi + "\n";

            Write("Enter a last name: ");
            last = ReadLine().ToUpper();
            total += last + "\n";

            Write("Enter union status (true or false): ");

            unionStr = ReadLine();
            if ((unionStr != "true") && (unionStr != "false"))
            {
                union = false;
            }
            else
            {
                union = Convert.ToBoolean(unionStr);
            }
            total += union + "\n";

            Write("Enter employee number: ");
            thenum = ReadLine();
            bool flag = false;

            flag = int.TryParse(thenum, out enumb);
            if (!flag)
            {
                enumb = -999;
            }
            total += enumb.ToString() + "\n";

            switch (code)
            {
                case 1:
                    inputHoursWorkedAndHourlyRate(total);
                    break;
                case 2:
                    inputSalariedEmployee(total);
                    break;
                case 3:
                    inputPieceWorkerEmployee(total);
                    break;
                case 4:
                    inputCommissionEmployee(total);
                    break;
                default:
                    break;
            }
        }

        //hourly
        public static void inputHoursWorkedAndHourlyRate(string t)
        {
            string hwstr = "";
            string hrstr = "";
            double hw = 0.0;
            double hr = 0.0;

            Write("Enter hours worked (0-84): ");
            hwstr = ReadLine();
            bool flag = false;

            flag = double.TryParse(hwstr, out hw);
            if (!flag)
            {
                hw = -999;
            }
            else
            {
                hw = Convert.ToDouble(hwstr);
            }

            Write("Enter hourly rate (0-100): ");
            hrstr = ReadLine();
            flag = false;

            flag = double.TryParse(hrstr, out hr);
            if (!flag)
            {
                hr = -999;
            }
            else
            {
                hr = Convert.ToDouble(hrstr);
            }

            t += hw.ToString("f2") + "\n" +
                 hr.ToString("f2") + "\n";

            instantiateHourlyEmployee(t);
        }

        public static void instantiateHourlyEmployee(string t)
        {
            string[] values = t.Split('\n');
            WriteLine("There are {0} elements in the values array\n", values.Length);
            Hourly h = null;

            h = new Hourly(values[0], values[1], values[2],
                           Convert.ToBoolean(values[3]),
                           Convert.ToInt32(values[4]),
                           Convert.ToDouble(values[5]),
                           Convert.ToDouble(values[6]));

            fillUpHourlyArrayList(h);
        }

        public static void fillUpHourlyArrayList(Hourly h)
        {

            hourlyArray.Add(h);
           
            try
            {
                hourlyArray.Add(h.HourlyRate);
            }
            catch (OutOfRangeHourlyRateException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
                ReadLine();
            }

            h.CalculateEarnings();
        }



        //salaried
        public static void inputSalariedEmployee(string t)
        {
            string wsstr = "";
            string ysstr = "";
            double ws = 0.0;
            double ys = 0.0;

            Write("Enter weekly salary (1000-20000): ");
            wsstr = ReadLine();
            bool flag = false;

            flag = double.TryParse(wsstr, out ws);
            if (!flag)
            {
                ws = -999;
            }
            else
            {
                ws = Convert.ToDouble(wsstr);
            }


            ysstr = Convert.ToString(ws * WEEKSINYEAR);
            flag = false;

            flag = double.TryParse(ysstr, out ys);
            if (!flag)
            {
                ys = -999;
            }
            else
            {
                ys = Convert.ToDouble(ysstr);
            }

            t += ws.ToString("f2") + "\n" +
                 ys.ToString("f2") + "\n";

            instantiateSalariedEmployee(t);
        }

        public static void instantiateSalariedEmployee(string t)
        {
            string[] values = t.Split('\n');
            WriteLine("There are {0} elements in the values array\n", values.Length);
            Salaried s = null;

            s = new Salaried(values[0], values[1], values[2],
                           Convert.ToBoolean(values[3]),
                           Convert.ToInt32(values[4]),
                           Convert.ToDouble(values[5]),
                           Convert.ToDouble(values[6]));

            fillUpSalariedArrayList(s);
        }

        public static void fillUpSalariedArrayList(Salaried s)
        {
            s.CalculateEarnings();
            salariedArray.Add(s);
        }


        //Commission
        public static void inputCommissionEmployee(string t)
        {
            string crstr = "";
            string wsstr = "";
            string gpstr = "";
            double cr = 0.0;
            double ws = 0.0;
            double gp = 0.0;

            Write("Enter Commission Rate(0.10-0.33): ");
            crstr = ReadLine();
            bool flag = false;

            flag = double.TryParse(crstr, out cr);
            if (!flag)
            {
                cr = -999;
            }
            else
            {
                cr = Convert.ToDouble(crstr);
            }

            Write("Enter weekly sales (0-10000): ");
            wsstr = ReadLine();
            flag = false;

            flag = double.TryParse(wsstr, out ws);
            if (!flag)
            {
                ws = -999;
            }
            else
            {
                ws = Convert.ToDouble(wsstr);
            }

            gpstr = Convert.ToString(cr * ws);
            flag = false;

            flag = double.TryParse(gpstr, out gp);
            if (!flag)
            {
                gp = -999;
            }
            else
            {
                gp = Convert.ToDouble(gpstr);
            }

            t += cr.ToString("f2") + "\n" +
                 ws.ToString("f2") + "\n" +
                 gp.ToString("f2") + "\n";

            instantiateCommissionEmployee(t);
        }

        public static void instantiateCommissionEmployee(string t)
        {
            string[] values = t.Split('\n');
            WriteLine("There are {0} elements in the values array\n", values.Length);
            Commission c = null;

            c = new Commission(values[0], values[1], values[2],
                           Convert.ToBoolean(values[3]),
                           Convert.ToInt32(values[4]),
                           Convert.ToDouble(values[5]),
                           Convert.ToDouble(values[6]),
                           Convert.ToDouble(values[7]));

            fillUpCommissionArrayList(c);
        }

        public static void fillUpCommissionArrayList(Commission c)
        {
            c.CalculateEarnings();
            commisionArray.Add(c);
        }

        //PieceWorker
        public static void inputPieceWorkerEmployee(string t)
        {
            string phstr = "";
            string ppstr = "";
            string gpstr = "";
            double ph = 0.0;
            double pp = 0.0;
            double gp = 0.0;

            Write("Enter Pieces Per Hour (0-100): ");
            phstr = ReadLine();
            bool flag = false;

            flag = double.TryParse(phstr, out ph);
            if (!flag)
            {
                ph = -999;
            }
            else
            {
                ph = Convert.ToDouble(phstr);
            }

            Write("Enter Price Per Piece (0.0-1.0): ");
            ppstr = ReadLine();
            flag = false;

            flag = double.TryParse(ppstr, out pp);
            if (!flag)
            {
                pp = -999;
            }
            else
            {
                pp = Convert.ToDouble(ppstr);
            }

            gpstr = Convert.ToString(ph * pp);
            flag = false;

            flag = double.TryParse(gpstr, out gp);
            if (!flag)
            {
                gp = -999;
            }
            else
            {
                gp = Convert.ToDouble(gpstr);
            }

            t += ph.ToString() + "\n" +
                 pp.ToString("f2") + "\n" +
                 gp.ToString("f2") + "\n";

            instantiatePieceWorkerEmployee(t);
        }

        public static void instantiatePieceWorkerEmployee(string t)
        {
            string[] values = t.Split('\n');
            WriteLine("There are {0} elements in the values array\n", values.Length);
            PieceWorker p = null;

            p = new PieceWorker(values[0], values[1], values[2],
                           Convert.ToBoolean(values[3]),
                           Convert.ToInt32(values[4]),
                           Convert.ToInt32(values[5]),
                           Convert.ToDouble(values[6]),
                           Convert.ToDouble(values[7]));

            fillUpPieceWorkerArrayList(p);
        }

        public static void fillUpPieceWorkerArrayList(PieceWorker p)
        {
            p.CalculateEarnings();
            pieceWorkerArray.Add(p);
        }

        ///ITERATE METHODS

        public static void iteratehourlyEmployee()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < hourlyArray.Count; ++lcv)
            {
                WriteLine("Employee " + lcv + ":\n" + hourlyArray[lcv].ToString());
            }
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }

        public static void iterateSalariedEmployee()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < salariedArray.Count; ++lcv)
            {
                WriteLine("Employee " + lcv + ":\n" + salariedArray[lcv].ToString());
            }
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }

        public static void iteratePieceWorkerEmployee()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < pieceWorkerArray.Count; ++lcv)
            {
                WriteLine("Employee " + lcv + ":\n" + pieceWorkerArray[lcv].ToString());
            }
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }

        public static void iterateCommissionEmployee()
        {
            int lcv = 0;
            Console.Clear();

            for (lcv = 0; lcv < commisionArray.Count; ++lcv)
            {
                WriteLine("Employee " + lcv + ":\n" + commisionArray[lcv].ToString());
            }
            WriteLine("Press enter");
            ReadLine();
            Console.Clear();
            presentMenu();
        }

    }   //  End   class Program
}   //  End   namespace Employee
