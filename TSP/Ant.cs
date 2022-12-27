using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Ant
    {
        public List<int> tabu;
        public int start;
        public double length;
        public Ant(int start)
        {
            this.start = start;
            tabu = new List<int>();
        }
    }
}
