using System;

namespace AreaOfRec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            int recLen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of the rectangle?");
            int recWid = Convert.ToInt32(Console.ReadLine());
            int recArea = recLen * recWid;
            Console.WriteLine("The area of the rectangle is {0}", Convert.ToString(recArea));
        }
    }
}