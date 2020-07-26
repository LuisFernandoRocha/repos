using System;
using System.IO;

namespace Info
{
    class Program
    {
      

        static void Main(string[] args)
        {
            string soucePath = @"C:\Users\Fernando\source\repos\File1.txt";
            string targePath = @"C:\Users\Fernando\source\repos\File2.txt"; ;
            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targePath);

                string[] lines = File.ReadAllLines(soucePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("AN error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
