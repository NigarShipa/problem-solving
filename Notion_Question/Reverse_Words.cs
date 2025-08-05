//10.How to reverse the words in a given String sentence? "my name is xyz” 
//output:  woH ot esrever eht sdrow ni a nevig gnirtS ecnetnes 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Reverse_Words
    {
        public static void ReverseByWord()
        {
            string s = "How to reverse the words in a given String sentence";
            StringBuilder result = new StringBuilder();

            // Split the string into words
            string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Iterate over each word in the sentence
            for (int i = 0; i < words.Length; i++)
            {
                // Reverse each word by iterating over its characters from the end
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    result.Append(words[i][j]);
                }

                // Add a space after each word except the last one
                if (i < words.Length - 1)
                {
                    result.Append(" ");
                }
            }

            Console.WriteLine("Reversed words in the given string: " + result.ToString());
        }
    }
}
