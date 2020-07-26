using System;
using System.Collections.Generic;
using System.IO;

namespace File3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\Fernando\source\repos\myfolder";
            
            try
            {
                var folders =  Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS; ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES; ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(Path+"\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("AN error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
