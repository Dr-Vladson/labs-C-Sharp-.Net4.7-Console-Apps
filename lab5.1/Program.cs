using System;
namespace Lab5
{
    // Task 1 (4) void Transpose(int[][] matrix) {} Транспонувати квадратну матрицю.

    public class Task1
    {
        public static void Main(String[] args)
        {
            PrintResult(new int[][] {});
            PrintResult(null);
            PrintResult(new int[][] {null});
            PrintResult(new int[][] { new int[] { } });
            PrintResult(new int[][] { new int[] { 1 } });
            PrintResult(new int[][] {new int[] { 1 ,2 ,3 }, null, new int[] { 7, 8, 9 }});
            PrintResult(new int[][] {new int[] { 1 ,2 ,3 }, new int[] { 4, 5, 6 }});
            PrintResult(new int[][] {new int[] { 1 ,2 ,3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 8 }, new int[] { 10, 11, 12 } });
            PrintResult(new int[][] { null, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9, } });
            PrintResult(new int[][] {new int[] { 1 ,2 ,3 }, new int[] { }, new int[] { 7, 8, 9 }});
            PrintResult(new int[][] {new int[] { 1 ,2 ,3 }, new int[] {4 , 5 ,6 }, new int[] { 7, 8, 9 , 10 }});
            PrintResult(new int[][] {new int[] { 1 ,2 }, new int[] {4 , 5 ,6 }, new int[] { 7, 8, 9}});
            PrintResult(new int[][] {new int[] { 1 ,2, 3 }, new int[] {4 , 5 ,6 }, new int[] { 7, 8, 9 }});
            PrintResult(new int[][] {new int[] { 1 ,2, 3 , 4}, new int[] {5 , 6 ,7,8 }, new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } });
            PrintResult(new int[][] {new int[] { 1 ,2}, new int[] {3,4}});
            PrintResult(new int[][] {new int[] { 1 ,int.MaxValue}, new int[] {int.MinValue,4}});
            

            Console.ReadKey();
        }

        public static void Transpose(int[][] matrix)
        {
            if (matrix == null) throw new NullReferenceException("Null instead of matrix cannot be proceeded");

            int matrixlength = matrix.Length;

            if (matrixlength == 0) throw new ArgumentException("Matrix should not be empty");

            int[][] matrixCopy = new int [matrixlength][];

            for (int i = 0; i < matrixlength; i++)
            {
                matrixCopy[i] = new int[matrixlength];
                if (i == 0)
                {
                    if (matrix[i] == null) throw new NullReferenceException("Null instead of matrix row cannot be proceeded");
                    if (matrixlength != matrix[i].Length) throw new ArgumentException("Matrix should not be non-square");

                    for (int j = 0; j < matrixlength; j++)
                    {
                        if (j != 0)
                        {
                            if (matrix[j] == null) throw new NullReferenceException("Null instead of matrix row cannot be proceeded");
                            if (matrixlength != matrix[j].Length) throw new ArgumentException("Matrix should not be non-square");
                        }

                        matrixCopy[i][j] = matrix[i][j];
                    }
                }
                else
                {
                    for (int j = 0; j < matrixlength; j++) matrixCopy[i][j] = matrix[i][j];
                }
            }

            for (int i = 0; i < matrixlength; i++) for (int j = 0; j < matrixlength; j++) matrix[j][i] = matrixCopy[i][j];
        }
        static void PrintResult(int[][] matrix)
        {
            if (matrix == null) Console.WriteLine("Input: null");
            else if (matrix.Length == 0) Console.WriteLine("Input: empty matrix {}");
            else
            {
                Console.WriteLine("Input matrix:");
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i] == null) Console.Write("This row is null");
                    else if (matrix[i].Length == 0) Console.Write("This row is empty array");
                    else
                    {
                        Console.Write("This row:  ");
                        for (int j = 0; j < matrix[i].Length; j++) Console.Write(matrix[i][j] + "  ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Transposed matrix: ");
            try
            {
                Transpose(matrix);
                foreach(int [] row in matrix)
                {
                    foreach(int num in row) Console.Write(num + "  ");
                    Console.WriteLine();
                }
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

