//1. Program to find the minimum and maximum element of an array : {1, 423, 6, 46, 34, 23, 13, 53, 4}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notion_Question
{
    public class MinAndMax
    {
        public static void MinMax()
        {
            int[] arr = { 1, 423, 6, 46, 34, 23, 13, 53, 4 };
            var minValue = int.MaxValue;
            var maxValue = int.MinValue;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue) maxValue = arr[i];
                if (arr[i] < minValue) minValue = arr[i];
            }

            Console.WriteLine("Minimum value :" + minValue);
            Console.WriteLine("Maximum value:" + maxValue);
        }
    }
}
