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

            ArrayOF3();
            Console.ReadKey();
        }

        static void EmptyArray()
        {
            int[] emptyArray = new int[0];
            Console.Write("Length of array = :");
            Console.WriteLine(emptyArray.Length);
        }

        static void ArrayOF3()
        {
            object[] objArray = { 32, 'A', "Hello" };
            foreach (object o in objArray)
                Console.WriteLine(o);

            objArray[0] = (int)objArray[0] + 10;
            objArray[2] = (String)objArray[0] + ", guys!";

            foreach (object o in objArray)
                Console.WriteLine(o);
        }

      //  void RandomArray()
    }

}
