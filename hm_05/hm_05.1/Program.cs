using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Input size of arrays: ");

            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[sizeArray];

            for (int i = 0; i < sizeArray-1; i++)                 //Input array;
            {
                Console.Write($"Input {i + 1} number :");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input additional number :");
            int adNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("And position :");
            int numPosition = Convert.ToInt32(Console.ReadLine());

            for (int i = sizeArray - 1; i >= numPosition; i--)
                myArray[i] = myArray[i - 1]; //Shift numbers;
            myArray[numPosition - 1] = adNum; //Input additional number;

            Console.Write("Result array :");
            foreach (int p in myArray) Console.Write("{0,3}", p);
            Console.WriteLine();

            int tempNum;
            for (int i = 0; i < (sizeArray / 2); i++) //Revers ;
            {
                tempNum = myArray[i];
                myArray[i] = myArray[sizeArray - i-1];
                myArray[sizeArray - i - 1] = tempNum;
            }
 
            Console.Write("Revers array :");
            foreach (int p in myArray) Console.Write("{0,3}", p);
            Console.WriteLine();

            Console.WriteLine("Press any key.....");
            Console.ReadKey();
        }
    }
}
