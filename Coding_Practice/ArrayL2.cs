using System;
using System.Collections.Generic;
using System.Globalization;
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
            //TC - O(N)
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
        public static void RotateLeftByDTimes(int[] arr, int t)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            t = t % arr.Length;
            List<int> temp = new List<int>();
            for (int i = 0; i < t; i++)
            {
                temp.Add(arr[i]);
            }
            int N = arr.Length;
            for (int i = t; i < N; i++)
            {
                arr[i - t] = arr[i];
            }
            //int j = 0;
            for (int i = t - 1; i < arr.Length; i++)
            {
                arr[i] = temp[i - (N - t)];
                // j++;
            }
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
            //int[] arr = { 1, 2, 3, 4, 5 };
            t = t % arr.Length;
            int n = arr.Length;
            Array.Reverse(arr, 0, n - t);
            Array.Reverse(arr, n - t, t);
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
        //Incomplete
        public static void RotateRightByNTimesOptimal(int[] arr, int t)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };    5,1,2,3,4 -->Right Swap --> 5 4 3 2 1     
            //int start = 0;
            //int end = arr.Length - 1;
            //int temp;
            //for (int i = start; i < t; i++)
            //{
            //    temp = arr[t];
            //    arr[end] = arr[start];
            //    arr[start] = temp;
            //    start++;
            //    end--;
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write(item + ",");
            //}
            //int[] arr = { 1, 2, 3, 4, 5 };
            t = t % arr.Length;
            List<int> temp = new List<int>();
            for (int i = t - 1; i < arr.Length; i++)
            {
                temp.Add(arr[i]);
            }
            int N = arr.Length;
            for (int i = 0; i < (arr.Length - t); i++)
            {
                arr[i + t] = arr[i];
            }
            //int j = 0;
            for (int i = 0; i < t; i++)
            {
                arr[i] = temp[i];
                // j++;
            }
        }

        public static void RotateLeftByDTimesOptimal(int[] arr, int t)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };    5,1,2,3,4 -->Right Swap --> 5 4 3 2 1
            //3,2,1,5,4 --> 4,5,1,2,3
            t = t % arr.Length;
            Array.Reverse(arr, 0, t);
            Array.Reverse(arr, t, (arr.Length - t));
            Array.Reverse(arr);
        }

        public static void MoveZeros(int[] arr)
        {
            // Input: ‘n’ = 5, ‘arr’ = [1, 2, 0, 0, 2, 3]
            //      Output: [1, 2, 2, 3, 0, 0] 
            int j = -1; // Find 1st 0 index O(X)
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            if (j == -1) return; // No Non 0 no. present
            int temp;  //Swap 0 with non 0   O(N-X)
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
            // Time Complexity O(X) + O(N-X) = O(N)
            // Space Complexity - O(1)
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void MoveZerosBrute(int[] arr)
        {
            // Input: ‘n’ = 5, ‘arr’ = [1, 2, 0, 0, 2, 3]
            //      Output: [1, 2, 2, 3, 0, 0] 
            List<int> temp = new List<int>();
            foreach (var item in arr)   // O(N)
            {
                if (item != 0)
                    temp.Add(item);
            }
            int NonZero = temp.Count;
            for (int i = 0; i < temp.Count; i++) // O(X) X is non zeros no
            {
                arr[i] = temp[i];
            }
            for (int i = NonZero; i < arr.Length; i++) //O(N-X)
            {
                arr[i] = 0;
            }
            //Time Complexity = O(N) + O(X) + O(N-X) = O(2N)
            //Space Complexity = O(X)
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
        public static void UnionOptimal()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5 };
            //int i =0, j = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!list.Contains(a[i]))
                {
                    list.Add(a[i]);
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (!list.Contains(b[i]))
                {
                    list.Add(b[i]);
                }
            }
            list.Sort();
            //while(i<a.Length && j < b.Length)
            //{
            //    if (a[i] <= b[j])
            //    {
            //        if (!list.Contains(a[i]))
            //             list.Add(a[i]);
            //        i++;
            //    }
            //    else
            //    {
            //        if (!list.Contains(b[j]))
            //            list.Add(b[j]);
            //        j++;
            //    }

            //}
            //while(i<a.Length)
            //{
            //    if (!list.Contains(a[i]))
            //        list.Add(a[i]);
            //    i++;
            //}
            //while(j<b.Length)
            //{
            //    if (!list.Contains(b[j]))
            //        list.Add(b[j]);
            //    j++;
            //}
            //TC -> O(N+M)
            // SC -> O(N+M)
        }
        public static void UnionBrute()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 51 };

            SortedSet<int> ints = new SortedSet<int>();
            foreach (var item in a)
            {
                ints.Add(item);
            }
            foreach (var item in b)
            {
                ints.Add(item);
            }
            List<int> list = new List<int>();
            foreach (var item in ints)
            {
                list.Add(item);
            }
            // TC - O(n1 log n + n2 log n) + O(n1 + n2)
            //SC - O(N1+N2)
        }
        public static void Intersect()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5, 2 };

            var res = a.Intersect(b);
            //res.ToArray().Distinct();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public static void IntersectBrute()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5, 2, 6 };
            int[] temp = new int[b.Length];
            List<int> list = new List<int>();
            Array.Sort(a);
            Array.Sort(b);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j] && temp[j] == 0)
                    {
                        temp[j] = 1;
                        list.Add(a[i]);
                        break;
                    }
                    if (b[j] > a[i])
                        break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //TC - O(m × n) SC - O(n)
        }
        public static void IntersectOptimal()
        {
            int[] a = { 1, 2, 3, 4, 6, 2 };
            int[] b = { 2, 3, 5, 2, 6 };
            int i = 0, j = 0;
            Array.Sort(a);
            Array.Sort(b);
            List<int> list = new List<int>();
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                    i++;
                else if (b[j] < a[i]) j++;
                else
                {
                    list.Add(a[i]);
                    i++;
                    j++;
                }
            }
            // TC - O(n +m) SC - O(1)
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
        public static void missingNumberBetter(int[] arr, int N)
        {
            //int[] arr = { 1, 2, 4, 5 };
            int[] ints = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                ints[arr[i]] = 1;
            }
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] == 0)
                    Console.WriteLine($"{i} is missing");
            }
            //TC - O(2n)  SC - O(n)
            //ints.Where(x => x == 0).Select();

        }
        public static void missingNumberOptimal(int N, int[] arr)
        {
            //List<int> ints = new List<int>();
            //for (int i = 0; i < N; i++)
            //{
            //    ints.Add(i + 1);
            //}
            //int[] arr = { 1, 2, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    return;
                if (arr[i] == arr[i + 1] - 1)
                { }
                else
                {
                    Console.WriteLine($"{arr[i + 1] - 1} is missing");
                }
            }

        }

        public static void missingNumberOptimalBest(int N, int[] arr)
        {
            //int[] arr = { 1, 2, 4, 5 };
            int xor1 = 0, xor2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                xor1 = xor1 ^ (i + 1);
                xor2 = xor2 ^ arr[i];
            }
            xor1 = xor1 ^ N;
            int result = xor2 ^ xor1;
        }
        public static void consecutiveOnes()
        {
            int[] arr = { 0, 1, 1, 1, 1, 1, 0, 1, 1 };
            int count = 0;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    count = 0;
                }
            }

            Console.WriteLine($"Max consecutive 1s: {max}");
        }

        public static void CustomSort()
        {
            int[] arr = { 2, 2, 2, 2, 0, 0, 1, 0 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        int temp = 0;
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }

                }
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > arr[j] && (i < j))
            //    {
            //        int temp = 0;
            //        temp = arr[i];
            //        arr[i] = arr[j];
            //        arr[j] = temp;
            //        j--;
            //    }                
            //}
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void AppearsOnceBetter()
        {
            //Hashing
            int[] arr = { 2, 2, 3, 4, 6, 6, 4 };
            int[] hash = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                hash[arr[i]]++;
            }
            int firstIndex = Array.FindIndex(hash, x => x == 1);
            var indexes = hash
    .Select((value, index) => new { value, index })
    .Where(x => x.value == 1)
    .Select(x => x.index)
    .ToList();
            int firstIndexx = hash
    .Select((value, index) => new { value, index })
    .FirstOrDefault(x => x.value == 1)?.index ?? -1;
            for (int i = 1; i < hash.Length; i++)
            {
                if (hash[i] == 1)
                    Console.WriteLine($"{i} is missing");
            }

        }
        public static void AppearsOnceOptimal()
        {
            int[] arr = { 2, 2, 3, 4, 3, 6, 4 };
            int xor = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                xor ^= arr[i];
            }
            Console.WriteLine($"{xor} appears once");
        }
    }
}
