using System;
namespace Lab9
{
    // Task 1 (4) Перетворити String, що представляє собою число у шістнадцятковій системі числення, у значення int

    public class Task1
    {
        public static void Main(String[] args)
        {
            PrintResult(null);
            PrintResult("");
            PrintResult("4444\n4");
            PrintResult("444\t44");
            PrintResult("CAF E");
            PrintResult("  CAFE");
            PrintResult("CAFE");
            PrintResult("cAfE");
            PrintResult("0000CAFE");
            PrintResult("CAFE000");
            PrintResult("a5C11");
            PrintResult("56aaff0");
            PrintResult("44444");                  

            Console.ReadKey();
        }

       static int HexCharToInt (char hexChar)
       {
            if (hexChar == '0' || hexChar == '1' || hexChar == '2' || hexChar == '3' || hexChar == '4' || hexChar == '5' || hexChar == '6' || hexChar == '7' || hexChar == '8' || hexChar == '9') return hexChar - '0';
            if (hexChar == 'A' || hexChar == 'a') return 10;
            if (hexChar == 'B' || hexChar == 'b') return 11;
            if (hexChar == 'C' || hexChar == 'c') return 12;
            if (hexChar == 'D' || hexChar == 'd') return 13;
            if (hexChar == 'E' || hexChar == 'e') return 14;
            if (hexChar == 'F' || hexChar == 'f') return 15;
            else return -1;
       }
       static int HexStringToInt(String hexStr) 
        {
            if (hexStr == null) throw new NullReferenceException("Null cannot be proceeded.....");
            if (hexStr.Contains(" ")) throw new ArgumentException("Hex String should not contain spaces.....");
            int hexStrLength = hexStr.Length;
            if (hexStrLength == 0) throw new ArgumentException("Hex String should not be empty.....");
            
            int result = 0;
            for (int i = 0; i < hexStrLength; i++)
            {
                if (HexCharToInt(hexStr[hexStrLength - 1 - i]) == -1) throw new ArgumentException("Hex String should containt only hex digits.....");
                result += Convert.ToInt32(Math.Pow(16, i)) * HexCharToInt(hexStr[hexStrLength - 1 - i]);
            }

            return result;
        }
        static void PrintResult(String hexStr)
        {
            Console.WriteLine("\n");
            if (hexStr == null) Console.WriteLine("Input: null");
            else if (hexStr.Length == 0) Console.WriteLine("Input: empty string");
            else Console.WriteLine("Input: " + hexStr);

            Console.Write("Result: ");
            try
            {
                Console.Write(HexStringToInt(hexStr));
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