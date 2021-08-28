using System;

namespace ArraySortDemo
{
    class SortArray
    {
        void Swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        internal int[] Ascending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
                }
            return arr;

        }
        internal int[] Descending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                        Swap(ref arr[i], ref arr[j]);
                }
            return arr;
        }

        internal void PrintArr(int[] arr)
        {
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int n = 0;
            Console.Write("Enter Number of Elemntes: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ascending Array:");
            new SortArray().PrintArr(new SortArray().Ascending(arr));
            Console.WriteLine("Descending Array:");
            new SortArray().PrintArr(new SortArray().Descending(arr));
        }
    }
}
