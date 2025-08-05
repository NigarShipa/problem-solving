//2.How to print the duplicate characters from the given String if input looks like Abac a aBvV?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Duplicate_Character_Upper_Lower_Case
    {
        public static void Duplicate_Character()
        {
            var input = "AaVvc";
            var arr = new int[26];
            var newInput = new List<char>();
            for (var i = 0; i < input.Length; i++)
                if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z'))
                {
                    var lower = char.ToLower(input[i]);
                    newInput.Add(lower); // Add the lowercase character to the list
                }

            for (var i = 0; i < newInput.Count; i++)
            {
                var index = newInput[i] - 'a';
                arr[index]++;
            }

            Console.Write("Duplicate Characters : ");
            for (var i = 0; i < 26; i++)
                if (arr[i] > 1)
                {
                    var duplicateCharacters = (char)(i + 'a');
                    Console.WriteLine(duplicateCharacters + " ");
                }

        }
    }
}
