using System;
namespace Lab3
{
    // Task 1 (1)
    public class Task1
    {
        public static void Main(String[] args)
        {
            PrintResult(0, 0);
            PrintResult(1, 0);
            PrintResult(-90, 0);
            PrintResult(20, 2);
            PrintResult(30, 6);
            PrintResult(31, 999);
            PrintResult(81, 10000);
            PrintResult(int.MaxValue, 8);

            PrintResult(7, 0);
            PrintResult(3, -1.676);
            PrintResult(9, -1000);
            PrintResult(30, 10);
            PrintResult(11, 4.6767);
            PrintResult(15, Math.E);
            PrintResult(6, Double.MinValue);
            PrintResult(1, Double.NaN);

            Console.ReadKey();
        }

        public static double FindResult(int k, double m)
        {
            if (k > 30 || k < 1) throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            else if (m < 0) throw new ArgumentOutOfRangeException(nameof(m), m, "Invalid value");
            
            double result = 0;

            for (int i = 1; i <= k; i++) result += Math.Sqrt(m / i) * Math.Sin(m * i);

            return result;
        }
        static void PrintResult(int k, double m)
        {
            Console.Write($"k:{k} m:{m} result:");
            try
            {
                Console.WriteLine(FindResult(k, m));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
            Console.WriteLine();
        }
    }
}