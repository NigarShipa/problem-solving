//How to remove all duplicates from a given string?
using System;

namespace Notion_Question
{
    public class Remove_Duplicate
    {
        public static void Duplicate()
        {
            string sentence = "aabbcddAABB";
            int[] arr = new int[52]; // 26 for lowercase + 26 for uppercase
            Console.Write("Remove Duplicate Character and Remaining String is: ");

            foreach (char c in sentence)
            {
                int index;

                if (char.IsLower(c)) // Lowercase letters ('a' -> 0, 'b' -> 1, ..., 'z' -> 25)
                {
                    index = c - 'a';
                }
                else if (char.IsUpper(c)) // Uppercase letters ('A' -> 26, 'B' -> 27, ..., 'Z' -> 51)
                {
                    index = c - 'A' + 26;
                }
                else
                {
                    continue; // Skip non-alphabetic characters
                }

                arr[index]++;

                if (arr[index] == 1)
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
        }
    }
}
/*
 //How to remove all duplicates from a given string?
using System;

namespace Notion_Question
{
    public class Remove_Duplicate
    {
        public static void Duplicate()
        {
            string sentence = "aabbcdd";

            // Array to track character frequencies (only lowercase letters 'a' to 'z')
            int[] arr = new int[26];
            char answer;
            Console.Write("Remove Duplicate Character and Remaining String is: ");

            // Use foreach loop to iterate over each character in the string
            foreach (char c in sentence)
            {
                // Calculate index for each character ('a' -> 0, 'z' -> 25)
                int index = c - 'a';

                // Increment the count for the current character
                arr[index]++;

                // If it's the first occurrence of the character, print it
                if (arr[index] == 1)
                {
                    answer = (char)(index + 'a');
                    Console.Write(answer);
                }
            }
            Console.WriteLine();
        }
    }
}
 */

