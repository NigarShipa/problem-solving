// remove characters from the first String which are present in the second String
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Remove_Characters_From_First_String_Which_Are_Present_In_Second_String
    {
        public static void RemoveCharacter()
        {
            string s1 = "remove characters from the first String which are present in the second String";
            string s2 = "first";
            StringBuilder answer = new StringBuilder();
            string[] words = s1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != s2)
                {
                    answer.Append(words[i]);
                    if (i < words.Length - 1)
                    {
                        answer.Append(" ");
                    }
                }
            }
            Console.WriteLine("Remove characters : " + answer.ToString());
        }
    }
}
