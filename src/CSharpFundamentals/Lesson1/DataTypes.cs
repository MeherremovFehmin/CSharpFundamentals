using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Lesson1
{
    internal class DataTypes
    {
        // numbers 
        byte num0 = 34; // 0 => 255; 0 => 2^8 - 1; 8 bit
        sbyte num1 = -3; // -256 => 255; -2^8 => 2^8 - 1; 8 bit = 1 bayt

        short num2 = 32000; // -2^15 => 2^15 - 1; 16 bit = 2 bayt
        ushort num3 = 65000; // 0 => 2^16; 16 bit = 2 bayt

        int num4 = 54; // 32 bit = 4 bayt
        uint num5 = 4444444; // 32 bit = 4 bayt

        long num6 = 4232432432444444444; // 64 bit = 8 bayt
        ulong num7 = 12324324324444444444; // 64 bit = 8 bayt

        float num8 = 3.2f; // 32 bit = 4 bayt
        double num9 = 3.22222; // 64 bit = 8 bayt
        decimal num10 = 12.434343543543535m; // 128 bit = 16 bayt

        decimal a; // default value = 0

        // strings 
        string str1 = "hello world!";
        string str2 = null;
        string str3 = string.Empty;
        string str4;
        char symbol = 'A';


        // boolean
        bool isStudent = true;
        bool isExpensive = false

        public void PrintNumberDataTypes()
        {
            Console.WriteLine("'byte' data type:");
            Console.WriteLine($"Min. value: {byte.MinValue}");
            Console.WriteLine($"Max.value: {byte.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(byte)} byte");

            Console.Write("\n");

            Console.WriteLine("'sbyte' data type:");
            Console.WriteLine($"Min. value: {sbyte.MinValue}");
            Console.WriteLine($"Max.value: {sbyte.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'short' data type:");
            Console.WriteLine($"Min. value: {short.MinValue}");
            Console.WriteLine($"Max.value: {short.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'ushort' data type:");
            Console.WriteLine($"Min. value: {ushort.MinValue}");
            Console.WriteLine($"Max.value: {ushort.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'int' data type:");
            Console.WriteLine($"Min. value: {int.MinValue}");
            Console.WriteLine($"Max.value: {int.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'uint' data type:");
            Console.WriteLine($"Min. value: {uint.MinValue}");
            Console.WriteLine($"Max.value: {uint.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'long' data type:");
            Console.WriteLine($"Min. value: {long.MinValue}");
            Console.WriteLine($"Max.value: {long.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'ulong' data type:");
            Console.WriteLine($"Min. value: {ulong.MinValue}");
            Console.WriteLine($"Max.value: {ulong.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'float' data type:");
            Console.WriteLine($"Min. value: {float.MinValue}");
            Console.WriteLine($"Max.value: {float.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'double' data type:");
            Console.WriteLine($"Min. value: {double.MinValue}");
            Console.WriteLine($"Max.value: {double.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");

            Console.Write("\n");

            Console.WriteLine("'decimal' data type:");
            Console.WriteLine($"Min. value: {decimal.MinValue}");
            Console.WriteLine($"Max.value: {decimal.MaxValue}");
            Console.WriteLine($"Size of byte type: {sizeof(sbyte)} byte");
        }

        public void PrintStringDataTypes()
        {
            string p;
            p = "";
        }

        public void CalculateTrianleArea()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Perimeter: {2 * p}");
            Console.WriteLine($"Area: {s}");
        }
    }
}
