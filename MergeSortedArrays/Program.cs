using System;
using System.Linq;
namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, 6, 9, 12, 14, 18, 20, 25, 28 };
            int[] array2 = { 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };

            int[] arr1 = { 1, 2, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            int[] arr2 = { 2, 6, 7 };

            int[] arrSort1 = { 1, 2, 2, 3, 4, 5 };
            int[] arrSort2 = { 2, 6, 7 };

            //Console.WriteLine("Merged arrays");
            //MergeArrays(arr1, arr2, 5);
            //Console.WriteLine("---------------------");

            Console.WriteLine("Merged and sorted arrays");

            var result = Merge(arrSort1, arrSort2);
            Print(result);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------------------");

            Console.WriteLine("Sort Then Merge");
            var sorted = SortThenMerge(new[] { 9, 2, 8, 10, 7, 6, 5, 7, 1, 1, 15 });
            Print(sorted);

            Console.ReadKey();
        }

        static int[] Merge(int[] x, int[] y)
        {
            //int[] arrSort1 = { 1, 2, 2, 3, 4, 5 };
            //int[] arrSort2 = { 2, 6, 7 };

            var result = new int[x.Length + y.Length];
            var xIndex = 0;
            var yIndex = 0;
            var mergeIndex = 0;

            while (xIndex < x.Length && yIndex < y.Length)
            {
                if (y[yIndex] <= x[xIndex])
                    result[mergeIndex++] = y[yIndex++];
                else
                    result[mergeIndex++] = x[xIndex++];
            }

            var rest = x;
            var index = xIndex;

            if (yIndex < y.Length)
            {
                rest = y;
                index = yIndex;
            }
            for (var i = index; i < rest.Length; ++i)
                result[mergeIndex++] = rest[i];

            return result;
        }

        static int[] SortThenMerge(int[] a)
        {
            //{ 9, 2, 8, 10, 7,  6, 5, 7, 1, 1, 15 }

            if (a.Length == 1)
                return a;

            var first = SortThenMerge(a.Take(a.Length / 2).ToArray());
            var second = SortThenMerge(a.Skip(a.Length / 2).ToArray());

            return Merge(first, second);
        }

        static void MergeArrays(int[] x, int[] y, int lastX)
        {
            //int[] arr1 = { 1, 2, 2, 3, 4, 5, 0, 0, 0, 0, 0 };
            //int[] arr2 = { 2, 6, 7 };

            int xIndex = lastX + 1;
            int yIndex = 0;

            while (yIndex < y.Length)
            {
                x[xIndex] = y[yIndex];

                xIndex++;
                yIndex++;
            }

            for (int i = 0; i < x.Length; i++)
                Console.Write(x[i] + ",");
            Console.WriteLine(Environment.NewLine);
        }

        static void Print(int[] a)
        {
            for (var i = 0; i < a.Length; i++)
                Console.Write(a[i] + ",");
        }



    }
}
