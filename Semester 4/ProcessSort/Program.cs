using System;
using System.IO;
using System.Linq;

namespace ProcessSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FileSort");
            string fileLocationRead =
                @"C:\Users\k.krachmarov\Desktop\TechnicalUniversity\Semester 4\ProcessFile\Test.txt";
            string fileLocationWrite =
                @"C:\Users\k.krachmarov\Desktop\TechnicalUniversity\Semester 4\ProcessSort\TestSorted.txt";
            int[] arr;
            using (StreamReader sr = new StreamReader(fileLocationRead))
            {
                arr = sr.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Array.Sort(arr);
            }

            using (StreamWriter sw = new StreamWriter(fileLocationWrite))
            {
                if (!File.Exists(fileLocationWrite))
                {
                    File.Create(fileLocationWrite);
                }
                string result = string.Join(" ", arr);
                Console.WriteLine(result);
                sw.Write(result);
            }
        }
    }
}