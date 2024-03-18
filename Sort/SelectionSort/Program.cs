using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.WriteLine(arr[i]);
            }
            SelectionSortArr(arr);
            PrintSort(arr);
            Console.ReadLine();

        }
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void SelectionSortArr(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i < n-1; i++)
            {
                int minIndex = i;
                for( int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
            }
        }
        static void PrintSort(int[] arr)
        {
            Console.WriteLine("Mang sau khi sap xep: ");
            foreach(int item in arr) Console.Write(item + " ");
        }
    }
}
