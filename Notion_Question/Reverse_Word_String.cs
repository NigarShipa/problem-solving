//9.How to reverse the words in a given String sentence? 
// output : ? sentence String given a in words the reverse to How
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Reverse_Word_String
    {
        public static void ReverseWord()
        {
            string sentence = "How to reverse the words in a given String sentence ?";
            // Split the sentence into words
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Use StringBuilder for efficient string concatenation
            StringBuilder reverseWord = new StringBuilder();

            // Loop through the words in reverse order
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverseWord.Append(words[i]);
                // Add a space between words but not after the last word
                if (i > 0)
                {
                    reverseWord.Append(" ");
                }
            }
            // Output the reversed sentence
            Console.WriteLine("Reversed sentence: " + reverseWord.ToString());
        }
    }
}
