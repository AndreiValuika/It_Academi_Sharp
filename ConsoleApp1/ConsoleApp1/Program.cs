using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            Console.ReadKey();
        }
        static void EmptyArray()
        {
            int[] emptyArray = new int[0];
            Console.Write("Length of array = :");
            Console.WriteLine(emptyArray.Length);
        }


       
    }

}
