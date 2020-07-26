using System;
using System.Collections.Generic;
using System.IO;
using ProjetoMotivador.Entities;

namespace ProjetoMotivador
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Fernando\source\repos\ProjetoMotivador\Funcionarios.txt";
            try 
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee( sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }


                //// using (FileStream fs = new FileStream(path, FileMode.Open)) 
                //// { 
                //// using (StreamReader sr = new StreamReader(fs)) 
                //using (StreamReader sr = File.OpenText(path))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            Console.WriteLine(line);
                //        }

                //    }
                //    //  } 
                ////}
            }
            catch (IOException e) 
            { 
                Console.WriteLine("An error occurred"); 
                Console.WriteLine(e.Message); }

        }
    }
}
