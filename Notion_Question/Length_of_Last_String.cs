using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Notion_Question
{
    public class Length_of_Last_String
    {
        public static void LengthofLastString()
            {
            string sentence = "Hello World ";
            int count = 0 ;
            for(int i= sentence.Length-1; i>=0 ; i--)
            {
                if(sentence[i] == ' ' && count >0)
                {
                  break; 
                }
                if(sentence[i] != ' ')
                {
                    count++;
                }
            }
              Console.WriteLine("Length of the last string is: " + count);
            
            }

    }
}