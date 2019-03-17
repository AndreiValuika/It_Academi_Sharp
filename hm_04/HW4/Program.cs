using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ch = 'z'; ch >= 'a'; Console.WriteLine(ch--)); //Just for fun :)

            for (char ch = 'z'; ch >= 'a'; ch--)
                Console.Write(ch);
            Console.ReadKey();
        }
    }
}
