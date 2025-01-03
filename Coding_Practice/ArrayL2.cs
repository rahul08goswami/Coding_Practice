using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    internal class ArrayL2
    {
        private ArrayL2()
        {
            
        }
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
                if (i == 0)
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

        public static void LinearSearch(int num)
        {
            int[] arr = { 1, 2, 0, 0, 2, 3 };
            int i = -1;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine($"Index of {num} is {i}");
                    break;
                }
            }
            if (i == -1)
                Console.WriteLine(num + " Not found");
        }

        public static void Union()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5 };

            int j = 0;
            //var union = a.Concat(b).Distinct().ToArray();
            //Array.Sort(union);
            //List<int> n = union.ToList();
            //n.Sort();
            var union = a.Union(b).ToArray();
            //var res = union.ToArray();
            Array.Sort(union);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == b[j])
            //    {
            //        j++;
            //    }
            //    else
            //    {

            //    }
            //}
        }
        public static void Intersect()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5 };

            var res = a.Intersect(b);
            //res.ToArray().Distinct();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public static void missingNumber(int N)
        {
            List<int> a = new List<int>();
            for (int i = 0; i < N; i++)
            {
                a.Add(i + 1);
            }
            for (int i = 0; i < N; i++)
            {
                if (a[0] != 1)
                {
                    Console.WriteLine($"1 is missing");
                    return;
                }
                else if (a[i] == a[i + 1] - 1)
                {
                    if (a[i] == a.Count - 1)
                        return;
                }
                else
                {
                    Console.WriteLine($"{a[i + 1] - 1} is missing");
                }
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void consecutiveOnes()
        {
            int[] arr = { 0, 1, 1, 1, 1, 1, 0, 1, 1 };
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    break;
                if (arr[i] != arr[i + 1])
                {
                    count = 0;
                }
                else
                {
                    count++;
                    list.Add(count);
                }
            }
            Console.WriteLine(list.Max() + 1);
        }
    }
}
