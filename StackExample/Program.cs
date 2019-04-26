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
            StackEx<int> stackEx = new StackEx<int>();
            stackEx.Push(1);
            stackEx.Push(2);
            stackEx.Push(3);

            Console.WriteLine("----------------");
            Console.WriteLine("Use foreach:");
            foreach (var item in stackEx)
            {
                Console.WriteLine(item + " Type = " + item.GetType().Name); 
            }

            StackEx<String> stringStack = stackEx.IntToString();

            Console.WriteLine("----------------");
            Console.WriteLine("Use foreach:");
            foreach (var item in stringStack)
            {
                Console.WriteLine(item + " Type = " + item.GetType().Name);
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
