//7.Find Total number of word found in the given string? using builtin function
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Notion_Question
{
    public class Total_Number_Found_BuiltInFunction
    {
        public static void Total_Number_Found()
        {
            string sentence = "Count number of word in this sentence";
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var count = words.Length;
            Console.WriteLine("Number of Word :" + count);
        }
    }
}
