using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpectralSignalSecondAndThird
{
    public class DftProcessor
    {
        public Complex[] Transform(double[] values, double N, bool inverse)
        {
            return values.Select((_,k) => Transform(k, values, N, inverse)).ToArray();
        }
        public double[] Transform(Complex[] values, double N, bool inverse)
        {
            return values.Select((_, k) => Transform(k, values, N, inverse)).ToArray();
        }
        private Complex Transform(int k, double[] values, double N, bool inverse)
        {
            Complex result = 0;
            N = (double)values.Length;
            for (var n = 0; n < N; n++)
            {
                var omega = 2 * Math.PI * k * n / N  ;
                if (inverse)
                    omega *= (-1);
                result += new Complex(Math.Cos(omega), Math.Sin(omega)) * values[n];
            }
            if (inverse)
                result /= N;
            return result;
        }
        private double Transform(double k, Complex[] values, double N, bool inverse)
        {
            double result = 0;
            N = (double)values.Length;
            for (var n = 0; n < N; n++)
            {
                var omega = -2 * Math.PI * k * n / N;
                
                result += values[n].Real * Math.Cos(omega ) - values[n].Imaginary * Math.Sin(omega);
            }
            return result/N;
        }
        public Complex[] GetComplexInvereFourierTransform(double[] argumentValues, Complex[] fourierTransformValues)
        {
            int m = argumentValues.Length;
            Complex[] resultValues = new Complex[m];
            for (int index = 0; index < argumentValues.Length; index++)
            {
                double argumentValue = argumentValues[index];
                Complex sum = new Complex(0, 0);
                for (int u = 0; u < fourierTransformValues.Length; u++)
                {
                    Complex phase = 2 * Math.PI * u * argumentValue / m;
                    sum += fourierTransformValues[u] * Complex.Pow(Math.E, phase);
                }
                resultValues[index] = sum;
            }
            return resultValues;
        }
    }
    
}
