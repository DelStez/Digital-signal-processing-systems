using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpectralSignalSecondAndThird
{
    public class WindowFunctions
    {
        public double[] SelectTransform(double[] values, double N, int indexWindow, double alpha)
        {
            switch (indexWindow)
            {
                case 1:
                    return values.Select((_, k) => TransformBarlett(k, values, N)).ToArray();
                case 2:
                    return values.Select((_, k) => TransformHann(k, values, N)).ToArray();
                case 3:
                    return values.Select((_, k) => TransformHamming(k, values, N)).ToArray();
                case 4:
                    return values.Select((_, k) => TransformB(k, values, N)).ToArray();
                case 5:
                    return values.Select((_, k) => TransformNattola(k, values, N)).ToArray();
                case 6:
                    return values.Select((_, k) => TransformGaus(k, values, N, alpha)).ToArray();
                case 7:
                    return values.Select((_, k) => TransformKB(k, values, N, alpha)).ToArray();
            }
            return null;
        }
        public double TransformBarlett(int k, double[] values, double N)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
            var omega = 2 * k / N;
            result += (1.0 - Math.Abs(omega - 1.0)) * values[k];
            return result;
        }
        public double TransformHann(int k, double[] values, double N)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
            var omega = 2 * Math.PI * k / N;
            result += (0.5 - 0.5 * Math.Cos(omega)) * values[k];
            return result;
        }
        public double TransformHamming(int k, double[] values, double N)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
            var omega = 2 * Math.PI * k / N;
            result += (0.54 - 0.46 *  Math.Cos(omega)) * values[k];
            return result;
        }
        public double TransformB(int k, double[] values, double N)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
            var omega = 2 * Math.PI * k / N;
            result += ((0.42 - 0.5 * Math.Cos(omega)) + 0.8 * Math.Cos(2.0 * omega)) * values[k];
            return result;
        }
        public double TransformNattola(int k, double[] values, double N)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
                var omega = 2 * Math.PI * k / N;
                result += (0.3635819 - 0.4891775 * Math.Cos(omega) + 0.1365995 
                    * Math.Cos(2*omega) - 0.0106411 * Math.Cos(3*omega)) * values[k];
            return result;
        }
        public double TransformGaus(int k, double[] values, double N, double alpha)
        {
            double result = 0;
            N = (double)values.Length - 1.0;
            var omega = 2 * alpha * k / N;
            result += (Math.Exp(-0.5 * Math.Pow(Math.Abs(omega - alpha), 2))) * values[k];
            return result;
        }
        public double TransformKB(int k, double[] values, double N, double alpha)
        {
            double result = 0;
            N = (double)values.Length;
                var t = Math.Pow((k - N / 2) / (N / 2), 2);
                var g = alpha * Math.PI;
                var r = 1.0 - (t);
                var v = r >= 0 ? Math.Sqrt(Math.Abs(r)) : 0;
                var q = I(g * v);
                q /= I(g);
            result += q * values[k];
            return result;
        }
        private double I(double x)
        {
            double ans;
            double ax = Math.Abs(x);

            if (ax < 3.75)
            {
                double y = x / 3.75f;
                y = y * y;
                ans = 1.0f + y * (3.5156229f + y * (3.0899424f + y * (1.2067492f
                   + y * (0.2659732f + y * (0.360768e-1f + y * 0.45813e-2f)))));
            }
            else
            {
                double y = 3.75f / ax;
                ans = (double)Math.Exp(ax) / (double)Math.Sqrt(ax) * (0.39894228f + y * (0.1328592e-1f
                   + y * (0.225319e-2f + y * (-0.157565e-2f + y * (0.916281e-2f
                   + y * (-0.2057706e-1f + y * (0.2635537e-1f + y * (-0.1647633e-1f
                   + y * 0.392377e-2f))))))));
            }

            return ans;
        }
    }
}
