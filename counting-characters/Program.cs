using System;
using System.Collections.Generic;

namespace counting_characters
{
    class Program
    {
        private static Dictionary<char, int> CountCharacters(String paragraph)
        {
            char[] collection = paragraph.ToCharArray();
            int countChar = 1;
            Dictionary<char, int> letterDictionary = new Dictionary<char, int>();

            foreach (char letter in collection)
            {
                if (!letterDictionary.ContainsKey(letter))
                {
                    letterDictionary.Add(letter, countChar);
                }
                else
                {
                    letterDictionary[letter] += 1;
                }
            }

            return letterDictionary;
        }

        public static void Main(string[] args)
        {
            string paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> letterDictionary = CountCharacters(paragraph);

            foreach (KeyValuePair<char, int> kvp in letterDictionary)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }

        }
    }
}