using System;

namespace Complex
{
    public class Complex
    {
        //private double re;
        //private double im;

        //public double Re() { return this.re; }

        //public void Re(double x) { this.re = x; }

        //public double Im() { return this.im; }

        //public void Im(double y) { this.im = y; }

        //public double Abs()
        //{
        //    double abs = Math.Sqrt(Re() * Re() + Im() * Im());
        //    //double abs = Math.Sqrt(this.re * this.re + this.im * this.im);
        //    return abs;
        //}

        //public double Arg()
        //{
        //    double arg = Math.Atan2(Im(), Re());
        //    //double arg = Math.Atan2(this.im, this.re);
        //    return arg;
        //}


        private double abs;
        private double arg;

        public double Re() { return this.abs * Math.Cos(this.arg); }

        public void Re(double x)
        {
            //double im = this.abs * Math.Sin(this.arg);
            double im = Abs() * Math.Sin(Arg());
            this.abs = Math.Sqrt(x * x + im * im);
            this.arg = Math.Atan2(im, x);
        }

        public double Im() { return this.abs * Math.Sin(this.arg); }

        public void Im(double y)
        {
            //double re = this.abs * Math.Cos(this.arg);
            double re = Abs() * Math.Cos(Arg());
            this.abs = Math.Sqrt(re * re + y * y);
            this.arg = Math.Atan2(y, re);
        }

        public double Abs() { return this.abs; }

        public double Arg() { return this.arg; }
    }
}
