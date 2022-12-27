using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Simulated_Annealing
    {
        private static double getLength(double[,] D, List<int> path) //calculate length of the path and return it
        {
            double length = 0.0;
            for (int i = 0; i < path.Count - 1; i++)
                length += D[path[i], path[i + 1]];
            return length;
        }
        private static bool pathExists(double[,] D, List<int> path) //check if path exists
        {
            for (int i = 0; i < path.Count - 1; i++)
                if (D[path[i], path[i + 1]] == 0)
                    return false;
            return true;
        }
        private static bool pathAvailable(double[,] D, List<int> path) //check if possible to travel from the last city in the path
        {
            for (int i = 0; i < D.GetLength(0); i++)
                if (D[path.Last(), i] != 0 && !path.Exists(x => x == i))
                    return true;
            return false;

        }
        public static void alghorithm(double[,] D, double initT, int maxIter, double alpha, TextBox _T, TextBox _L)
        {
            int n = D.GetLength(0);
            double T = initT;
            List<int> initialGuess = new();
            Random random = new();
            while (initialGuess.Count != n + 1) //make initial guess
            {
                int i;
                if (initialGuess.Count != n)
                {
                    if (initialGuess.Count == 0)
                        i = random.Next(n);
                    else
                    {
                        i = random.Next(n);
                        while (initialGuess.Exists(x => x == i))
                            i = random.Next(n);
                    }
                }
                else
                    i = initialGuess.First();
                if (initialGuess.Count == 0)
                    initialGuess.Add(i);
                else if (D[initialGuess.Last(), i] != 0)
                    initialGuess.Add(i);
                if (initialGuess.Count > 1 && initialGuess.Count < n) 
                {
                    if (!pathAvailable(D, initialGuess))
                        initialGuess = new();
                }
                if (initialGuess.Count == n)
                {
                    var temp = new List<int>(initialGuess);
                    temp.RemoveAt(0);
                    if (!pathAvailable(D, temp))
                        initialGuess = new();
                }
            }
            int count = 0;
            while (count < maxIter) //main cycle
            {
                List<int> updatedPath = new(initialGuess);
                do
                {
                    updatedPath = new(initialGuess);
                    int i = random.Next(n);
                    int j = random.Next(n);
                    while (i == j)
                        j = random.Next(n);
                    var tempi = updatedPath[i];
                    var tempj = updatedPath[j];
                    updatedPath[i] = tempj;
                    updatedPath[j] = tempi;
                    if (i == 0)
                        updatedPath[updatedPath.Count - 1] = tempj;
                    if (j == 0)
                        updatedPath[updatedPath.Count - 1] = tempi;
                }
                while (!pathExists(D, updatedPath)); //swap random cities until path is real
                double oldLength = getLength(D, initialGuess);
                double newLength = getLength(D, updatedPath);
                if (oldLength > newLength) //comparing lengths of old and new paths
                    initialGuess = new(updatedPath); 
                else if (random.NextDouble() < Math.Exp((oldLength - newLength) / T))
                    initialGuess = new(updatedPath);
                T *= alpha; //temperature reduction
                count++;
            }
            _L.Text = getLength(D, initialGuess).ToString();
            _T.Text = "";
            foreach (int city in initialGuess)
            {
                if (city == initialGuess[initialGuess.Count - 2])
                {
                    _T.Text += (city + 1) + "->" + (initialGuess.Last() + 1);
                    break;
                }
                _T.Text += (city + 1) + "->";
            }
        }
    }
}
