using System.Diagnostics;

namespace ProcessTask
{
    class Program
    {
        public static void Main(string[] args)
        {

            using (Process process = new Process())
            {
                process.StartInfo.FileName = @"C:\Users\k.krachmarov\Desktop\TechnicalUniversity\Semester 4\ProcessFile\bin\Debug\net5.0\ProcessFile.exe";
                process.StartInfo.CreateNoWindow = false;
            
                process.Start();
            
                process.WaitForExit();
            }
            
            
            using (Process process = new Process())
            {
                process.StartInfo.FileName = @"C:\Users\k.krachmarov\Desktop\TechnicalUniversity\Semester 4\ProcessSort\bin\Debug\net5.0\ProcessSort.exe";
                process.StartInfo.CreateNoWindow = false;
            
                process.Start();
            
                process.WaitForExit();
            }
        }
    }
}