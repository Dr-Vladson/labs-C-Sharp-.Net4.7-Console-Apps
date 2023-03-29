using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Lab2Task
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public Lab2Task (double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double ExecuteTask6()
        {
            double y = 3 * (Math.Log10(Math.Abs(b / a)) + Math.Sqrt(Math.Sin(c) + Math.Exp(d)));
            return y;
        }
        public double ExecuteTask16()
        {
            double y = 2 * (Math.Sin(a) / Math.Acos(-2 * b)) - Math.Sqrt(Math.Log(c * Math.Abs(2 * d), Math.E));
            return y;
        }
        public double ExecuteTask26()
        {
            double y = Math.Pow(Math.Tan(a), 1/c) / (2 - (Math.Sinh(b) / Math.Log(Math.Abs(d + c), Math.E)));
            return y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Любашенко Владислав ІС-22\nЛабораторна 2\nВаріант 16\nЗавдання 6, 16, 26\n");
            
            Console.WriteLine("Y завдання 6 = " + new Lab2Task(-1.23, -0.34, 0.707, 2.312).ExecuteTask6());
            Console.WriteLine("Y завдання 16 = " +  new Lab2Task(0.58, 0.34, 1.25, -1.89).ExecuteTask16());
            Console.WriteLine("Y завдання 26 = " + new Lab2Task(1.27, 10.99, 4, -25.32).ExecuteTask26());

            Console.ReadKey();
        }
    }
}
