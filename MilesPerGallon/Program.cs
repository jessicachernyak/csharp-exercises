using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many gallons have you used?");
            int gallons = Convert.ToInt32(Console.ReadLine());
            int mpg = miles / gallons;
            Console.WriteLine("Your miles per gallon is {0}", Convert.ToString(mpg));
        }
    }
}
