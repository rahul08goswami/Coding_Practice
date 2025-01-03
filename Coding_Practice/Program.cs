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
            //ArrayL1.LasrgestElement();
            //ArrayL1.SecondLargestElement();
            //Console.WriteLine(ArrayL1.isSorted());
            //ArrayL1.Unique();
            // int[] arr = { 1, 0, 2, 3, 0, 0, 4, 5 };
            //int[] arr = { 1, 2, 3,4, 5 };
            int[] arr = {1, 2, 0, 0, 2, 3};
            //ArrayL2.RotateLeft(arr);
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
