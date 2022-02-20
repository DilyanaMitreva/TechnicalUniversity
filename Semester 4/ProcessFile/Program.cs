using System;
using System.IO;

namespace ProcessFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FileCreate");
            string fileLocation = @"C:\Users\k.krachmarov\Desktop\TechnicalUniversity\Semester 4\ProcessFile\Test.txt";

            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation);
            }

            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(1, 100);
            }

            using (StreamWriter sw = new StreamWriter(fileLocation))
            {
                string result = string.Join(" ", arr);
                Console.WriteLine(result);
                sw.Write(result);
            }
        }
    }
}