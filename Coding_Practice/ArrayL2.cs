using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    internal class ArrayL2
    {
        public static int [] RotateLeft(int[] arr)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            int temp = arr[0]; 
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    arr[i] = temp;
                    break;
                }
                arr[i] = arr[i + 1];
            }
            foreach (var item in arr)
            {
                //Console.Write(item + ",");
            }
            return arr;
        }
        
        public static void RotateLeftByNTimes(int[] arr,int t)
        {
            t = t % arr.Length;
            for (int i = 1; i <= t; i++)
            {
                RotateLeft(arr);
            }
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
        }
    }
}
