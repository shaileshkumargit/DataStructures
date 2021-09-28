using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class Array3
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            //reverse an array
            Console.WriteLine("Array after reversal ");
            for(int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(" " + arr[i]);
            }
            
            Console.WriteLine();
            //length of an array without using built-in function 
            int count = 0;
            foreach(int i in arr)
            {
                count++;
            }
            Console.WriteLine("The length of an array is " + count);
            
            Console.ReadLine();
        }
    }
}
