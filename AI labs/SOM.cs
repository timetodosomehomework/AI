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
        const double eps = 0.1; //acceptable difference between current and previous value of specific weight
        private static double[,] initClusters(int n, int amount) //initial cluster (matrix of weights) initializaton with random numbers
        {
            Random random = new Random();
            double[,] clusters = new double[amount, n];
            for (int i = 0; i < amount; i++)
                for (int j = 0; j < n; j++)
                    clusters[i, j] = random.NextDouble();
            return clusters;
        }
        public static void recognize(int N, double learningRate, TextBox iter, TextBox maxIter) //recognition alghorithm
        {
            var trainingInput = Form1.initImages(); //training images
            int amountOfClusters = trainingInput.GetLength(0); //amount of clusters
            var weights = initClusters(N, amountOfClusters); //clusters (matrix of weights)
            var x = Form1.initialize(); //image for recognition
            double[] d = new double[amountOfClusters]; //euclidian distance between input vector and all of the clusters
            int min = 0; //index of cluster with minimum distance
            int iteration = 0; //count iteration
            int check; //count if weights are good enough
            int epoch = Int32.Parse(maxIter.Text); //max number of iteration
            double[,] prev = new double[amountOfClusters, N];
            for (int i = 0; i < amountOfClusters; i++)
                for (int j = 0; j < N; j++)
                    prev[i, j] = weights[i, j];
            while (iteration < epoch) //train until reach max cnumber of iteration
            {
                check = 0;
                for (int i = 0; i < amountOfClusters; i++) //for every vector in training input
                {
                    for (int j = 0; j < amountOfClusters; j++) //distance is zero
                        d[j] = 0;
                    for (int m = 0; m < amountOfClusters; m++) //for every cluster
                    {
                        for (int j = 0; j < N; j++) //euclidian distance
                        {
                            d[m] += (weights[m, j] - trainingInput[i, j]) * (weights[m, j] - trainingInput[i, j]);
                        }
                        if (m == 0)
                            min = m;
                        else if (d[m] < d[min])
                            min = m;
                    }
                    
                    for (int j = 0; j < N; j++) //update min cluster weights
                    {
                        prev[min, j] = weights[min, j];
                        weights[min, j] += learningRate * (trainingInput[i, j] - weights[min, j]);
                    }
                }
                iteration++;
                iter.Text = iteration.ToString();
                bool flag = false;
                for (int i = 0; i < amountOfClusters; i++)
                {
                    for (int j = 0; j < N; j++)
                        if ((Math.Abs(prev[i, j] - weights[i, j]) >= eps) || (prev[i, j] - weights[i, j]) == 0) 
                        {
                            flag = true;
                            break;
                        }
                    if (flag)
                        break;
                }
                if (!flag) //break if weights are good enough
                   break;
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
