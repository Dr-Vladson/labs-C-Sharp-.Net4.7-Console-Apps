using System;
namespace Lab3
{
    /* Task 3 (12) Обчислити нескінченну суму 1 / (iterCount * (iterCount + 1)) із заданою точністю ε (ε>0). Вважати,
    що необхідна точність досягнута якщо черговий доданок виявився по модулю
    меншим, ніж ε.Цей і всі наступні доданки можна не враховувати. */
    public class Task3
    {
        public static void Main(String[] args)
        {
            PrintResult(-4);
            PrintResult(-0.0000001);
            PrintResult(0);
            PrintResult(70);
            PrintResult(70);
            PrintResult(0.51);
            PrintResult(0.49);
            PrintResult(0.17);
            PrintResult(0.16);
            PrintResult(0.07);
            PrintResult(0.0001);
            PrintResult(0.00000001);
            PrintResult(0.00000000000001);

            Console.ReadKey();
        }

        public static double FindResult(double e)
        {
            if (e <= 0) throw new ArgumentOutOfRangeException(nameof(e), e, "Invalid value");

            double result = 0;
            bool isntAccuracyReached = true;
            double iterCount = 1;

            while (isntAccuracyReached)
            {   
                double newAddend = 1 / (iterCount * (iterCount + 1));
                if (Math.Abs(newAddend) < e) isntAccuracyReached = false;
                else
                {
                    result += newAddend;
                    iterCount++;
                }
            }

            return result;
        }
        static void PrintResult(double e)
        {
            Console.Write($"e:{e} result:");
            try
            {
                Console.WriteLine(FindResult(e));
            }
            catch (ArgumentOutOfRangeException ecx)
            {
                Console.WriteLine("EXCEPTION! {0}", ecx.Message);
            }
            Console.WriteLine();
        }
    }
}
