using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectralSignalSecondAndThird
{
    public class FunctionGenerator
    {
        public double[] Generate(double N, double T, double SamplingFrequency, double SignalFrequency, double A)
        {
            double dt = T / N;
            var result = new List<double>();
            for (double i = 0; i < N; i += dt)
            {
                result.Add(Function(i, SamplingFrequency, SignalFrequency, A));
            }
            return result.ToArray();
        }

        private double Function(double t, double SamplingFrequency, double SignalFrequency, double A)
        {
            A /= 2;
            const double omega = 2 * Math.PI;
            return A*Math.Sin(t * omega / (SamplingFrequency / SignalFrequency)) + A*Math.Sin(t * omega / SamplingFrequency + Math.PI / 2);
        }
    }
}
