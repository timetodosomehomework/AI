using AI_labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Networks
{
    internal class Hopfield_network
    {
        private const int n = 5; //matrix size
        private const int N = n * n; //neuron quantity
        static private float[] w = new float[N]; //inputed image
        static private float[,] s; //train images
        static private float[,] weights = new float[N, N]; //matrix of weights
        //static public float[] threshhold = new float[N]; //threshhold
        static public float[] result = new float[N]; //result image
        static public void initialize(List<CheckBox> input) //retrieving data from inputed image
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    CheckBox temp = input.Find(x => x.Name == "w" + i + j);
                    if (temp.Checked == true)
                        w[k] = 1;
                    else
                        w[k] = -1;
                    k++;
                }
            }
        }
        static public void initImages(List<List<CB>> images) //retrieving data from inputed train images
        {
            int k = 0, m;
            s = new float[images.Count, N];
            foreach (List<CB> image in images)
            {
                m = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        CB temp = image.Find(x => x.CBName == "s" + i + j);
                        if (temp.CBCheckStatus == "Checked")
                            s[k, m] = 1;
                        else
                            s[k, m] = -1;
                        m++;
                    }
                }
                k++;
            }
        }
        static private void initMatrixOfWeights() //initialization of matrix of weight and threshholds
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    weights[i, j] = 0;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        weights[i, j] = 0;
                        continue;
                    }
                    for (int k = 0; k < s.GetLength(0); k++)
                    {
                        //weights[i, j] += (2 * s[k, i] - 1) * (2 * s[k, j] - 1);
                        weights[i, j] += s[k, i] * s[k, j];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    weights[i, j] /= N;
                }
            }
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        threshhold[i] += weights[i, j];
            //    }
            //    threshhold[i] /= 2;
            //}
        }
        static public void restoreImage(List<CheckBox> output, TextBox iteration) //restore image alghorithm
        {
            initMatrixOfWeights();
            var input = w;
            bool fail = false; //if nothing is happening for a while
            int count = 0;
            while (!fail)
            {
                for (int i = 0; i < N; i++)
                    result[i] = 0;
                for (int i = 0; i < N; i++) //updating neurons
                {
                    for (int j = 0; j < N; j++)
                    {
                        result[i] += weights[i, j] * input[j];
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (result[i] > /*threshhold[i]*/0)
                        result[i] = 1;
                    else if (result[i] <= /*threshhold[i]*/0)
                        result[i] = -1;
                }
                for (int k = 0; k < s.Rank; k++) //see if result matches with train images
                {
                    bool match = true;
                    for (int i = 0; i < N; i++)
                    {
                        if (result[i] != s[k, i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        showImage(output, k);
                        return;
                    }
                }
                bool flag = true; //see if neurons is stable
                for (int i = 0; i < N; i++)
                    if (input[i] != result[i])
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                {
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            CheckBox temp = output.Find(x => x.Name == "x" + i + j);
                            if (result[k] == 1)
                                temp.CheckState = CheckState.Checked;
                            else
                                temp.CheckState = CheckState.Unchecked;
                            k++;
                        }
                    }
                    return;
                }
                else
                    for (int i = 0; i < N; i++) //updating input image
                        input[i] = result[i];
                count++;
                if (count > 300)
                    fail = true;
                iteration.Text = count.ToString(); //show what iteration is this
            }
            for (int i = 0; i < N; i++)
                result[i] = 0;
            int ind = 0;
            while (true) //nothing happened for a while so trying asyncronous update (mostly the same thing, but one neuron at a time)
            {
                Random random = new Random();
                int nowChoose = random.Next(0, 2);
                int cur = 0;
                if (ind == N)
                    ind = 0;
                if (nowChoose == 0)
                    cur = ind;
                else
                    cur = random.Next(0, N);
                for (int i = 0; i < N; i++)
                    result[cur] += weights[cur, i] * w[i];
                if (result[cur] > 0)
                    result[cur] = 1;
                else
                    result[cur] = -1;
                w[cur] = result[cur];
                for (int k = 0; k < s.Rank; k++)
                {
                    bool match = true;
                    for (int i = 0; i < N; i++)
                    {
                        if (result[i] != s[k, i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        showImage(output, k);
                        return;
                    }
                }
                bool flag = true;
                for (int i = 0; i < N; i++)
                    if (input[i] != result[i])
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                {
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            CheckBox temp = output.Find(x => x.Name == "x" + i + j);
                            if (result[k] == 1)
                                temp.CheckState = CheckState.Checked;
                            else
                                temp.CheckState = CheckState.Unchecked;
                            k++;
                        }
                    }
                    return;
                }
                if (nowChoose == 0)
                    ind++;
                count++;
                iteration.Text = count.ToString();
            }
        }
        static public void showImage(List<CheckBox> input, int num) //show restored image
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    CheckBox temp = input.Find(x => x.Name == "x" + i + j);
                    if (s[num, k] == 1)
                        temp.CheckState = CheckState.Checked;
                    else
                        temp.CheckState = CheckState.Unchecked;
                    k++;
                }
            }
        }
    }
}
