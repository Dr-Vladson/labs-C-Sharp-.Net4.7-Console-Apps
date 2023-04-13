using System;
namespace Lab5
{
    /* Task 2 (1) int MinElementInLargestColumn(int[][] matrix) {}
    Знайти найменше зі значень елементів стовпця, який має найбільшу суму модулів елементів.
    Якщо таких стовпців декілька, то знайти найменше значення серед них.*/


    public class Task2
    {
        public static void Main(String[] args)
        {
            PrintResult(new int[][] { });
            PrintResult(null);
            PrintResult(new int[][] { null });
            PrintResult(new int[][] { new int[] { } });
            PrintResult(new int[][] { new int[] { 1, 2, 3 }, null, new int[] { 7, 8, 9 } });
            PrintResult(new int[][] { null, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9, } });
            PrintResult(new int[][] { new int[] { 1, 2, 3 }, new int[] { }, new int[] { 7, 8, 9 } });
            PrintResult(new int[][] { new int[] { 1, 2,}, new int[] { 4, 5, 6 } });
            PrintResult(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9, 10}, new int[] { 10, 11, 12 } });
            PrintResult(new int[][] { new int[] { 1 }, new int[] { 4, 6 }, new int[] {7} });

            PrintResult(new int[][] { new int[] { 121 } });
            PrintResult(new int[][] { new int[] { 1 }, new int[] { 2 }, new int[] { -3 }, new int[] { 3 }, new int[] { 6 } });
            PrintResult(new int[][] { new int[] { 1, 2, -33, 7,9,13,90 } });
            PrintResult(new int[][] { new int[] { 5, 2, 3, 30,4,8,0 }, new int[] { 4, 6, 7, -30,9,9,4 }, new int[] { 6, 10, 11, -20, 8,-2,2 } });
            PrintResult(new int[][] { new int[] { 9,2 }, new int[] { 9,6 }, new int[] { 9,-9 }, new int[] { 9,9 }, new int[] { 8,0 }, new int[] { 8, 6 } });
            PrintResult(new int[][] { new int[] { 1, 2, -3 }, new int[] { 4, 5, -6 }, new int[] { 7, 8, -9 } });

            PrintResult(new int[][] { new int[] { 1, 0, -1 }, new int[] { 4, 1, -4 }, new int[] { 7, 0, -7 } });
            PrintResult(new int[][] { new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 } });
            PrintResult(new int[][] { new int[] { 1, 4, 0, 2 }, new int[] { 2, 3, 0, 2 }, new int[] { 3, 2, -10, 0 }, new int[] { 4, 1, 0, -6 } });


            Console.ReadKey();
        }

        public static int MinElementInLargestColumn(int[][] matrix)
        {
            if (matrix == null) throw new NullReferenceException("Null instead of matrix cannot be proceeded");
            int columnlength = matrix.Length;
            if (columnlength == 0) throw new ArgumentException("Matrix should not be empty");

            if (matrix[0] == null) throw new NullReferenceException("Null instead of matrix row cannot be proceeded");
            int rowLength = matrix[0].Length;
            if (rowLength == 0) throw new ArgumentException("Matrix row should not be empty");

            int maxSumOfColumnsAbsoluteValues = int.MinValue;
            int minElementInLargestColumn = int.MaxValue;

            // 1 simple case matrix with one element

            if (rowLength == 1 && columnlength == 1) return matrix[0][0];

            // 2 simple case vector-column

            if (rowLength == 1)
            {
                minElementInLargestColumn = matrix[0][0];
                for(int i = 1; i < columnlength; i++)
                {
                    int[] row = matrix[i];
                    if (row == null) throw new NullReferenceException("Null instead of matrix row cannot be proceeded");
                    if (row.Length == 0) throw new ArgumentException("Matrix row should not be empty");
                    if (row.Length != rowLength) throw new ArgumentException("Matrix columns should have same amount of elements");
            
                    if (row[0] < minElementInLargestColumn) minElementInLargestColumn = row[0];
                }
                return minElementInLargestColumn;
            }
            
            // 3 simple case vector-row
            
            if (columnlength == 1)
            {
                foreach (int num in matrix[0]) 
                {
                    if (Math.Abs(num) > maxSumOfColumnsAbsoluteValues)
                    {
                        maxSumOfColumnsAbsoluteValues = Math.Abs(num);
                        minElementInLargestColumn = num;
                    }
                }
                return minElementInLargestColumn;
            }
            // 4 usual case

            // 4.1 search for sum of all column's element's absolute values for every column

            int [] sumsOfColumnsAbsoluteValues = new int[rowLength];
            for (int i = 0; i < columnlength; i++)
            {
                if (i != 0)
                {
                    if (matrix[i] == null) throw new NullReferenceException("Null instead of matrix row cannot be proceeded");
                    if (matrix[i].Length == 0) throw new ArgumentException("Matrix row should not be empty");
                    if (matrix[i].Length != rowLength) throw new ArgumentException("Matrix columns should have same amount of elements");
                }

                for (int j = 0; j < rowLength; j++)
                {
                    if (i == 0) sumsOfColumnsAbsoluteValues[j] = 0;
                    sumsOfColumnsAbsoluteValues[j] += Math.Abs(matrix[i][j]);

                    if (i == columnlength - 1) // 4.2 search for the largest sum of absolute values
                    {
                        if (sumsOfColumnsAbsoluteValues[j] > maxSumOfColumnsAbsoluteValues) maxSumOfColumnsAbsoluteValues = sumsOfColumnsAbsoluteValues[j];
                    }
                }
            }

            // 4.3 search for minimal element in all columns with the largest sum of absolute values

            for (int j = 0; j < rowLength; j++) 
            {
                if (sumsOfColumnsAbsoluteValues[j] == maxSumOfColumnsAbsoluteValues)
                {
                    foreach (int [] row in matrix)
                    {
                        int num = row[j];
                        if (num < minElementInLargestColumn) minElementInLargestColumn = num;
                    }
                }
            }

            return minElementInLargestColumn;
        }
        static void PrintResult(int[][] matrix)
        {
            if (matrix == null) Console.WriteLine("Input matrix: null");
            else if (matrix.Length == 0) Console.WriteLine("Input matrix: empty matrix {}");
            else
            {
                Console.WriteLine("Input matrix:");
                foreach (int [] row in matrix)
                {
                    if (row == null) Console.Write("This row is null");
                    else if (row.Length == 0) Console.Write("This row is empty array");
                    else
                    {
                        Console.Write("This row:  ");
                        foreach (int num in row) Console.Write(num + "  ");
                    }
                    Console.WriteLine();
                }
            }

            try
            {
                Console.WriteLine("MinElementInLargestColumn: " + MinElementInLargestColumn(matrix));
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine("EXCEPTION! {0}.....", exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine("EXCEPTION! {0}.....", exc.Message);
            }

            Console.WriteLine("\n");
        }
    }
}

