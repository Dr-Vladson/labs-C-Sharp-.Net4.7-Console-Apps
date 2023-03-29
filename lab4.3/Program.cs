using System;
namespace Lab4
{
    /* Task 3 (62) Задано масив цілих чисел. Сформувати новий масив у наступний спосіб: поділити
    усі елементи масиву на його найменший елемент, якщо найменший елемент
    відмінний від нуля; якщо ж найменший елемент дорівнює нулю, то всі елементи
    масиву замінити на - 10.*/

    public class Task3
    {
        public static void Main(String[] args)
        {
            PrintResult(null);
            PrintResult(new int[] {});

            PrintResult(new int[] {8,9,4,75,9,0,90,45});
            PrintResult(new int[] {0,8,9,4,75,9,90,45,67,66});
            PrintResult(new int[] {0,8,9,4,int.MaxValue,9,90,int.MaxValue});

            PrintResult(new int[] {2,8,9,4,6,9,90,67,-1});
            PrintResult(new int[] {6,8,9,4,3,9,90,67,30,90,46});
            PrintResult(new int[] {180,810,9,450,-6,90000,-90,67, 100000});
            PrintResult(new int[] {0,8,9,4,-3,9,-2,67, int.MaxValue});
            PrintResult(new int[] {0, int.MaxValue, 9, int.MaxValue, int.MinValue,9, int.MinValue, 67, int.MinValue});
       
           
            Console.ReadKey();
        }

        public static double [] FindResult(int [] numsArray)
        {
            if (numsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (numsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

            double[] newNumsArray = new double[numsArray.Length];
            int minNum = int.MaxValue;
            foreach (int num in numsArray)
            {
                if (num < minNum) minNum = num;
            }
            if (minNum == 0) for (int i = 0; i < newNumsArray.Length; i++) newNumsArray[i]= 10;
            else for (int i = 0; i < newNumsArray.Length; i++) newNumsArray[i] = Convert.ToDouble(numsArray[i]) / Convert.ToDouble(minNum);

            return newNumsArray;
        }
        static void PrintResult(int [] numsArray)
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

            Console.Write("Output array: ");
            try
            {
                double [] newNumsArray = FindResult(numsArray);
                for (int i = 0; i < newNumsArray.Length; i++)
                {
                    if (i == newNumsArray.Length - 1) Console.Write("{0}.\n", newNumsArray[i]);
                    else Console.Write("{0}, ", newNumsArray[i]);
                }
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