using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cartesian z1 = new Cartesian(4, 3);
            //Cartesian z2 = new Cartesian(1, 9);
            Polar z1 = new Polar(4, 3);
            Polar z2 = new Polar(1, 9);
            Output(z1 + z2);
        }

        static void Output(IComplex z)
        {
            Console.WriteLine($"z = {z.Re} + {z.Im}i");
            Console.WriteLine($"|z| = {z.Abs}");
            Console.WriteLine($"arg(z) = {Math.Round(z.Arg, 2)}");
        }
    }
}
