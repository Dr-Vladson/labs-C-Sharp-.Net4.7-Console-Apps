using System;
namespace Lab3
{
    // Task 2 (9)
    public class Task2
    {
        public static void Main(String[] args)
        {
            PrintResult(0, 0);
            PrintResult(-8, 6);
            PrintResult(-1, 99);
            PrintResult(1, -7);
            PrintResult(1, 0);
            PrintResult(1, 1);
            PrintResult(2, 1);
            PrintResult(1, 6);
            PrintResult(1, 7);
            PrintResult(4, 10);
            PrintResult(10, 7);
            PrintResult(7, int.MaxValue);
            PrintResult(1, int.MinValue);
            PrintResult(8, int.MinValue);

            Console.ReadKey();
        }

        public static double FindResult(int t, int l)
        {
            if (t < 1) throw new ArgumentOutOfRangeException(nameof(t), t, "Invalid value");
            else if (l < 1) throw new ArgumentOutOfRangeException(nameof(l), l, "Invalid value");

            double result = 0;

            if (l % 2 == 1)
            {
                for (int i = 1; i <= t; i++) result += Math.Sqrt(t * l); 
            }
            else
            {
                for (int i = 1; i <= t; i++) result += l / Math.Sqrt(t);
            }

            return result;
        }
        static void PrintResult(int t, int l)
        {
            Console.Write($"t:{t} l:{l} result:");
            try
            {
                Console.WriteLine(FindResult(t, l));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("EXCEPTION! {0}", e.Message);
            }
            Console.WriteLine();
        }
    }
}
