using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //do
            //{
            //    Console.Write("Nhap vao so luong phan tu cua mang: ");
            //}while(!int.TryParse(Console.ReadLine(), out n) || n<=0);
            //int[] arr = new int[n];
            //Console.WriteLine("Nhap vao cac phan tu cua mang: ");
            //for(int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            int[] arr = new int[5];
            Random random = new Random();
            Console.WriteLine("Mang ban dau: ");
            for(int i= 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.WriteLine(arr[i]+" ");
            }
            InsertTionSortArr(arr);
            PrintSort(arr);
            Console.ReadLine();
        }
        static void InsertTionSortArr(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1;i < n; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j>=0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j];
                    j--;
                }//sau khi không thỏa mãn thì mới dừng vòng while, sau đó mới thực hiện tiếp phía sau
                arr[j+1] = temp;
            }
        }
        static void PrintSort(int[] arr)
        {
            Console.WriteLine("Mang sau khi sap xep: ");
            foreach(int i in arr) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
