using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Test line loading from file \"Test.txt\"");

            String myString;

            try
            {
                StreamReader stReader = new StreamReader(@"..\..\Test.txt");// load string from file; 
                myString = stReader.ReadLine();

                String[] arrayString = myString.Split(';');  // separation string;

                if (arrayString.Length == 1)                 // if line doesn't contain ";"
                    throw new Exception("Wrong line!");      // generate exeption;

                for (int i = 0; i < arrayString.Length; i++) // replace letters;
                    arrayString[i]=arrayString[i].Replace('о', 'а'); 

                Console.WriteLine("Start line:");
                Console.WriteLine(myString);
                Console.WriteLine();

                Console.WriteLine("Result:");
                foreach (String st in arrayString) Console.WriteLine(st);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press any key....");
            Console.ReadKey();
        }
    }
}
