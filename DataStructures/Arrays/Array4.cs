using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{//array4 to move all zero's to last of an array and order of non zero's shouldn't change

    class Array4
    {
        static void moveZerosToEnd(int[] arr, int n)
        {
            
            int count = 0;
            int temp;

          
            for (int i = 0; i < n; i++)
            {
                if ((arr[i] != 0))
                {
                    temp = arr[count];
                    arr[count] = arr[i];
                    arr[i] = temp;
                    count = count + 1;
                }
            }
        }

      
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

       
        public static void Main()
        {
            int[] arr = { 0, 1, 9, 8, 4, 0, 0, 2,
                    7, 0, 6, 0, 9 };
            int n = arr.Length;

            Console.Write("Original array: ");
            printArray(arr, n);

            moveZerosToEnd(arr, n);

            Console.Write("\nModified array: ");
            printArray(arr, n);
            Console.ReadLine();
        }
    }
}
