using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() 
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            Console.WriteLine(SumOfEven(numbers));

        }
        public static int SumOfEven(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    sum += number;
            }
            return sum;
        }
    }
}
