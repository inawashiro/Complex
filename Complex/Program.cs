using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex();
            z.Re = 4;
            z.Im = 3;
            Console.WriteLine($"z = {z.Re} + {z.Im}i");
            Console.WriteLine($"|z| = {z.Abs}");
            Console.WriteLine($"arg(z) = {z.Arg}");
        }
    }
}
