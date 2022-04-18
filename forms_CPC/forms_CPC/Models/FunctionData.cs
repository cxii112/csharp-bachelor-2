using System;

namespace forms_CPC.Models
{
    public class FunctionData
    {
        public FunctionData(double x)
        {
            X = x;
            Y = EvaluateFunction(X);
        }

        public double X { get; }
        public double Y { get; }

        private static double EvaluateFunction(double x)
        {
            const double a = 1.35;
            const double b = -6.25;

            return a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
        }
    }
}
