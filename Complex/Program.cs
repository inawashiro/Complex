﻿using System;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = new Complex();
            z.Re(4);
            z.Im(3);
            Console.WriteLine($"|z| = {z.Abs()}");
        }
    }
}
