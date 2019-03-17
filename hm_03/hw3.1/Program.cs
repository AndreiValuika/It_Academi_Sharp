using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {

            int menuItem = 0;

            while (menuItem != 5)
            {

                menuItem = MyMenu();
                switch (menuItem)
                {
                    case 1:
                        FirstTask();
                        break;
                    case 2:
                        SecondTask();
                        break;
                    case 3:
                        ThirdTask();
                        break;
                    case 4:
                        FoursTask();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Error! Press any key to repeat...");
                        Console.ReadKey();
                        break;
                }
            }

        }

        static int MyMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - First task.");
            Console.WriteLine("2 - Second task.");
            Console.WriteLine("3 - Third task.");
            Console.WriteLine("4 - Fours task.");
            Console.WriteLine("5 - Exit.");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int SumOfAB()
        {
            Int32 a, b;
            Console.Write("Input first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number:");
            b = Convert.ToInt32(Console.ReadLine());

            return a + b;
        }

        static void FirstTask()
        {
            int sum;
            Console.Clear();
            Console.WriteLine("First task.");

            sum = SumOfAB();
            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        static void SecondTask()
        {
            int sum;
            Console.Clear();
            Console.WriteLine("Second task.");

            sum = SumOfAB();

            Console.Write("Input sum:");
            if (Convert.ToInt32(Console.ReadLine()) == sum) Console.WriteLine("Rigth!");
            else Console.WriteLine("Wrong!");

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }
        static void ThirdTask()
        {
            int sum;

            Console.Clear();
            Console.WriteLine("Third task.");

            sum = SumOfAB();

            Console.Write("Input sum:");
            int inSum = Convert.ToInt32(Console.ReadLine());
            if (inSum == sum) Console.WriteLine("Rigth!");
            else
            {
                Console.WriteLine("Wrong!");
                if (inSum > sum) Console.WriteLine("Must be less!");
                else Console.WriteLine("Must be more!");
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }
        static void FoursTask()
        {
            int a, b, rez;
            Console.Clear();
            Console.WriteLine("Fours task.");

            Console.Write("Input first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input arithmetic action + or - :");
            string ch = Console.ReadLine();

            if (ch == "+") rez = a + b;
            else if (ch == "-") rez = a - b;
            else
            {
                Console.WriteLine("Error! \nPress any key to repeat..");
                Console.ReadKey();
                return;
            }


            Console.Write("Input rezult:");
            int inSum = Convert.ToInt32(Console.ReadLine());

            if (inSum == rez) Console.WriteLine("Rigth!");
            else
            {
                Console.WriteLine("Wrong!");
                if (inSum > rez) Console.WriteLine("Must be less!");
                else Console.WriteLine("Must be more!");
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }
    }
}
