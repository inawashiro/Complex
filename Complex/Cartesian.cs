using System;

namespace Complex
{
    public class Cartesian : IComplex
    {
        private double re;
        private double im;

        //constructor
        public Cartesian(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

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

        public static Cartesian operator +(Cartesian z1, Cartesian z2)
        {
            return new Cartesian(z1.re + z2.re, z1.im + z2.im);
        }

        public static Cartesian operator -(Cartesian z1, Cartesian z2)
        {
            return new Cartesian(z1.re - z2.re, z1.im - z2.im);
        }

        public static Cartesian operator *(Cartesian z1, Cartesian z2)
        {
            return new Cartesian(z1.re * z2.re - z1.im * z2.im,
                                 z1.re * z2.im + z1.im * z2.re);
        }

        public static Cartesian operator /(Cartesian z1, Cartesian z2)
        {
            return new Cartesian((z1.re * z2.re + z1.im * z2.im)
                                 / (z2.re * z2.re + z2.im * z2.im),
                                 (-z1.re * z2.im + z1.im * z2.re)
                                 / (z2.re * z2.re + z2.im * z2.im));
        }
    }
}
