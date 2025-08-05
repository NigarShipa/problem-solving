////1.How to print the duplicate characters from the given String if input looks like aabbbac?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Duplicate_Character
    {
        public static void Duplicate()
        {
            var input = "aabbac"; // Input string
            var arr = new int[26]; // Array to count occurrences of each character

            // Count occurrences of each character in the input string
            for (var i = 0; i < input.Length; i++)
            {
                var index = input[i] - 'a'; // Calculate index (assuming lowercase letters)
                arr[index]++;
            }

            Console.Write("Duplicate Characters: ");

            // Check for duplicates and print them
            for (var i = 0; i < 26; i++)
                if (arr[i] > 1) // If the character occurs more than once
                {
                    var duplicateCharacter = (char)(i + 'a'); // Convert index back to character
                    Console.WriteLine(duplicateCharacter);

                }



        }
    }
}

