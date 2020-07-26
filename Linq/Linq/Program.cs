using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //specify the data source
            int[] numbers = new[] { 2, 3, 4, 5 };

            //define the query
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            // execute a consult query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
