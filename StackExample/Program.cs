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
            stackEx.push(1);
            stackEx.push("Intel");
            stackEx.push(true);

            Console.WriteLine(stackEx.pop());
            Console.WriteLine(stackEx.pop());
            Console.WriteLine(stackEx.pop());

            Console.ReadKey();

        }
    }
}
