using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> ids = new List<int>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    names.Add(newStudent);
                }
            }
            while (newStudent != "");

            Console.WriteLine("\nClass roster:");
            // Console.ReadLine();

            // for (int i = 0; i < names.Count; i++)
            int id = 0;
            foreach (string name in names)
            {
                id += 1;
                Console.WriteLine(name + " " + id);
                // Console.WriteLine(id);
                // Console.WriteLine(names[i] + " (" + ids[i] + ")");
                // Console.ReadLine();
            }
        }
    }
}