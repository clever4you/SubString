using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var list = new List<char>();
            int result = 0;

            foreach (var c in s)
            {
                if (list.Contains(c))
                {
                    var indexOfDuplicate = list.IndexOf(c);
                    list.RemoveRange(0, indexOfDuplicate + 1);
                }
                list.Add(c);
                if (result < list.Count)
                {
                    result = list.Count;
                }
            }
            return result;
        }
    }
}