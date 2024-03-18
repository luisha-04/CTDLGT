using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            Console.WriteLine("Mang ban dau la: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.WriteLine(arr[i]);
            }
            BubbleSortArr(arr);
            PrintArr(arr);
            Console.ReadLine();
        }
        static void BubbleSortArr(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i < n-1; i++)
            {
                for(int j=0;j<n-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }
        static void PrintArr(int[] arr)
        {
            Console.WriteLine("Mang sau khi sap xep: ");
            foreach(int i in arr) Console.Write(i+" ");
        }
    }
}
