using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lc_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            String inputString;
            inputString = Console.ReadLine();
            Console.WriteLine(inputString.Five());
            Console.ReadKey();
        }
    }
    static class StringExtension
    {
        public static string Five(this String str)
        {
            return str.Substring(0, 5) + "...";
        }
    }
}
