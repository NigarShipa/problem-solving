//6. Find Total number of word found in the given string?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Total_Number_Of_Word_Found
    {
        public static void NumberFound()
        {
            var word = "Count number of word in this sentence";
            var count = 0;
            for (var i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                    count++;
            }
            count = count + 1;
            Console.WriteLine("Number of Word :" + count);
        }
    }
}
