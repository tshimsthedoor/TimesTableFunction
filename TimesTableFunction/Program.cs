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
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            }
            while (isNumber);
        }

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 0; row <13; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }
    }
}
