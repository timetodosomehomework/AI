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
        public Entity(int n, double leftBorder, double rightBorder) //constructor for real gen representation
        {
            Random random = new Random();
            gens = new double[n];
            for (int i = 0; i < n; i++)
                gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder; //random value in interval
        }
        public Entity(int n, int bit, double leftBorder, double rightBorder) //constructor for bit gen representation
        {
            Random random = new Random();
            bgens = new BitArray[n];
            gens = new double[n];
            for (int i = 0; i < n; i++)
            {
                double temp = random.NextDouble() * (rightBorder - leftBorder) + leftBorder; //random real value in the interval
                int value = (int)((temp - leftBorder) * (Math.Pow(2, bit) - 1) / (rightBorder - leftBorder)); //corresponding int value
                bgens[i] = new BitArray(new int[] { value }); //corresponding bit value
            }
        }
    }
}
