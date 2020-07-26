using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 05, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!"; 
            Console.WriteLine(s1.Cut(10));

        }
    }
}
