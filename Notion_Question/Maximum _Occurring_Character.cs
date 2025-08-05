//3.How to find the maximum occurring character in a given String? using array : "abcaaabbc"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class Maximum_Occurring_Character
    {
        public static void Max_Occuring_Ch()
        {
            var input = "abcaaabbc";
            var arr = new int[26];

            // Count the frequency of each character
            for (var i = 0; i < input.Length; i++)
            {
                var index = input[i] - 'a';
                arr[index]++;
            }
            var mx = int.MinValue;
            var answer = '\0'; // Initialize answer

            // Find the most frequent character
            for (var i = 0; i < 26; i++)
            {
                if (arr[i] > mx)
                {
                    mx = arr[i];
                    answer = (char)(i + 'a'); // Update answer only when the max frequency is found
                }
            }
            Console.WriteLine("Maximum Occuring Number : " + answer);

        }
    }
}
