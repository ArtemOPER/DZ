using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве:\t ");

            int elementCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
