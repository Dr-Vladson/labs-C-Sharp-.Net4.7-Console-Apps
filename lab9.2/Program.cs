using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Lab9
{
    /*Task 2 (7) Об’єкт String представляє собою речення, що містить слова (складаються з літер
    a-z, A-Z), цілі числа (складаються з цифр 0-9), та комбінації літер та цифр.
    Підрахувати кількість слів у реченні.
    */
    public class Task2
    {
        public static void Main(String[] args)
        {
            PrintResult(null);
            PrintResult("");
            PrintResult("ЦThe user with the nickname koala757677 this month left 3 times more comments than the user with the nickname croco181dile181920 4 months ago");
            PrintResult("Кожне завдання має бути реалізовано як окремий клас."); 
            PrintResult("The user with the nickname koala757677 this month left 3 times more comments than the user with the nickname croco181dile181920 4 months ago");
            PrintResult("The user with the nickname koala757677\n this month left 3\t times more comments than the user with the nickname\n croco181dile181920 4 months\t ago");
            PrintResult("  The user with   the nickname       koala757677 this month left 3        times more        comments than the user with the nickname croco181dile181920 4 months ago      ");
            PrintResult("string is an object of type String whose value is text.");

            Console.ReadKey();
        }

        static int WordAmountCounter(String sentence)
        {
            if (sentence == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (sentence.Length == 0) throw new ArgumentException("Sentence should not be empty.....");

            if (Regex.IsMatch(sentence, @"\p{IsCyrillic}+")) throw new ArgumentException("Sentence should not include cyrillic characters.....");

            string[] symbolGroups = sentence.Trim().Split(' ');

            int wordsCount = 0;
            for (int i = 0; i < symbolGroups.Length; i++)
            {
                if (symbolGroups[i] == "") continue;
                if (!(symbolGroups[i].Any(symbol => symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9'))) wordsCount++;
            }

            return wordsCount;
        }
        static void PrintResult(String sentence)
        {
            Console.WriteLine("\n");
            if (sentence == null) Console.WriteLine("Input: null");
            else if (sentence.Length == 0) Console.WriteLine("Input: empty string");
            else Console.WriteLine("Input: " + sentence);

            Console.Write("Result: ");
            try
            {
                Console.Write(WordAmountCounter(sentence));
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine("EXCEPTION! {0}", exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine("EXCEPTION! {0}", exc.Message);
            }
        }
    }
}
