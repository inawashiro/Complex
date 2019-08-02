using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartesian z = new Cartesian();
            //Polar z = new Polar();
            z.Re = 4;
            z.Im = 3;
            Output(z);
        }

        static void Output(IComplex z)
        {
            Console.WriteLine($"z = {z.Re} + {z.Im}i");
            Console.WriteLine($"|z| = {z.Abs}");
            Console.WriteLine($"arg(z) = {z.Arg}");
        }
    }
}
