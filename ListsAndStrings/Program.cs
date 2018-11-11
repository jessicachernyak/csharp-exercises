using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> words = new List<string>()
            {
                "cat", "dog", "bird", "frog", "rabbit", "bunny", "turtle", "tortoise", "fish", "fishy"
            };
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            };
        }
    }
}
