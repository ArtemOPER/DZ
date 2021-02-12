using System;

namespace _10
{
    class Program
    {
        static void PrintLine(char symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.WriteLine(symbol);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nВведите колличество символов: ");
            uint symblosCount = uint.Parse(Console.ReadLine());

            PrintLine(symbol, symblosCount);
            Console.ReadLine();            
        }
    }
}
