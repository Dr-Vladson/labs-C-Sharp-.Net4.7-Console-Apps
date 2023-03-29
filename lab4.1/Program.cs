using System;
namespace Lab4
{
    // Task 1 (16) Знайти середнє геометричне парних елементів масиву
    public class Task1
    {
        public static void Main(String[] args)
        {
            PrintResult(new double [] {});
            PrintResult(null);
            PrintResult(new double [] {12, 90, 1.1, 0, Double.NaN});
            PrintResult(new double [] {Double.NaN, 2,8,7.4444});
            PrintResult(new double [] {-9, 2,8,7.4444});
            PrintResult(new double [] {2.2, 2,-8.99999,7.4444});
            Console.WriteLine();
            PrintResult(new double [] {2,220,2});
            PrintResult(new double [] {4,220,5,0});
            PrintResult(new double [] {2, 90,2,7,2,9,2,88.66});
            PrintResult(new double [] {0, 90,2,7,2,9,2,88.66});
            PrintResult(new double [] {2, 90,2,7,0,9,2,88.66});
            PrintResult(new double [] {2, 0,2,7,2,9,2,88.66});
            PrintResult(new double [] {2.888, 0.666,2.777,7.3434,2.6666,9.566655,2.345345,88.66});
            PrintResult(new double[] { 2, 90, 2, 7, 2, 9, 2, 88.66, 67.777, 6, 90, 45, 32, 678.8, 67.44, 11, 2, 667, 9, 45, 88 });
            PrintResult(new double[] {double.MaxValue, 90});
            
            Console.ReadKey();
        }

        public static double FindResult(double [] numsArray)
        {
            if (numsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (numsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

            double geometricAverage = 1;
            int geometricAverageRootDegreeCount = 0;
            for (int i = 0; i < numsArray.Length; i+=2)
            {
                double num = numsArray[i];
                if (Double.IsNaN(num)) throw new ArgumentException("NaNs are not allowed.....");

                if (num < 0) throw new ArgumentException("Negative nums are not allowed.....");

                geometricAverage *= num;
                geometricAverageRootDegreeCount++;
            }
            
            return Math.Pow(geometricAverage, 1/Convert.ToDouble(geometricAverageRootDegreeCount));
        }
        static void PrintResult(double [] numsArray)
        {
            if (numsArray == null) Console.Write("Input: null. ");
            else if (numsArray.Length == 0) Console.Write("Input: empty array. ");
            else
            {
                Console.Write("Input array: ");
                for (int i = 0; i < numsArray.Length; i++) {
                    if (i == numsArray.Length - 1) Console.Write("{0}. ", numsArray[i]);
                    else Console.Write("{0}, ", numsArray[i]); 
                }
            }

            Console.Write("Geometric average: ");
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
