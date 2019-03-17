using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Input size of arrays: ");
           
            //Create 3 arrays;
            int sizeArrays = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[sizeArrays];
            int[] secondArray = RandomArray(sizeArrays, 0, 100); //Create random array;
            int[] resultArray = new int[sizeArrays];

            for (int i = 0; i < sizeArrays; i++)                 //Input first array;
            {
                Console.Write($"Input {i+1} number :");
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }
                       
            for (int i = 0; i < sizeArrays; i++)
            {
                resultArray[i] = firstArray[i] + secondArray[i];
            }

            Console.Write("First array  :");
            OutputArray(firstArray);
            Console.Write("Second array :");
            OutputArray(secondArray);
            Console.Write("Result array :");
            OutputArray(resultArray);
            
            Console.ReadKey();
        }

        static void OutputArray(int[] array)
        {
            foreach (int p in array) Console.Write("{0,3}",p);
            Console.WriteLine();
        }

        static int[] RandomArray(int size, int minValue, int maxValue)
        {
            int[] tempArray = new int[size];
            Random rand = new Random(minValue);
            for (int i = 0; i < size; i++) tempArray[i] = rand.Next(maxValue);
            
            return tempArray;
        }
    }
}
