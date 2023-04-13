using System;
namespace Lab4
{
    // Task 2 (46) Знайти суму елементів, що більші 3-x і індекс яких кратний 2
    public class Task2
    {
        public static void Main(String[] args)
        {
            PrintResult(new double[] { });
            PrintResult(null);
            PrintResult(new double[] { 12, 90, 1.1, 0, Double.NaN });
            PrintResult(new double[] { Double.NaN, 2, 8, 7.4444 });
            Console.WriteLine();
            PrintResult(new double[] { -9, 2, 8, 7.4444 });
            PrintResult(new double[] { 3, 2, 3, 7.4444, 3.1 });
            PrintResult(new double[] { 6, 220, 6 });
            PrintResult(new double[] { 0, 220, 0, 9 });
            PrintResult(new double[] { 6.67, 0.666, 4.777, 9.3434, 1.6666, 1.566655, 2.345345, 88.66 });
            PrintResult(new double[] { 7, 90, 2, 7, 8, 9, 2, 88.66, 67.777, 6, 90, 45, 32, 678.8, 67.44, 11, 2, 667, 9, 45, 88 });
            PrintResult(new double[] {double.MaxValue, 2, double.MinValue, 7.4444, 3.1 });

            Console.ReadKey();
        }

        public static double FindResult(double[] numsArray)
        {
            if (numsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (numsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

            double sum = 0;
            for (int i = 0; i < numsArray.Length; i += 2)
            {
                double num = numsArray[i];
                if (Double.IsNaN(num)) throw new ArgumentException("NaNs are not allowed.....");

                if (num > 3) sum += num;
            }

            return sum;
        }
        static void PrintResult(double[] numsArray)
        {
            if (numsArray == null) Console.Write("Input: null. ");
            else if (numsArray.Length == 0) Console.Write("Input: empty array. ");
            else
            {
                Console.Write("Input array: ");
                for (int i = 0; i < numsArray.Length; i++)
                {
                    if (i == numsArray.Length - 1) Console.Write("{0}. ", numsArray[i]);
                    else Console.Write("{0}, ", numsArray[i]);
                }
            }

            Console.Write("Sum of required elements: ");
            try
            {
                Console.WriteLine(FindResult(numsArray));
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine("EXCEPTION! {0}", exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine("EXCEPTION! {0}", exc.Message);
            }
            Console.WriteLine();
        }
    }
}

