using System;
using static System.Console;

namespace TimesTableFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTimesTable();
        }

        private static void RunTimesTable()
        {
            throw new NotImplementedException();
        }

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }
    }
}
