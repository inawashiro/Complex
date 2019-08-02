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

    public class Cartesian : IComplex
    {
        private double re;
        private double im;

        //property
        public double Re
        {
            set { this.re = value; }
            get { return this.re; }
        }

        //property
        public double Im
        {
            set { this.im = value; }
            get { return this.im; }
        }

        //property
        public double Abs
        {
            get { return Math.Sqrt(this.re * this.re + this.im * this.im); } 
        }

        //property
        public double Arg
        {
            get { return Math.Atan2(this.im, this.re); }
        }
    }

    public class Polar : IComplex
    {
        private double abs;
        private double arg;

        //property
        public double Re
        {
            set
            {
                double im = this.abs * Math.Sin(this.arg);
                this.abs = Math.Sqrt(value * value + im * im);
                this.arg = Math.Atan2(im, value);
            }
            get { return this.abs * Math.Cos(this.arg); }
        }

        //property
        public double Im
        {
            set
            {
                double re = this.abs * Math.Cos(this.arg);
                this.abs = Math.Sqrt(re * re + value * value);
                this.arg = Math.Atan2(value, re);
            }
            get { return this.abs * Math.Sin(this.arg); }
        }

        //property
        public double Abs
        {
            set { this.abs = value; }
            get { return this.abs; }
        }

        //property
        public double Arg
        {
            set { this.arg = value; }
            get { return this.arg; }
        }
    }
}