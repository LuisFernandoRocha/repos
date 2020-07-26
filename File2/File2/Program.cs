using System;
using System.IO;

namespace File2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Fernando\source\repos\File2\file1.txt"; 
            ////FileStream fs = null;
            //StreamReader sr = null;
            //try
            //{
            //  // fs = new FileStream(path, FileMode.Open);               
            //    sr = File.OpenText(path);
            //    //  sr = new StreamReader(fs); 

            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }

            //}
            //catch (IOException e) 
            //{ Console.WriteLine("An error occurred"); 
            //    Console.WriteLine(e.Message); 
            //}
            //finally 
            //{ 
            //    if (sr != null) sr.Close(); 
            //   // if (fs != null) fs.Close(); 
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////
            string path = @"C:\Users\Fernando\source\repos\File2\file1.txt";
            try
            {
                // using (FileStream fs = new FileStream(path, FileMode.Open)) 
                // { 
                // using (StreamReader sr = new StreamReader(fs)) 
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
                //  } 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            /////////////////////////////////////////////////////////////////
            //string soucePath = @"C:\Users\Fernando\source\repos\File2\file1.txt";
            //string targePath = @"C:\Users\Fernando\source\repos\File2\file2.txt";
            //try
            //{
            //    //FileInfo fileInfo = new FileInfo(soucePath);
            //    //fileInfo.CopyTo(targePath);

            //    //string[] lines = File.ReadAllLines(soucePath);
            //    //foreach (string line in lines)
            //    //{
            //    //    Console.WriteLine(line);
            //    //}
            //    string[] lines = File.ReadAllLines(soucePath);
            //    using (StreamWriter sw = File.AppendText(targePath))
            //    { 
            //        foreach (string line in lines)
            //        { 
            //            sw.WriteLine(line.ToUpper());
            //        } 
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("AN error occurred");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
