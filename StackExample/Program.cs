using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StackEx stackEx = new StackEx();
            stackEx.Push(1);
            stackEx.Push("Intel");
            stackEx.Push(true);

            Console.WriteLine("----------------");
            Console.WriteLine("Use foreach:");
            foreach (var item in stackEx)
            {
                Console.WriteLine(item.ToString()); 
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Use stack.Peek");
            Console.WriteLine(stackEx.Peek());
            Console.WriteLine(stackEx.Peek());
            Console.WriteLine(stackEx.Peek());

            Console.WriteLine("----------------");
            Console.WriteLine("Use stack.Pop:");
            Console.WriteLine(stackEx.Pop());
            Console.WriteLine(stackEx.Pop());
            Console.WriteLine(stackEx.Pop());

            Console.Read();

        }
    }
}
