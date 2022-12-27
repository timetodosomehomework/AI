using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentic_Alghorithm
{
    internal class Bee
    {
        public double adaptability;
        public double[] coordinates;
        public Bee(double[] leftBorder, double[] rightBorder)
        {
            Random random = new Random();
            coordinates = new double[leftBorder.Length];
            for (int i = 0; i < leftBorder.Length; i++)
                coordinates[i] = random.NextDouble() * (rightBorder[i] - leftBorder[i]) + leftBorder[i];
        }
    }
}
