using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            String quote = "Alice was beginning to get very tired of sitting " +
                "by her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no " +
                "pictures or conversations in it, 'and what is the use of a book,' " +
                "thought Alice 'without pictures or conversation?'";
            Console.WriteLine(quote);
            Console.WriteLine("Which word or phrase do you want to search for in the quote above?");
            String selection = Console.ReadLine().ToLower();
            if (quote.ToLower().Contains(selection) == false)
            {
                Console.WriteLine("{0} is not in the quote!", selection);
            }
            else
            {
                Console.WriteLine("{0} is in the quote!", selection);
            }
        }
    }
}
