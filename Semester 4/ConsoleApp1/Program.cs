using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 69;
            int j = 81;
            for (int i = k; i <= j; i++)
            {
                string s =
                    $@"\includegraphics[width=\textwidth,height=\textheight,keepaspectratio]{{Pics/Pic ({i}).jpg}} \\ ";
                Console.WriteLine(s);
            }
        }
    }
}