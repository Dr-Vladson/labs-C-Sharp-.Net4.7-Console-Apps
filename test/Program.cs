using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            // Let's find: 1 + 1/2 + 1/3 + 1/4 + 1/5 + ...
            for (int i = 1; i < 10; i++)
            {
                sum = sum + 1 / i;
            }
            Console.WriteLine(sum > 1);

            Console.ReadKey();
        }
    }
}
