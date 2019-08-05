using System;

namespace Complex
{
    public class Polar : IComplex
    {
        private double abs;
        private double arg;

        //constructor
        public Polar(double re, double im)
        {
            this.abs = Math.Sqrt(re * re + im * im);
            this.arg = Math.Atan2(im, re);
        }

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

        public static Polar operator +(Polar z1, Polar z2)
        {
            return new Polar(z1.abs * Math.Cos(z1.arg)
                             + z2.abs * Math.Cos(z2.arg),
                             z1.abs * Math.Sin(z1.arg)
                             + z2.abs * Math.Sin(z2.arg));
        }

        public static Polar operator -(Polar z1, Polar z2)
        {
            return new Polar(z1.abs * Math.Cos(z1.arg)
                             - z2.abs * Math.Cos(z2.arg),
                             z1.abs * Math.Sin(z1.arg)
                             - z2.abs * Math.Sin(z2.arg));
        }

        public static Polar operator *(Polar z1, Polar z2)
        {
            return new Polar(z1.abs * z2.abs * Math.Cos(z1.arg + z2.arg),
                             z1.abs * z2.abs * Math.Sin(z1.arg + z2.arg));
        }

        public static Polar operator /(Polar z1, Polar z2)
        {
            return new Polar(z1.abs / z2.abs * Math.Cos(z1.arg - z2.arg),
                             z1.abs / z2.abs * Math.Sin(z1.arg - z2.arg));
        }
    }
}
