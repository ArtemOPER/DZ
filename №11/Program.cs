using System;

namespace _11
{
    class Program
    {
        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }




        static void Main(string[] args)
        {
            int[] myArray = { 2, -5, 23, 55 };

            int result = IndexOf(myArray, 23);

            Console.WriteLine(result);
        }
    }
}
