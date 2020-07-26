using Lambda.Services;
using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        //public static int globalValue = 3;
        //delegate double BinaryNumericOperation(double n1, double n2);

        //delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            //    int[] vect = new int[] { 3, 4, 5 }; 
            //    ChangeOddValues(vect); 
            //    Console.WriteLine(string.Join(" ", vect));
            //}
            //public static void ChangeOddValues(int[] numbers)
            //{
            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    if (numbers[i] % 2 != 0) 
            //    { 
            //        numbers[i] += globalValue; 
            //    } 
            //}
            ///////////////////////////////
            //double a = 10; 
            //double b = 12;
            //// BinaryNumericOperation op = CalculationService.Sum; 
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //// double result = op(a, b); 
            //double result = op.Invoke(a, b); 
            //Console.WriteLine(result);
            /////////////////////////////////
            //
            //double a = 10; 
            //double b = 12;
            //BinaryNumericOperation op = CalculationService.ShowSum; 
            //op += CalculationService.ShowMax; 
            //op(a, b);
            /////////////////////////////////////
            ///
            List<Product> list = new List<Product>();

             list.Add(new Product("tv", 900.00));
             list.Add(new Product("mouse", 50.00));
             list.Add(new Product("tablet", 350.50));
             list.Add(new Product("hd case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0);       
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            //list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {

                Console.WriteLine("ATUALIZADA COM 10% ; "+ p);

            }
        }

        static void UpdatePrice(Product p)
        {

            p.Price += p.Price * 0.1;
        }
    }
}
