using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentic_Alghorithm
{
    internal class Population //class for population
    {
        public Entity[] entities; //array of chromosomes
        public Population(int n, int gens, double leftBorder, double rightBorder) //constructor for real gens representation
        {
            entities = new Entity[n];
            for (int i = 0; i < n; i++)
                entities[i] = new Entity(gens, leftBorder, rightBorder);
        }
        public Population(int n, int gens, int bit, double leftBorder, double rightBorder) //constructor for bit gens representation
        {
            entities = new Entity[n];
            for (int i = 0; i < n; i++)
                entities[i] = new Entity(gens, bit, leftBorder, rightBorder);
        }
    }
}
