using System;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"box3の表面積={Box.GetSurface(2, 3.5f, 2)}");
            Console.WriteLine($"box3の体積={Box.GetVolume(1, 3.5f, 2)}");           
        }
    }
}
