using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemperature
{
    internal class Average
    {
        public void PrintAverage(double[] temperatures)
        {
            // TODO
            double sum = CalculateAverage(temperatures);
            Console.WriteLine("The average temperature is: " + sum);
        }

        public double CalculateAverage(double[] temperatures)
        {
            // TODO
            double sum = 0.0;
            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i];
            }
            return sum / temperatures.Length;
        }
    }
}
