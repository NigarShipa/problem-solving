//convert String to an integer? Input : +&(231
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class String_To_Integer
    {
        public static void StrToInt()
        {
            string input = "+&(231";
            int digit, answer;
            Console.WriteLine("Convert String to an integer = +&(231 : ");
            for (int i = 0; i < input.Length; i++)
            {
                digit = (int)input[i];  // '0': ASCII value is 48 and '9': ASCII value is 57
                if (digit >= 48 && digit <= 57)
                {
                    answer = digit - 48;
                    Console.WriteLine(answer);
                }

            }
        }
    }
}
