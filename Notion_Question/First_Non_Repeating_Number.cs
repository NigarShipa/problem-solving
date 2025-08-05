//How to find the first non-repeating character in a given String? input : zaaakiz and  output : k
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    internal class First_Non_Repeating_Number
    {
        public static void NonrepeatNumber()
        {
            string sentence = "zaaakiz";
            int[] arr = new int[26]; // Array to count character frequencies
            // First loop to count the frequency of each character
            foreach (char c in sentence)
            {
                int index = c - 'a'; // Calculate index ('a' -> 0, 'b' -> 1, ..., 'z' -> 25)
                arr[index]++;
            }
            // Second loop to find the first non-repeating character
            foreach (char ch in sentence)
            {
                if (arr[ch - 'a'] == 1) // Check if the character is non-repeating
                {
                    Console.WriteLine("First non-repeating character: " + ch);
                    break;
                }
            }

        }
    }
}
