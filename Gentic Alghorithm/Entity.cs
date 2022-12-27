using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentic_Alghorithm
{
    internal class Entity //entity (chromosome) class
    {
        public double[] gens; //gens for real representation (when in bit representation, contains decoded values)
        public BitArray[] bgens; //gens for bit representation (maximum - 32 bit)
        public double adaptability; //(or fitness) function value for this chromosome
        public Entity(int n, double[] leftBorder, double[] rightBorder) //constructor for real gen representation
        {
            Random random = new Random();
            gens = new double[n];
            for (int i = 0; i < n; i++)
                gens[i] = random.NextDouble() * (rightBorder[i] - leftBorder[i]) + leftBorder[i]; //random value in interval
        }
        public Entity(int n, int[] bit, double[] leftBorder, double[] rightBorder) //constructor for bit gen representation
        {
            Random random = new Random();
            bgens = new BitArray[n];
            gens = new double[n];
            for (int i = 0; i < n; i++)
            {
                double temp = random.NextDouble() * (rightBorder[i] - leftBorder[i]) + leftBorder[i]; //random real value in the interval
                int value = (int)((temp - leftBorder[i]) * (Math.Pow(2, bit[i]) - 1) / (rightBorder[i] - leftBorder[i])); //corresponding int value
                bgens[i] = new BitArray(new int[] { value }); //corresponding bit value
            }
        }
        public Entity(Entity x)
        {
            adaptability = x.adaptability;
            gens = new double[x.gens.Length];
            for (int i = 0; i < x.gens.Length; i++)
                gens[i] = x.gens[i];
            if (x.bgens != null)
            {
                bgens = new BitArray[x.bgens.Length];
                for (int i = 0; i < x.bgens.Length; i++)
                    for (int j = 0; j < x.bgens[0].Length; j++)
                        bgens[i] = new BitArray(x.bgens[i]);
            }
        }
    }
}
