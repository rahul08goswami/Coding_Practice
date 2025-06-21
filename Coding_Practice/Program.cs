using Coding_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Mr. Rahul Goswami";
            //string reversed = name.ReverseEx();  // Call extension method
            //Console.WriteLine(reversed);
            
            Console.WriteLine(ReverseExcop(name));
            // Output: "rM. luhaR imawsoG"
            //ArrayL1.LasrgestElement();
            //ArrayL1.SecondLargestElement();
            //Console.WriteLine(ArrayL1.isSorted());
            //ArrayL1.Unique();
            //int[] arr = { 1, 0, 2, 3, 0, 0, 4, 5 };
            int[] arr = { 1, 2, 4, 5 };
            //int[] arr = { 1, 2, 3,4, 5 };
            //int[] arr = { 1, 2, 0, 0, 2, 3 };
            //int[] arr = { 1, 2, 3, 4, 5 };
            //ArrayL2.RotateLeft(arr);
            //ArrayL2.RotateRightByNTimesOptimal(arr,3);
            //ArrayL2.MoveZeros(arr);
            //ArrayL2.missingNumberOptimalBest(5, arr);
            ArrayL2.AppearsOnceBetter();
            //ArrayL2.RotateLeftByDTimesOptimal(arr,3);
            //ArrayL2.RotateLeftByNTimes(arr, 2);
            //ArrayL2.RotateRightByNTimes(arr, 3);
            //ArrayL2.RotateRightByNTimesOptimal(arr,3);
            //ArrayL2.MoveZeros(arr);
            //ArrayL2.LinearSearch(3);
            //ArrayL2.Union();
            // ArrayL2.Intersect();
            //ArrayL2.missingNumber(6);
            //ArrayL2.consecutiveOnes();
            //Fun1("rahul");
            //ArrayL2.CustomSort();
            //var x = new { Value = 1 }; var y = new { Value = 1 }; Console.WriteLine(x == y);


        }

        public static string ReverseExcop( string s)
        {
            //Reture each word in a string in reverse order without using LINQ
            // Example: "Hello World" -> "olleH dlroW"
            var arr = s.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                char[] chars = arr[i].ToCharArray();
                Array.Reverse(chars);
                arr[i] = new string(chars);  // Save the reversed word back
            }
            return string.Join(" ", arr);  // Recombine reversed words

        }

        public static void Fun1(string str)
        {
            str.ToLower();
            //string s = str[0].ToString();
            //s.ToUpper();
            //s.ToArray();
            //string st = str[0].ToString().ToUpper() + str.Substring(1);
            string st = string.Concat(str[0].ToString().ToUpper(), str.Substring(1));
            //var s = str.Substring(1);
            //var n = s.ToUpper();

            Console.WriteLine(st);

        }
    }
}
