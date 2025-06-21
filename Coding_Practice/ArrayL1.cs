using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CodingPractice
{
    internal class ArrayL1
    {
        public static void LasrgestElement()
        {
            // Largest Element in an Array
            int[] arr = { 10, 5, 2, 9, 11, 13, 29 };
            //Brrute force O(nlogn)
            Array.Sort(arr);

            Console.WriteLine("Largest Element: " + arr[arr.Length - 1]);

            // Optimal Solution O(n)
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                    max = item;
            }
            Console.WriteLine("Largest Element: " + max);
        }
        public static void SecondLargestElement()
        {
            #region Bruteforce
            //int[] arr = { 10, 5, 2, 9, 19, 23,29, 29 };
            //Bruteforce O(nlogn + n)
            //Array.Sort(arr);
            //int max = arr[arr.Length - 1];
            //int sl = arr[arr.Length - 2];
            //for (int i = arr.Length - 2; i >= 0; i--)
            //{
            //    //if (arr[i] == max)
            //    //{
            //    //    sl = arr[i - 1];
            //    //    continue;
            //    //}
            //    if (arr[i] != max)
            //    {
            //        sl = arr[i];
            //        break;
            //    }
            //}
            //Console.WriteLine("Second Lagest: " + sl );
            #endregion
            #region Better
            ////Better O(2n)
            //int[] arr = { 10, 5, 2, 9, 19, 23,52, 29, 29 };
            //int sl = -1;
            //// Find the Largest in 1st iteration
            //int lar = arr[0];
            ////foreach (var item in arr)
            ////{
            ////    if (item > lar)
            ////        lar = item;
            ////}
            ////Finding largest
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > lar)
            //        lar = arr[i];
            //}
            ////Find the 2nd Largest
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > sl && arr[i]!=lar)
            //    {
            //        sl = arr[i];
            //    }
            //}
            //Console.WriteLine("Second Lagest: " + sl);
            #endregion
            #region Optimal
            // Time Complexity - O(N)
            int[] arr = { 10, 5, 2, 9, 19, 53, 29, 29 };
            int lar = arr[0];
            int sl = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > lar)
                {
                    sl = lar;
                    lar = arr[i];
                }
                else if (arr[i] > sl && arr[i] < lar)
                {
                    sl = arr[i];
                }
            }
            Console.WriteLine("Second Largest: " + sl);
            #endregion
        }
        public static bool isSorted()
        {
            // TC - O(N)
            //int[] arr = { 10, 5, 2, 9, 19, 23, 52, 29, 29 };
            //int[] arr = { 1, 2, 5, 7, 9 };
            int[] arr = { 4, 5, 4, 4, 4 };
            bool sorted = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    sorted = true;
                }
                else
                {
                    sorted = false;
                    return false;
                }
            }
            return sorted;

        }
        public static void Unique()
        {
            #region Better
            int[] arr = { 10, 5, 2, 9, 19, 23, 52, 29, 29 };
            //List<int> list = new List<int>{ 10, 5, 2, 9, 19, 23, 52, 29, 29 };
            //IEnumerable<int> dist = arr.Distinct<int>();
            List<int> dist = arr.Distinct().ToList();
            foreach (var item in dist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dist.Count);
            #endregion
            #region Bruteforce
            //int[] arr = { 10, 5, 2,2, 9, 19, 23, 52, 29, 29 };
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //foreach (var item in arr)
            //{
            //    if(!dic.ContainsKey(item))
            //    {
            //        dic.Add(item, 0);
            //    }
            //}
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item.Key);
            //}
            //int UniqueCount = dic.Count;
            //Console.WriteLine("Total Unique Elements: "+ UniqueCount);
            //int index = 0;
            //foreach (var key in dic.Keys)
            //{
            //    arr[index++] = key;
            //}
            //Console.WriteLine();
            #endregion
            #region Optimal
            //int[] arr = { 10, 5, 2, 9, 19, 23, 52, 29, 29 };
            //int[] arr = { 1, 2, 2, 2, 3, 3 };
            //int i = 0;
            //for (int j = 1; j < arr.Length; j++)
            //{
            //    if (arr[j] != arr[i])
            //    {
            //        arr[i + 1] = arr[j];
            //        i++;
            //    }
            //}
            //Console.WriteLine("No of unique elements: "+ (i+1));

            #endregion
        }
    }
}
