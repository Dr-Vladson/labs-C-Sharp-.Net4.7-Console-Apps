using System;
namespace Lab6
{
    // В-16 byte[] по спаданню Bubble sort Selection sort
    public class Task
    {
        public static void Main(String[] args)
        {
            PrintResult(new byte[] { });
            PrintResult(null);
            PrintResult(new byte[] { 5, 1, 4, 2, 8 });
            PrintResult(new byte[] { 8, 2, 5, 1, 4 });
            PrintResult(new byte[] { 8, 5, 1, 4, 2 });
            PrintResult(new byte[] { 8, 5, 4, 2, 1 });
            PrintResult(new byte[] { 0, 0, 0, 0, 0 });
            PrintResult(new byte[] { 0, 0, 0, 0, 1 });
            PrintResult(new byte[] { 8, 2, 11, 12, 45 , 44, 5, 23, 11, 1, 4, 100 });

            Console.ReadKey();
        }

        public static byte [] SelectionSort(byte[] initialNumsArray)
        {
            if (initialNumsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (initialNumsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

            byte[] numsArray = new byte[initialNumsArray.Length];
            initialNumsArray.CopyTo(numsArray, 0);

            int workingLength = numsArray.Length;
            for (int i = 0; i < numsArray.Length - 1; i++) {

                int minNumIndex = 0;
                byte minNum = numsArray[minNumIndex];

                for (int j = 1; j < workingLength; j++)
                {
                    byte currentNum = numsArray[j];
                    if (currentNum < minNum)
                    {
                        minNum = currentNum;
                        minNumIndex = j;
                    }
                }
                Console.WriteLine("Minimal element {0} will be transported on position {1}.", minNum, workingLength - 1);

                numsArray[minNumIndex] = numsArray[workingLength - 1];
                numsArray[workingLength - 1] = minNum;

                workingLength--;
            }

            return numsArray;
        }

        public static byte [] BubbleSort(byte[] initialNumsArray)
        {
            if (initialNumsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (initialNumsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

            byte[] numsArray = new byte[initialNumsArray.Length];
            initialNumsArray.CopyTo(numsArray, 0);

            bool changesOniteration = true;
            int workingLength = numsArray.Length - 1;
            while (changesOniteration && workingLength >= 1)
            {
                Console.Write("New iteration: ");
                changesOniteration = false;
                for (int i = 0; i < workingLength; i++)
                {
                    Console.Write("compare {0} with {1} - ", numsArray[i], numsArray[i + 1]);
                    if (numsArray[i] < numsArray[i + 1])
                    {
                        Console.Write("replace. ");
                        byte currentNum = numsArray[i];
                        numsArray[i] = numsArray[i + 1];
                        numsArray[i + 1] = currentNum;

                        if (!changesOniteration) changesOniteration = true;
                    }
                    else Console.Write("dont replace; ");
                }
                Console.WriteLine();

                workingLength--;
            }

            return numsArray;
        }
        static void PrintResult(byte [] numsArray)
        {
            if (numsArray == null) Console.Write("Input: null. ");
            else if (numsArray.Length == 0) Console.Write("Input: empty array. ");
            else
            {
                Console.Write("Input array: ");
                for (int i = 0; i < numsArray.Length; i++)
                {
                    if (i == numsArray.Length - 1) Console.Write("{0}.", numsArray[i]);
                    else Console.Write("{0}, ", numsArray[i]);
                }
                Console.WriteLine();
            }

            try
            {
                byte[] SelectionSortedArray = SelectionSort(numsArray);
                Console.Write("\nSelection sorted Array: ");
                for (int i = 0; i < SelectionSortedArray.Length; i++)
                {
                    if (i == SelectionSortedArray.Length - 1) Console.Write("{0}.\n\n", SelectionSortedArray[i]);
                    else Console.Write("{0}, ", SelectionSortedArray[i]);
                }

                byte [] BubbleSortedArray = BubbleSort(numsArray);
                Console.Write("\nBubble sorted Array: ");
                for (int i = 0; i < BubbleSortedArray.Length; i++)
                {
                    if (i == BubbleSortedArray.Length - 1) Console.Write("{0}.", BubbleSortedArray[i]);
                    else Console.Write("{0}, ", BubbleSortedArray[i]);
                }
            }
            catch (NullReferenceException exc)
            {
                Console.Write("EXCEPTION! {0}", exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.Write("EXCEPTION! {0}", exc.Message);
            }

            Console.WriteLine("\n\n\n\n");
        }
    }
}
