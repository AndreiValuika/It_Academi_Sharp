using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int startCount = Convert.ToInt32(Console.ReadLine());

            UniqueItem.id = startCount;

            for (int i = 0; i < 10; i++)
            {
                new UniqueItem();
            }

            Console.WriteLine(UniqueItem.id);

            Console.ReadKey();

        }
    }

   class UniqueItem
    {
        public static int id { get; set; }

        public UniqueItem()
        {
            id++;
        }
    }
}
