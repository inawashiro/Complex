using System;

namespace Complex
{
    interface IComplex
    {
        //properties
        double Re { get; }
        double Im { get; }
        double Abs { get; }
        double Arg { get; }
    }
}