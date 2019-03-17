using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input \"w\" for UP, \"s\" for DOWN,\"a\" for LEFT,\"d\" for RIGHT :");
            String st =  Console.ReadLine();
            switch (st)
            {
                case "w":
                    Console.WriteLine("UP");
                    break;
                case "s":
                    Console.WriteLine("DOWN");
                    break;
                case "a":
                    Console.WriteLine("LEFT");
                    break;
                case "d":
                    Console.WriteLine("RIGHT");
                    break;
                default:
                    Console.WriteLine("Input error!");
                    break;
            }
                    Console.ReadKey();
        }
    }
}
