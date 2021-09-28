using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Array2
    {
        //Find sum of an Array
        public static void Addition(int[] arr)
        {
            int sum = 0;
            foreach(int item in arr)
            {
                sum = sum + item;
                
            }
            Console.WriteLine(sum);
        }
        public static void FindMissing(int[] a, int n)
        {//Find missing number in an array
            int total = (n + 1) * (n + 2) / 2;
            for(int i = 0; i < n; i++)
            {
                total = total - a[i];
            }
            Console.WriteLine(total);
            
        }
        static void Main(String[] args)
        {
            int[] a = { 1, 2, 4, 5,6 };
            Addition(a);
            FindMissing(a, 5);
            //Console.WriteLine(FindMissing);
            Console.ReadLine();
        }
    }
}
