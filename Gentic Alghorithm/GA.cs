using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser; //for function parsing

namespace Gentic_Alghorithm
{
    internal class GA
    {
        private int numberOfArguments; //number of arguments in the function
        private int populationCapacity; //how many chromosomes in population
        private string expression; //function
        private int[] bit; //how many bits is needed to code values with given precision
        //private double l; //cutoff threshhold for truncation selection
        private int t; //size of the tournament for tournament selection
        private double T; //population gap
        private double P; //probability of crossbreeding
        private double lambda; //lambda for ariphmetic crossingover
        private double alpha; //aplha for BLX-a crossingover
        private char selection; //what selection was chosen
        private char CO; //what type of crossbreeding was chosen
        private double Pm; //probability of mutation
        private double eps; //mutation value (-eps;eps)
        private double[] leftBorder; //left border of the interval
        private double[] rightBorder; //right border of the interval
        private bool bitsOrNo; //what representation
        private double P0; //probability for uniform crossingover
        private TextBox func;
        private int iter = 0;
        public GA(string expression, bool bitsOrNo, double P0, int populationCapacity, /*double l,*/ int t, double T, double P, double lambda, double alpha, char selection, char CO, double Pm, double eps, double[] leftBorder, double[] rightBorder, TextBox func, double precision = 0) 
        {
            int max = 0;
            for (int i = 0; i < expression.Length; i++) //find out how many arguments in function
                if (expression[i] == 'x')
                    if (Int32.Parse(expression[i + 1].ToString()) > max)
                        max = Int32.Parse(expression[i + 1].ToString());
            numberOfArguments = max;
            this.bitsOrNo = bitsOrNo;
            this.populationCapacity = populationCapacity;
            this.expression = expression;
            this.T = T;
            this.P = P;
            this.lambda = lambda;
            this.alpha = alpha;
            this.selection = selection;
            this.CO = CO;
            this.Pm = Pm;
            this.eps = eps;
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            //this.l = l;
            this.t = t;
            this.P0 = P0;
            this.func = func;
            bit = new int[numberOfArguments];
            if (precision != 0)
            {
                for (int i = 0; i < numberOfArguments; i++)
                {
                    double temp;
                    if (rightBorder[i] + leftBorder[i] >= rightBorder[i])
                        temp = (rightBorder[i] - leftBorder[i]) / precision - 2;
                    else
                        temp = (rightBorder[i] - leftBorder[i]) / precision - 1;
                    bit[i] = (int)Math.Log2(temp);
                }
            }
        }
        private double toDouble(BitArray x, int i) //decode bit gen to corresponding real value
        {
            int[] dec = new int[1];
            x.CopyTo(dec, 0);
            return dec[0] * (rightBorder[i] - leftBorder[i]) / (Math.Pow(2, bit[i]) - 1) + leftBorder[i];
        }
        private BitArray toBit(double x, int i) //code real value to corresponding bit value
        {
            int dec = (int)((x - leftBorder[i]) * (Math.Pow(2, bit[i]) - 1) / (rightBorder[i] - leftBorder[i]));
            return new BitArray(new int[] { dec });
        }
        private double calculate(double[] x) //calculate value of the function
        {
            double result;
            Argument[] arguments = new Argument[x.Length];
            for (int i = 0; i < x.Length; i++)
                arguments[i] = new Argument("x" + (i + 1), x[i]);
            Expression e = new Expression(expression, arguments);
            result = e.calculate();
            iter++;
            func.Text = iter.ToString();
            return result;
        }
        private void evaluate(Population population) //calculate value of the function for every chromosome
        {
            if (bitsOrNo)
                for (int i = 0; i < population.entities.Length; i++)
                {
                    for (int j = 0; j < numberOfArguments; j++)
                    {
                        population.entities[i].gens[j] = toDouble(population.entities[i].bgens[j], j);
                    }
                    population.entities[i].adaptability = calculate(population.entities[i].gens);
                }
            else
                for (int i = 0; i < population.entities.Length; i++)
                    population.entities[i].adaptability = calculate(population.entities[i].gens);
        }
        //private Entity[] roulletteSelection(Population population) //roulette selection, but it doesn't work for minimization bc P can be negative and zero
        //{
        //    List<Entity> entities = new List<Entity>();
        //    Random random = new Random();
        //    double sumOfADP = 0;
        //    for (int i = 0; i < population.entities.Length; i++)
        //        sumOfADP += population.entities[i].adaptability;
        //    for (int j = 0; j < populationCapacity;) 
        //    {
        //        for (int i = 0; i < population.entities.Length; i++)
        //        {
        //            double probability = population.entities[i].adaptability / sumOfADP;
        //            if (probability > random.NextDouble())
        //            {
        //                entities.Add(population.entities[i]);
        //                j++;
        //                break;
        //            }
        //        }
        //    }
        //    return entities.ToArray();
        //}
        //private Entity[] truncationSelection(Population population, double l) //truncation selection
        //{
        //    List<Entity> entities = population.entities.ToList();
        //    int n = (int)(population.entities.Length * l);
        //    entities.Sort((x1, x2) => x1.adaptability.CompareTo(x2.adaptability));
        //    entities.RemoveRange(n, entities.Count - n);
        //    return entities.ToArray();
        //}
        private Entity[] tournamentSelection(Population population, int t) //tournament selection
        {
            Random random = new Random();
            Entity[] entities = new Entity[populationCapacity];
            Entity min;
            if (bitsOrNo)
                min = new Entity(numberOfArguments, bit, leftBorder, rightBorder);
            else
                min = new Entity(numberOfArguments, leftBorder, rightBorder);
            for (int k = 0; k < populationCapacity; k++)
            {
                for (int i = 0; i < t; i++)
                {
                    int j = (int)(random.NextDouble() * populationCapacity);
                    if (i == 0)
                        min = new Entity(population.entities[j]);
                    else if (min.adaptability > population.entities[j].adaptability)
                        min = new Entity(population.entities[j]);
                }
                entities[k] = new Entity(min);
            }
            return entities;
        }
        private Entity[] onePointCrossingOver(Entity[] parents) //one-point crossingover
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[parents.Length];
            for (int k = 0; k < offsprings.Length; k++) 
                offsprings[k] = new Entity(parents[k]);
            int i = random.Next(numberOfArguments);
            int j = random.Next(bit[i]);
            for (; i < numberOfArguments; i++) 
                for (; j < bit[i]; j++)
                {
                    offsprings[0].bgens[i][j] = parents[1].bgens[i][j];
                    offsprings[1].bgens[i][j] = parents[0].bgens[i][j];
                }
            return offsprings;
        }
        private Entity[] twoPointCrossingOverBit(Entity[] parents) //two-point crossingover for bit representation
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[parents.Length];
            for (int ind = 0; ind < offsprings.Length; ind++)
                offsprings[ind] = new Entity(parents[ind]);
            int i = random.Next(numberOfArguments);
            int j = random.Next(bit[i]);
            int k = random.Next(numberOfArguments);
            int m = random.Next(bit[k]);
            while (i == k && j == m)
            {
                k = random.Next(numberOfArguments);
                m = random.Next(bit[k]);
            }
            int max = i < k ? k : i;
            int min = i > k ? k : i;
            i = min;
            k = max;
            int n = bit[i];
            for (; i < k + 1; i++)
            {
                if (i == k)
                    n = m;
                for (; j < n; j++)
                {
                    offsprings[0].bgens[i][j] = parents[1].bgens[i][j];
                    offsprings[1].bgens[i][j] = parents[0].bgens[i][j];
                }
            }
            return offsprings;
        }
        private Entity[] uniformCrossingOver(Entity[] parents) //uniform crossingover
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[parents.Length];
            for (int k = 0; k < offsprings.Length; k++)
                offsprings[k] = new Entity(parents[k]);
            for (int i = 0; i < numberOfArguments; i++)
                for (int j = 0; j < bit[i]; j++)
                {
                    if (P0 > random.NextDouble())
                    {
                        offsprings[0].bgens[i][j] = parents[1].bgens[i][j];
                        offsprings[1].bgens[i][j] = parents[0].bgens[i][j];
                    }
                }
            return offsprings;
        }
        private Entity[] twoPointCrossingOver(Entity[] parents) //two-point crossingover for real representation
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[parents.Length];
            for (int k = 0; k < offsprings.Length; k++)
                offsprings[k] = new Entity(parents[k]);
            int i = random.Next(numberOfArguments);
            int j = i;
            while (j == i) 
                j = random.Next(numberOfArguments);
            for (int k = i > j ? j : i; k < (i > j ? i : j); k++)
            {
                offsprings[0].gens[k] = parents[1].gens[k];
                offsprings[1].gens[k] = parents[0].gens[k];
            }
            return offsprings;
        }
        private Entity[] ariphmeticCrossingOver(Entity[] parents) //ariphmetic crossingover
        {
            Entity[] offsprings = new Entity[parents.Length];
            for (int k = 0; k < offsprings.Length; k++)
                offsprings[k] = new Entity(parents[k]);
            for (int i = 0; i < parents[0].gens.Length; i++)
            {
                offsprings[0].gens[i] = lambda * parents[0].gens[i] + (1 - lambda) * parents[1].gens[i];
                offsprings[1].gens[i] = lambda * parents[1].gens[i] + (1 - lambda) * parents[0].gens[i];
            }
            return offsprings;
        }
        private Entity[] BLXcrossingOver(Entity[] parents) //BLX-a crossingover
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[parents.Length];
            for (int k = 0; k < offsprings.Length; k++)
                offsprings[k] = new Entity(parents[k]);
            for (int i = 0; i < parents[0].gens.Length; i++)
            {
                double min = parents[0].gens[i] < parents[1].gens[i] ? parents[0].gens[i] : parents[1].gens[i];
                double max = parents[0].gens[i] > parents[1].gens[i] ? parents[0].gens[i] : parents[1].gens[i];
                double delta = max - min;
                double leftBorder = min - alpha * delta;
                double rightBorder = max + alpha * delta;
                offsprings[0].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                while (offsprings[0].gens[i] <= this.leftBorder[i] || offsprings[0].gens[i] >= this.rightBorder[i])
                    offsprings[0].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                offsprings[1].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                while (offsprings[1].gens[i] <= this.leftBorder[i] || offsprings[1].gens[i] >= this.rightBorder[i])
                    offsprings[1].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
            }
            return offsprings;
        }
        private Entity[] crossBreeding(Population population) //crossbreeding
        {
            Random random = new Random();
            Entity[] offsprings = new Entity[populationCapacity];
            int n = (int)(populationCapacity * T); //how many offsprings in the next generation
            evaluate(population);
            Entity[] parents = new Entity[populationCapacity];
            switch (selection)
            {
                //case 'r':
                //    parents = roulletteSelection(population);
                //    break;
                //case 't':
                //    parents = truncationSelection(population, l);
                //    break;
                case 'T':
                    var tempo = tournamentSelection(population, t);
                    for (int i = 0; i < populationCapacity; i++)
                        parents[i] = new Entity(tempo[i]);
                    break;
                default:
                    tempo = tournamentSelection(population, t);
                    for (int i = 0; i < populationCapacity; i++)
                        parents[i] = new Entity(tempo[i]);
                    break;
            }
            for (int k = 0; k < n; k += 2) 
            {
                int i = random.Next(parents.Length);
                int j = i;
                while (j == i)
                    j = random.Next(parents.Length);
                Entity[] tparents = new Entity[2];
                tparents[0] = new Entity(parents[i]);
                tparents[1] = new Entity(parents[j]);
                Entity[] toffsprings = new Entity[2];
                if (P > random.NextDouble())
                    switch (CO)
                    {
                        case 'a':
                            var tem = ariphmeticCrossingOver(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        case '2':
                            tem = twoPointCrossingOver(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        case 'b':
                            tem = BLXcrossingOver(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        case '1':
                            tem = onePointCrossingOver(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        case 't':
                            tem = twoPointCrossingOverBit(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        case 'u':
                            tem = uniformCrossingOver(tparents);
                            for (i = 0; i < tparents.Length; i++)
                                toffsprings[i] = new Entity(tem[i]);
                            break;
                        default:
                            if (bitsOrNo)
                            {
                                tem = twoPointCrossingOverBit(tparents);
                                for (i = 0; i < tparents.Length; i++)
                                    toffsprings[i] = new Entity(tem[i]);
                            }
                            else
                            {
                                tem = twoPointCrossingOver(tparents);
                                for (i = 0; i < tparents.Length; i++)
                                    toffsprings[i] = new Entity(tem[i]);
                            }
                            break;
                    }
                else
                {
                    for (i = 0; i < tparents.Length; i++)
                        toffsprings[i] = new Entity(tparents[i]);
                }
                if (k + 1 != n)
                {
                    offsprings[k] = new Entity(toffsprings[0]);
                    offsprings[k + 1] = new Entity(toffsprings[1]);
                }
                else if (random.NextDouble() > 0.49)
                    offsprings[k] = new Entity(toffsprings[0]);
                else
                    offsprings[k] = new Entity(toffsprings[1]);
            }
            List<Entity> lparents = parents.ToList();
            lparents.Sort((x1, x2) => x1.adaptability.CompareTo(x2.adaptability));
            var temp = lparents.ToArray();
            for (int i = 0; i < parents.Length; i++)
                parents[i] = new Entity(temp[i]);
            for (int i = n, j = 0; i < populationCapacity; i++, j++) //most fit parents added to the next population
                offsprings[i] = new Entity(parents[j]);
            return offsprings;
        }
        private Entity[] mutation(Population population) //mutation
        {
            Random random = new Random();
            Entity[] entities = new Entity[populationCapacity];
            Entity[] temp = crossBreeding(population);
            for (int i = 0; i < entities.Length; i++)
                entities[i] = new Entity(temp[i]);
            for (int i = 0; i < populationCapacity; i++)
                for (int j = 0; j < numberOfArguments; j++)
                {
                    if (bitsOrNo)
                        for (int k = 0; k < bit[j]; k++)
                        {
                            if (Pm > random.NextDouble())
                                entities[i].bgens[j][k] = !entities[i].bgens[j][k];
                        }
                    else if (Pm > random.NextDouble())
                    {
                        double tem = entities[i].gens[j] + random.NextDouble() * 2 * eps - eps;
                        while (entities[i].gens[j] + tem <= leftBorder[j] || entities[i].gens[j] + tem >= rightBorder[j])
                            tem = random.NextDouble() * 2 * eps - eps;
                        entities[i].gens[j] += tem;
                    }
                }
            return entities;
        }
        public void Alghorithm(int n, TextBox y, ListView listView) //genetic alghorithm
        {
            Population population;
            if (bitsOrNo)
                population = new Population(populationCapacity, numberOfArguments, bit, leftBorder, rightBorder);
            else
                population = new Population(populationCapacity, numberOfArguments, leftBorder, rightBorder);
            for (int i = 0; i < n; i++) //do ga until n generation
            {  
                var tem = mutation(population);
                for (int j = 0; j < population.entities.Length; j++)
                    population.entities[j] = new Entity(tem[j]);
            }
            evaluate(population);
            double min_func = population.entities.Min(x => x.adaptability);
            Entity temp;
            if (bitsOrNo)
                temp = new Entity(numberOfArguments, bit, leftBorder, rightBorder);
            else
                temp = new Entity(numberOfArguments, leftBorder, rightBorder);
            temp = new Entity(population.entities.ToList().Find(x => x.adaptability == min_func));
            double[] xs;
            xs = temp.gens;
            y.Text = min_func.ToString();
            listView.Items.Clear();
            for (int i = 0; i < xs.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem("x" + (i + 1));
                listViewItem.SubItems.Add(xs[i].ToString());
                listView.Items.Add(listViewItem);
            }
        }
    }
}
