using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 5, 14, 52, 1, 6 };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }

            }

            Console.WriteLine(" Сумма всех чисел: " + result);

            Console.ReadLine();
        }
    }
}
