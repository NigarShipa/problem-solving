//8.How to find index number of a word in a sentence? 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class TargetIndex
    {
        public static void TragetWordIndex()
        {
            string sentence = "Count number of word in this sentence";
            string targetWord = "this";
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (targetWord == words[i])
                {
                    Console.WriteLine("Target Word Index Number : " + i);
                    break;
                }
            }

        }
    }
}
