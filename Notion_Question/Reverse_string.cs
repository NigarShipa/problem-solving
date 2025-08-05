//4.How to reverse a given String? using loop without recursion
//5.How to reverse a given String? using reverse function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Reverse_string
    {
        public static void Reverse()
        {
            var s1 = "How to reverse a given String? using loop without recursion";
            var s2 = "How to reverse a given String? using reverse function";
            var reverseString = "";
            var reverseString2 = "";
            // // Reverse using for loop method
            for (var i = s1.Length - 1; i >= 0; i--) reverseString += s1[i];
            Console.WriteLine("Reverse string 1 is : " + reverseString);
            // Reverse using LINQ's Reverse() method
            for (var i = 0; i < s2.Length; i++)
                reverseString2 = new string(s2.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Reverse string 2 is : " + reverseString2);
        }
    }
}
