using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    abstract class PixelCoordinates
    {
        protected int x;
        protected int y;

        //public int GetX
        //{
        //    get => x;
        //}
        //public int GetY
        //{
        //    get => y;
        //}

        public abstract new PixelCoordinates Change(int x);
        //public abstract int PrintY();
    }
    class Pixel : PixelCoordinates
    {
        private ConsoleColor pixelColor;
        private int _month = 7;  // Backing store
        public string _name;
        public string Name => _name != null ? _name : "NA";

        public override Pixel Change(int x)
        {
            return new Pixel(x,7,ConsoleColor.Red);
        }
        public int Month
        {
            get => _month;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }
        public Pixel(int x, int y, ConsoleColor pixelColor)
        {
            this.x = x;
            this.y = y;
            this.pixelColor = pixelColor;
        }
        public void PrintPixel()
        {
            Console.ForegroundColor = pixelColor;
            Console.WriteLine("*\n");
            Console.ResetColor();
        }
    }
    class PixelWithColor
    {
        public PixelWithColor()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pixel pixel = new Pixel(4,900,ConsoleColor.DarkRed);
            Pixel pix = pixel.Change(7);
            Console.WriteLine(pixel.ToString());


            Console.ReadKey();
        }
    }
}
