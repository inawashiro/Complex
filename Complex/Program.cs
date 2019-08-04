using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cartesian z = new Cartesian(4, 3);
            Polar z = new Polar(4, 3);
            Output(z);
        }

        static void Output(IComplex z)
        {
            Console.WriteLine($"z = {z.Re} + {z.Im}i");
            Console.WriteLine($"|z| = {z.Abs}");
            Console.WriteLine($"arg(z) = {Math.Round(z.Arg, 2)}");
        }
    }
}
