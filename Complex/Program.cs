﻿using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartesian z1 = new Cartesian(5, 12);
            Cartesian z2 = new Cartesian(2, 8);
            //Polar z1 = new Polar(5, 12);
            //Polar z2 = new Polar(2, 8);
            z1 *= z2;
            z1 /= z2;
            Output(z1);
        }

        static void Output(IComplex z)
        {
            Console.WriteLine($"z = {z.Re} + {z.Im}i");
            Console.WriteLine($"|z| = {Math.Round(z.Abs, 2)}");
            Console.WriteLine($"arg(z) = {Math.Round(z.Arg, 2)}");
        }
    }
}
