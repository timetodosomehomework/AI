using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    internal class Ant_Alghorithm
    {
        private double[,] D;
        private double alpha;
        private double beta;
        private int elite;
        private double Q;
        private double[,] tau;
        private double[,] eta;
        private int amountOfAnts;
        private double p;
        private struct City
        {
            public int i;
            public double weight;
        }
        public Ant_Alghorithm(double[,] D, double alpha, double beta, int elite, double Q, int amountOfAnts, double p)
        {
            this.D = D;
            this.alpha = alpha;
            this.beta = beta;
            this.elite = elite;
            this.Q = Q;
            this.amountOfAnts = amountOfAnts;
            int n = D.GetLength(0);
            tau = new double[n, n];
            eta = new double[n, n];
            double tau0 = p;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        eta[i, j] = 1.0 / D[i, j];
                        tau[i, j] = tau0;
                    }
                    else
                        tau[i, j] = 0.0;
                }

            this.p = p;
        }
        public void algorithm(int maxIter, TextBox _T, TextBox _L)
        {
            Ant[] ants = new Ant[amountOfAnts];
            List<int> T = new List<int>();
            double L = 0.0;
            for (int i = 0, j = 0; i < D.GetLength(0); i++, j++) //put ants in starting cities
            {
                if (j == amountOfAnts)
                    j = 0;
                ants[i] = new Ant(j);
            }
            int count = 0;
            while (count < maxIter)
            {
                int i = 0;
                while (i < amountOfAnts) //for every ant
                {
                    ants[i].tabu.Clear();
                    ants[i].tabu.Add(ants[i].start);
                    ants[i].length = 0.0;
                    while (ants[i].tabu.Count != D.GetLength(0)) //while not all cities are visited
                    {
                        List<City> available = new();
                        double sumw = 0.0;
                        for (int j = 0; j < D.GetLength(0); j++) //find available cities to travel to
                            if (!ants[i].tabu.Exists(x => x == j) && D[ants[i].tabu.Last(), j] != 0)
                            {
                                City temp = new()
                                {
                                    i = j,
                                    weight = Math.Pow(tau[ants[i].tabu.Last(), j], alpha) * Math.Pow(eta[ants[i].tabu.Last(), j], beta)
                                };
                                sumw += temp.weight;
                                available.Add(temp);
                            }
                        Random random = new();
                        double x = random.NextDouble() * sumw;
                        sumw = 0.0;
                        foreach (City city in available) //random roullete city selection
                        {
                            sumw += city.weight;
                            if (x < sumw)
                            {
                                ants[i].length += D[ants[i].tabu.Last(), city.i];
                                ants[i].tabu.Add(city.i);
                                break;
                            }
                        }
                        if (available.Count == 0) //if there is no available cities
                            break;
                    }
                    if (D[ants[i].tabu.Last(), ants[i].start] != 0) //if its a cicle
                    {
                        ants[i].length += D[ants[i].tabu.Last(), ants[i].start];
                        ants[i].tabu.Add(ants[i].start);
                    }
                    i++;
                }
                List<Ant> l = new List<Ant>();
                for (int j = 0; j < amountOfAnts; j++) //add ants that are accurately completed their path
                    if (ants[j].tabu.Count == D.GetLength(0) + 1 && ants[j].tabu.First() == ants[j].tabu.Last()) 
                        l.Add(ants[j]);
                if (l.Count != 0)
                {
                    l.Sort((x1, x2) => x1.length.CompareTo(x2.length)); //ascending sort
                    if (count == 0) //update shortest path
                    {
                        T = new List<int>(l.First().tabu);
                        L = l.First().length;
                    }
                    else if (L > l.First().length)
                    {
                        T = new List<int>(l.First().tabu);
                        L = l.First().length;
                    }
                    double[,] dTau = new double[D.GetLength(0), D.GetLength(0)];
                    for (int j = 0; j < D.GetLength(0); j++)
                        for (int k = 0; k < D.GetLength(0); k++)
                            dTau[j, k] = 0.0;
                    for (int j = 0; j < D.GetLength(0); j++) //updating pheromones
                        for (int k = 0; k < D.GetLength(0); k++)
                        {
                            if (j == k)
                                continue;
                            for (int m = 0; m < amountOfAnts; m++)
                            {
                                if (ants[m].tabu.Count != D.GetLength(0) + 1 && ants[m].tabu.First() != ants[m].tabu.Last())
                                    continue;
                                if (ants[m].tabu[ants[m].tabu.Count - 2] == j && ants[m].start == k)
                                {
                                    if (ants[m].tabu.Equals(l[0].tabu))
                                        dTau[j, k] += elite * Q / ants[m].length;
                                    dTau[j, k] += Q / ants[m].length;
                                }
                                else if (ants[m].tabu.Exists(x => x == j))
                                    if (ants[m].tabu[ants[m].tabu.FindIndex(x => x == j) + 1] == k)
                                    {
                                        if (ants[m].tabu.Equals(l[0].tabu))
                                            dTau[j, k] += elite * Q / ants[m].length;
                                        dTau[j, k] += Q / ants[m].length;
                                    }
                            }
                        }
                    for (int j = 0; j < D.GetLength(0); j++)
                        for (int k = 0; k < D.GetLength(0); k++)
                            tau[j, k] = (1 - p) * tau[j, k] + dTau[j, k];
                }
                count++;
            }
            if (T.Count != 0)
            {
                _L.Text = L.ToString();
                _T.Text = "";
                foreach (int city in T)
                {
                    if (city == T[T.Count - 2])
                    {
                        _T.Text += (city + 1) + "->" + (T.Last() + 1);
                        break;
                    }
                    _T.Text += (city + 1) + "->";
                }
            }
        }
    }
}
