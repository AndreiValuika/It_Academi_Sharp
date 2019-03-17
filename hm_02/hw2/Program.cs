using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1=3;
            Int32 int2=4;

            Console.WriteLine(int1.GetType());
            Console.WriteLine(int2.GetType());
            Console.WriteLine();
            
            bool bool1=true;
            Boolean bool2=false;

            Console.WriteLine(bool1.GetType());
            Console.WriteLine(bool2.GetType());
            Console.WriteLine();

            byte byte1=1;
            Byte byte2=2;

            Console.WriteLine(byte1.GetType());
            Console.WriteLine(byte2.GetType());
            Console.WriteLine();

            sbyte sbyte1=1;
            SByte sbyte2=2;

            Console.WriteLine(sbyte1.GetType());
            Console.WriteLine(sbyte2.GetType());
            Console.WriteLine();

            short short1=1;
            Int16 short2=2;

            Console.WriteLine(short1.GetType());
            Console.WriteLine(short2.GetType());
            Console.WriteLine();

            ushort ushort1=1;
            UInt16 ushort2=2;

            Console.WriteLine(ushort1.GetType());
            Console.WriteLine(ushort2.GetType());
            Console.WriteLine();

            uint uint1=1;
            UInt32 uint2=2;

            Console.WriteLine(uint1.GetType());
            Console.WriteLine(uint2.GetType());
            Console.WriteLine();

            long long1=1;
            Int64 long2=2;

            Console.WriteLine(long1.GetType());
            Console.WriteLine(long2.GetType());
            Console.WriteLine();

            ulong ulong1=1;
            UInt64 ulong2=2;

            Console.WriteLine(ulong1.GetType());
            Console.WriteLine(ulong2.GetType());
            Console.WriteLine();

            float float1=1.1f;
            Single float2=2.2f;

            Console.WriteLine(float1.GetType());
            Console.WriteLine(float2.GetType());
            Console.WriteLine();

            double double1=1.1;
            Double double2=2.2;

            Console.WriteLine(double1.GetType());
            Console.WriteLine(double2.GetType());
            Console.WriteLine();

            decimal decimal1=1.1m;
            Decimal decimal2=2.2m;

            Console.WriteLine(decimal1.GetType());
            Console.WriteLine(decimal2.GetType());
            Console.WriteLine();

            char char1='a';
            Char char2='b';

            Console.WriteLine(char1.GetType());
            Console.WriteLine(char2.GetType());
            Console.WriteLine();

            string string1="AAA";
            String string2="BBB";

            Console.WriteLine(string1.GetType());
            Console.WriteLine(string2.GetType());
            Console.WriteLine();

            object object1=new object();
            Object object2=new Object();

            Console.WriteLine(object1.GetType());
            Console.WriteLine(object2.GetType());
            Console.WriteLine();

            //explicit type conversion
            int1 = 42;
            long1 = int1; // conversion int to long

            short1 = 3;
            float1 = short1; //conversion shot to float

            string1 = "Test";
            object1 = string1; //conversion string to object


            //implicit type conversion

            int2 =(int)long1; // conversion long to int

            short2 = (short)float1; //conversion float to short

            string2 = (string)object1;//conversion object to string

            decimal1 = 23.123m;
            object2 = decimal1;//boxing
            decimal2 = (decimal)object2;//unboxing

            Console.ReadKey();
        }
    }
}
