using System;


namespace Complex
{
    public class Complex
    {
        private double re;
        private double im;

        public double Re() { return this.re; }

        public void Re(double x) { this.re = x; }

        public double Im() { return this.im; }

        public void Im(double y) { this.im = y; }

        public double Abs()
        {
            var abs = Math.Sqrt(Re() * Re() + Im() * Im());
            return abs;
        }
    }
}
