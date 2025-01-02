using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    internal class ArrayL2
    {
        public static int[] RotateLeft(int[] arr)
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
          
            return arr;
        }

        public static void RotateLeftByNTimes(int[] arr, int t)
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
        public static int[] RotateRight(int[] arr)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            int temp = arr[(arr.Length - 1)];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(i==0)
                {
                    arr[0] = temp;
                    break;
                }
                arr[i] = arr[i - 1];
            }
           
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i == arr.Length - 1)
            //    {
            //        arr[0] = temp;
            //        break;
            //    }
            //    arr[i+1] = arr[i];
            //}
            //foreach (var item in arr)
            //{
            //    //Console.Write(item + ",");
            //}
            return arr;
        }
        
        public static void RotateRightByNTimes(int[] arr, int t)
        {
            t = t % arr.Length;
            for (int i = 1; i <= t; i++)
            {
                RotateRight(arr);
            }
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
        }
        //Incomplete
        public static void RotateRightByNTimesOptimal(int[] arr, int t)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };    5,1,2,3,4 -->Right Swap --> 5 4 3 2 1     
            int start = 0;
            int end = arr.Length - 1;
            int temp;
            for (int i = start; i < t; i++)
            {
                temp = arr[t];
                arr[end] = arr[start];
                arr[start] = temp;
                start++;
                end--;
            }
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
        }

        public static void MoveZeros(int[] arr)
        {
            // Input: ‘n’ = 5, ‘arr’ = [1, 2, 0, 0, 2, 3]
            //      Output: [1, 2, 2, 3, 0, 0] 
            int j = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            int temp;
            for (int i = j + 1; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
