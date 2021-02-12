using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 5, 14, 52, 10, 6 };

            int MinValue = myArray[0];
            
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < MinValue)
                {
                    MinValue = myArray[i];
                }
            }
            Console.WriteLine(MinValue);

            Console.ReadLine();
        }
    }
}
