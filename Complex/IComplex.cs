using System;

namespace Complex
{
    interface IComplex
    {
        //properties
        double Re { get; set; }
        double Im { get; set; }
        double Abs { get; }
        double Arg { get; }
    }
}