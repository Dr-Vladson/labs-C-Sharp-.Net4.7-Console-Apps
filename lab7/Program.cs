using System;
namespace Lab7
{
    public class Program
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
            PrintResult(new byte[] { 8, 2, 11, 12, 45, 44, 5, 23, 11, 1, 4, 100 });

            Console.ReadKey();
        }
        static void PrintResult(byte[] numsArray)
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
                byte[] SelectionSortedArray = new Task(new SelectionSort()).Sort(numsArray);

                Console.Write("\nSelection sorted Array: ");
                for (int i = 0; i < SelectionSortedArray.Length; i++)
                {
                    if (i == SelectionSortedArray.Length - 1) Console.Write("{0}.\n", SelectionSortedArray[i]);
                    else Console.Write("{0}, ", SelectionSortedArray[i]);
                }

                byte[] BubbleSortedArray = new Task(new BubbleSort()).Sort(numsArray);
                Console.Write("\nBubble sorted Array: ");
                for (int i = 0; i < BubbleSortedArray.Length; i++)
                {
                    if (i == BubbleSortedArray.Length - 1) Console.Write("{0}.\n", BubbleSortedArray[i]);
                    else Console.Write("{0}, ", BubbleSortedArray[i]);
                }

                byte[] InsertionSortedArray = new Task(new InsertionSort()).Sort(numsArray);
                Console.Write("\nInsertion sorted Array: ");
                for (int i = 0; i < InsertionSortedArray.Length; i++)
                {
                    if (i == InsertionSortedArray.Length - 1) Console.Write("{0}.", InsertionSortedArray[i]);
                    else Console.Write("{0}, ", InsertionSortedArray[i]);
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

public class Task
{
    private IByteArraySorter _byteArraySorter; 
    public Task (IByteArraySorter byteArraySorter)
    {
        if (byteArraySorter is null) this._byteArraySorter =  new BubbleSort(); 
        else this._byteArraySorter = byteArraySorter;
    }
    public byte [] Sort(byte[] bytesArray)
    {
        return _byteArraySorter.Sort(bytesArray);
    } 
} 
public interface IByteArraySorter
{
    byte[] Sort(byte[] initialNumsArray);
}
class BubbleSort : IByteArraySorter
{
    public byte[] Sort(byte[] initialNumsArray)
    {
        if (initialNumsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
        if (initialNumsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

        byte[] numsArray = new byte[initialNumsArray.Length];
        initialNumsArray.CopyTo(numsArray, 0);

        bool changesOniteration = true;
        int workingLength = numsArray.Length - 1;
        while (changesOniteration && workingLength >= 1)
        {
            //Console.Write("New iteration: ");
            changesOniteration = false;
            for (int i = 0; i < workingLength; i++)
            {
                //Console.Write("compare {0} with {1} - ", numsArray[i], numsArray[i + 1]);
                if (numsArray[i] < numsArray[i + 1])
                {
                    //Console.Write("replace. ");
                    byte currentNum = numsArray[i];
                    numsArray[i] = numsArray[i + 1];
                    numsArray[i + 1] = currentNum;

                    if (!changesOniteration) changesOniteration = true;
                }
                //else Console.Write("dont replace; ");
            }
            //Console.WriteLine();

            workingLength--;
        }

        return numsArray;
    }
}

class SelectionSort : IByteArraySorter
{
    public byte[] Sort(byte[] initialNumsArray)
    {
        if (initialNumsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
        if (initialNumsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

        byte[] numsArray = new byte[initialNumsArray.Length];
        initialNumsArray.CopyTo(numsArray, 0);

        int workingLength = numsArray.Length;
        for (int i = 0; i < numsArray.Length - 1; i++)
        {

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
            //Console.WriteLine("Minimal element {0} will be transported on position {1}.", minNum, workingLength - 1);

            numsArray[minNumIndex] = numsArray[workingLength - 1];
            numsArray[workingLength - 1] = minNum;

            workingLength--;
        }

        return numsArray;
    }
}

class InsertionSort : IByteArraySorter
{
    public byte[] Sort(byte[] initialNumsArray)
    {
        if (initialNumsArray == null) throw new NullReferenceException("Null cannot be proceeded.....");
        if (initialNumsArray.Length == 0) throw new ArgumentException("Array should not be empty.....");

        byte[] numsArray = new byte[initialNumsArray.Length];
        initialNumsArray.CopyTo(numsArray, 0);

        for (int i = 1; i < numsArray.Length; i++)
        {
            byte currentNum = numsArray[i];
            int j = i - 1;

            //Console.Write("{0}. New chosen number: {1}. ", i, currentNum);

            while (j >= 0 && currentNum > numsArray[j])
            {
                //Console.Write("Move number {0} to position {1}; ", numsArray[j], j + 1);
                numsArray[j + 1] = numsArray[j];
                j--;
            }

            //Console.Write("Finally chosen number gets {0} position.\n", j + 1);
            if (j != i - 1) numsArray[j + 1] = currentNum; 
        }

        return numsArray;
    }
}