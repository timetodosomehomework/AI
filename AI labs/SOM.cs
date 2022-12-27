using AI_labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Networks
{
    internal class SOM
    {
        private const double eps = 0.01; //acceptable difference between current and previous value of specific weight
        private static double[,] initClusters(int n, int amount) //initial cluster (matrix of weights) initializaton with random numbers
        {
            Random random = new Random();
            double[,] clusters = new double[amount, n];
            for (int i = 0; i < amount; i++)
                for (int j = 0; j < n; j++)
                    clusters[i, j] = random.NextDouble();
            return clusters;
        }
        public static void recognize(int N, double learningRate, TextBox iter, TextBox maxIter, double pmin) //recognition alghorithm
        {
            var trainingInput = Form1.initImages(); //training images
            int amountOfClusters = trainingInput.GetLength(0); //amount of clusters
            double[] potential = new double[amountOfClusters]; //potential of the cluster
            for (int i = 0; i < amountOfClusters; i++) //initializing potentials
                potential[i] = pmin;
            var weights = initClusters(N, amountOfClusters); //clusters (matrix of weights)
            var x = Form1.initialize(); //image for recognition
            double[] d = new double[amountOfClusters]; //euclidian distance between input vector and all of the clusters
            int min = 0; //index of cluster with minimum distance
            int iteration = 0; //count iteration
            int epoch = Int32.Parse(maxIter.Text); //max number of iteration
            int[] won = new int[amountOfClusters];
            for (int i = 0; i < amountOfClusters; i++)
                won[i] = 0;
            double[,] prev = new double[amountOfClusters, N]; //keeping track of the weights on previous iteration
            for (int i = 0; i < amountOfClusters; i++)
                for (int j = 0; j < N; j++)
                    prev[i, j] = weights[i, j];
            for (int k = 0; k < trainingInput.GetLength(0); k++) //see if result matches with train images
            {
                bool match = true;
                for (int i = 0; i < N; i++)
                {
                    if (x[i] != trainingInput[k, i])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    float[] temp = new float[N];
                    for (int i = 0; i < N; i++)
                        temp[i] = trainingInput[k, i];
                    Form1.showImage(temp);
                    iteration++;
                    iter.Text = iteration.ToString();
                    return;
                }
            }
            while (iteration < epoch) //train until reach max cnumber of iteration
            {
                Random random = new Random();
                int i = random.Next(amountOfClusters); //choosing random input vector
                for (int j = 0; j < amountOfClusters; j++) //distance is zero
                    d[j] = 0;
                min = -1;
                for (int m = 0; m < amountOfClusters; m++) //for every cluster
                {
                    if (potential[m] < pmin) //if won recently
                        continue;
                    for (int j = 0; j < N; j++) //euclidian distance
                    {
                        d[m] += (weights[m, j] - trainingInput[i, j]) * (weights[m, j] - trainingInput[i, j]);
                    }
                    if (min == -1)
                        min = m;
                    else if (d[m] < d[min])
                        min = m;
                }
                for (int j = 0; j < amountOfClusters; j++) //adjusting potentials
                {
                    if (j == min)
                        potential[j] -= pmin;
                    else
                        potential[j] += 1.0 / amountOfClusters;
                }
                for (int j = 0; j < N; j++) //update min cluster weights
                {
                    prev[min, j] = weights[min, j];
                    weights[min, j] += learningRate * (trainingInput[i, j] - weights[min, j]);
                }
                won[min]++;
                iteration++;
                iter.Text = iteration.ToString();
                bool wflag = true;
                for (int k = 0; k < amountOfClusters; k++)
                    if (won[k] == 0)
                    {
                        wflag = false;
                        break;
                    }
                if (wflag)
                {
                    bool flag = false;
                    for (int k = 0; k < amountOfClusters; k++) //if difference between weights is acceptable
                    {
                        for (int j = 0; j < N; j++)
                            if (Math.Abs(prev[k, j] - weights[k, j]) >= eps)
                            {
                                flag = true;
                                break;
                            }
                        if (flag)
                            break;
                    }
                    if (!flag) //break if weights are good enough
                        break;
                }
                learningRate = learningRate / 2;
            }
            for (int j = 0; j < amountOfClusters; j++)
                d[j] = 0;
            for (int m = 0; m < amountOfClusters; m++) //find minimum euclidian distance for input
            {
                for (int j = 0; j < N; j++)
                {
                    d[m] += (weights[m, j] - x[j]) * (weights[m, j] - x[j]);
                }
                if (m == 0)
                    min = m;
                else if (d[m] < d[min])
                    min = m;
            }
            int image = min;
            for (int j = 0; j < amountOfClusters; j++)
                d[j] = 0;
            for (int m = 0; m < amountOfClusters; m++) //find out what image is closest
            {
                for (int j = 0; j < N; j++)
                {
                    d[m] += (trainingInput[m, j] - weights[image, j]) * (trainingInput[m, j] - weights[image, j]);
                }
                if (m == 0)
                    min = m;
                else if (d[m] < d[min])
                    min = m;
            }
            float[] res = new float[N];
            for (int i = 0; i < N; i++)
                res[i] = trainingInput[min, i];
            Form1.showImage(res); //show restored image
        }
    }
}
