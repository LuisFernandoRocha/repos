using ExecicoLambdaFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExecicoLambdaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter full file path: ");
            // string path = //Console.ReadLine();
            string Path = @"C:\Users\Fernando\source\repos\ExecicoLambdaFuncionario\Funcionario.txt";
            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }

                }

                foreach (Employee emp in list)
                {
                    Console.WriteLine("nome: " + emp.Name + "  Email :" + emp.Email + "  Salario :" + emp.Salary);
                }
                Console.WriteLine();

                Console.Write("Enter salary: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var emails = list.Where(p => p.Salary > limit)
                    .OrderBy(obj => obj.Email)
                    .Select(obj => obj.Email);
                var sum = list.Where(obj => obj.Name[0] == 'M')
                    .Sum(obj => obj.Salary);

                Console.WriteLine("Email of people whose salary is more than " 
                    + limit.ToString("F2", CultureInfo.InvariantCulture));

                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " 
                    + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine(" error "+ e);
            }
           

        }
    }
}
