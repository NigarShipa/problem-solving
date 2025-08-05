//How do you remove a given character from String?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    internal class Remove_Given_Character
    {
        public static void RemoveCharacter()
        {
            string sentence = "Programming";
            char c = 'm';
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != c)
                {
                    result.Append(sentence[i]);
                }
            }
            Console.WriteLine("Remove a given character from String:" + result.ToString());
        }
    }
}
