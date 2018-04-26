using System;

namespace BubbleSorting
{
    class Program
    {
        static int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
        static int temp = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }

}
}
