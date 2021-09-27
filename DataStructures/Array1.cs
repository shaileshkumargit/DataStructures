using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{ //sort an array elements in an ascending and descending order without using built-in functions.
    class Array1
    {
        public void SortArray(int[] arr)
        {
            int swap = 0;
            //To read elements of an array.
            for (int i = 0; i < arr.Length; i++)
            {//to perform comparison of index values and swap accordingly.
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }
                Console.Write(arr[i] + " ");
            }
        }
        public static void DescindingOrder(int[] arr)
        {
            int swap = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] <= arr[j])
                    {
                        swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }
                Console.Write(" "  + arr[i]);
            }
        }

            static void Main(string[] args)
        {
            int[] num = { 22, 50, 11, 2, 49, 79, 90 };
            Array1 p = new Array1();
            Console.WriteLine("Elements are sorted in Ascending order: ");
            p.SortArray(num);
            Console.WriteLine(" \n");
            Console.WriteLine("Elements are sorted in Descending order: ");
            DescindingOrder(num);
            Console.ReadLine();
        }
    }
}
