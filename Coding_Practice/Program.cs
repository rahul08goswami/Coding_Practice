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
            int[] arr = { 1, 2, 3, 4, 5 };
            //ArrayL2.RotateLeft(arr);
            ArrayL2.RotateLeftByNTimes(arr, 5);
        }
    }
}
