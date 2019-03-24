﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Test line loading from file \"Test.txt\"");
            Console.WriteLine("Press any key....");
            Console.ReadKey();
            
            try
            {
                StreamReader stReader = new StreamReader(@"..\..\Test.txt");// load string from file; 
                String myString = stReader.ReadLine();
                stReader.Close();

                int menuItem = 0;
                while (menuItem != 6)
                {
                    {
                        int indexOfSpace = myString.IndexOf(' ');               // if line doesn't contain " "
                        if (indexOfSpace == 0 || indexOfSpace == -1)            // or start with " "
                            throw new Exception("Wrong line!");                 // generate exception;
                    }    //testing string;         

                    Console.Clear();
                    Console.WriteLine("Line : ");
                    Console.WriteLine(myString);
                    Console.WriteLine();

                    menuItem = MyMenu();
                    switch (menuItem)
                    {
                        case 1:
                            FirstTask(myString);
                            break;
                        case 2:
                            SecondTask(myString);
                            break;
                        case 3:
                            ThirdTask(myString);
                            break;
                        case 4:
                            FoursTask(myString);
                            break;
                        case 5:
                            myString = ChangeString();
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Error! Press any key to repeat...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static int MyMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - First task.");
            Console.WriteLine("2 - Second task.");
            Console.WriteLine("3 - Third task.");
            Console.WriteLine("4 - Fours task.");
            Console.WriteLine("5 - Change string.");
            Console.WriteLine("6 - Exit.");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return 7;
            }
        }
        static String ChangeString()
        {
            Console.WriteLine("Input new line: ");
            string tempStr = Console.ReadLine();
            return tempStr;
        }

        static void FirstTask(String tempString)
        {
            Console.Clear();
            Console.WriteLine("First task:");
            Console.WriteLine($"Line :\n{tempString}");

            String[] arrayString = tempString.Split(' ');  // separation string;

            int maxWord = 0;
            
            foreach (String st in arrayString)
                if (st.Length > maxWord) maxWord = st.Length;

            string resultString ="";
            foreach(String st in arrayString)              // concat string;
            {
                if (st.Length == maxWord) continue;
                resultString += st+" ";
            }
            Console.WriteLine($"Result :\n{resultString} ");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        static void SecondTask(String tempString)
        {
            Console.Clear();
            Console.WriteLine("Second task:");
            Console.WriteLine($"Line :\n{tempString}");

            String[] arrayString = tempString.Split(' ');  // separation string;
            
            int maxWord, minWord;                          //set min and max length;
            minWord = maxWord = arrayString[0].Length;     
            foreach (String st in arrayString)
            {
                if (st.Length > maxWord) maxWord = st.Length;
                if (st.Length < minWord) minWord = st.Length;
            }

            int[] indArray =new int[arrayString.Length];   // create array of min/max word;
            for (int i = 0; i < arrayString.Length; i++)   
            {
                if (arrayString[i].Length == minWord) indArray[i] = -1;
                if (arrayString[i].Length == maxWord) indArray[i] = 1;
            }

            String tempStr;
            for (int i = 0; i < arrayString.Length; i++)
            {
                if (indArray[i] == 1)
                {
                    for (int j = i; j < indArray.Length; j++)
                        if (indArray[j] == -1)
                        {
                            tempStr = arrayString[i];
                            arrayString[i] = arrayString[j];
                            arrayString[j] = tempStr;
                            indArray[i] = indArray[j] = 0;
                            break;
                        }
                }
                if (indArray[i] == -1)
                {
                    for (int j = i; j < indArray.Length; j++)
                        if (indArray[j] == 1)
                        {
                            tempStr = arrayString[i];
                            arrayString[i] = arrayString[j];
                            arrayString[j] = tempStr;
                            indArray[i] = indArray[j] = 0;
                            break;
                        }
                }
            }

            String resultString = "";
            foreach (String st in arrayString) resultString+=st + " ";
            Console.WriteLine($"Result :\n{resultString} ");

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        static void ThirdTask(String tempString)
        {
            Console.Clear();
            Console.WriteLine("Third task.");
            Console.WriteLine($"Line :\n{tempString}");

            int numLetters = 0;
            int numPunct = 0;
            foreach (Char ch in tempString)
            {
                if (Char.IsLetter(ch)) numLetters++;
                if (Char.IsPunctuation(ch)) numPunct++;
            }
           
            Console.WriteLine($"Number of letters - {numLetters} \nNumber of punctuations - {numPunct}");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
        static void FoursTask(String tempString)
        {
            Console.Clear();
            Console.WriteLine("Fours task.");
            Console.WriteLine($"Line :\n{tempString}");

            String[] arrayString = tempString.Split(' ');  // separation string;

            string tempStr;
            for (int i = 0; i < arrayString.Length; i++)
            {
                for (int j = i + 1; j <arrayString.Length; j++)
                {
                    if (arrayString[i].Length > arrayString[j].Length)
                    {
                        tempStr = arrayString[i];
                        arrayString[i] = arrayString[j];
                        arrayString[j] = tempStr;
                    }
                }
            }//sort array;

            Console.WriteLine("Result :");
            foreach (String st in arrayString)
                Console.WriteLine(st);

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();

        }
    }
}