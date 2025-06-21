using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice
{
    public static class ExtensionStringReverse
    {
        

        public static string ReverseEx(this string s)
        {
            //reverses each word in the string
            // This method takes a string and reverses each word in it.
            // It splits the string by spaces, reverses each word individually,

            // reverse each word in STRING

            // Example: "Hello World" -> "olleH dlroW"



            // Mr. Rahul Goswami
            var arr = s.Split(' ');
            
            for (int i = 0; i < arr.Length; i++)
            {
                char[] chars = arr[i].ToCharArray();
                Array.Reverse(chars);
                arr[i] = new string(chars);  // Save the reversed word back
            }
            return string.Join(" ", arr);  // Recombine reversed words
        }
    }

}