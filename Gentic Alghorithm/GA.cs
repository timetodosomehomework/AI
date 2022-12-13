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
        private int bit; //how many bits is needed to code values with given precision
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
        private double leftBorder; //left border of the interval
        private double rightBorder; //right border of the interval
        private bool bitsOrNo; //what representation
        private double P0; //probability for uniform crossingover
        public GA(string expression, bool bitsOrNo, double P0, int populationCapacity, /*double l,*/ int t, double T, double P, double lambda, double alpha, char selection, char CO, double Pm, double eps, double leftBorder, double rightBorder, double precision = 0) 
        {
            int max = 0;
            for (int i = 0; i < expression.Length; i++) //find out how many arguments in function
                if (expression[i] == 'x')
                    if (Int32.Parse(expression[i + 1].ToString()) > max)
                        max++;
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
            if (precision != 0)
            {
                double temp;
                if (rightBorder + leftBorder >= rightBorder)
                    temp = (rightBorder - leftBorder) / precision - 2;
                else
                    temp = (rightBorder - leftBorder) / precision - 1;
                bit = (int)Math.Log2(temp);
            }
        }
        private double toDouble(BitArray x) //decode bit gen to corresponding real value
        {
            int[] dec = new int[1];
            x.CopyTo(dec, 0);
            return dec[0] * (rightBorder - leftBorder) / (Math.Pow(2, bit) - 1) + leftBorder;
        }
        private BitArray toBit(double x) //code real value to corresponding bit value
        {
            int dec = (int)((x - leftBorder) * (Math.Pow(2, bit) - 1) / (rightBorder - leftBorder));
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
            return result;
        }
        private void evaluate(Population population) //calculate value of the function for every chromosome
        {
            if (bitsOrNo)
                for (int i = 0; i < population.entities.Length; i++)
                {
                    for (int j = 0; j < numberOfArguments; j++)
                    {
                        population.entities[i].gens[j] = toDouble(population.entities[i].bgens[j]);
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
                        min = population.entities[j];
                    else if (min.adaptability > population.entities[j].adaptability)
                        min = population.entities[j];
                }
                entities[k] = min;
            }
            return entities;
        }
        private Entity[] onePointCrossingOver(Entity[] parents) //one-point crossingover
        {
            Random random = new Random();
            Entity[] offsprings = parents;
            int i = random.Next(numberOfArguments);
            int j = random.Next(bit);
            for (; i < numberOfArguments; i++) 
                for (; j < bit; j++)
                {
                    offsprings[0].bgens[i][j] = parents[1].bgens[i][j];
                    offsprings[1].bgens[i][j] = parents[0].bgens[i][j];
                }
            return offsprings;
        }
        private Entity[] twoPointCrossingOverBit(Entity[] parents) //two-point crossingover for bit representation
        {
            Random random = new Random();
            Entity[] offsprings = parents;
            int i = random.Next(numberOfArguments);
            int j = random.Next(bit);
            int k = random.Next(numberOfArguments);
            int m = random.Next(bit);
            while (i == k && j == m)
            {
                k = random.Next(numberOfArguments);
                m = random.Next(bit);
            }
            int n = bit;
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
            Entity[] offsprings = parents;
            for (int i = 0; i < numberOfArguments; i++)
                for (int j = 0; j < bit; j++)
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
            Entity[] offsprings = parents;
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
            Entity[] offsprings = parents;
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
            Entity[] offsprings = parents;
            for (int i = 0; i < parents[0].gens.Length; i++)
            {
                double min = parents[0].gens[i] < parents[1].gens[i] ? parents[0].gens[i] : parents[1].gens[i];
                double max = parents[0].gens[i] > parents[1].gens[i] ? parents[0].gens[i] : parents[1].gens[i];
                double delta = max - min;
                double leftBorder = min - alpha * delta;
                double rightBorder = max + alpha * delta;
                offsprings[0].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                while (offsprings[0].gens[i] <= this.leftBorder || offsprings[0].gens[i] >= this.rightBorder)
                    offsprings[0].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                offsprings[1].gens[i] = random.NextDouble() * (rightBorder - leftBorder) + leftBorder;
                while (offsprings[1].gens[i] <= this.leftBorder || offsprings[1].gens[i] >= this.rightBorder)
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
            Entity[] parents;
            switch (selection)
            {
                //case 'r':
                //    parents = roulletteSelection(population);
                //    break;
                //case 't':
                //    parents = truncationSelection(population, l);
                //    break;
                case 'T':
                    parents = tournamentSelection(population, t);
                    break;
                default:
                    parents = tournamentSelection(population, t);
                    break;
            }
            for (int k = 0; k < n; k += 2) 
            {
                int i = random.Next(parents.Length);
                int j = i;
                while (j == i)
                    j = random.Next(parents.Length);
                Entity[] tparents = new Entity[2];
                tparents[0] = parents[i];
                tparents[1] = parents[j];
                Entity[] toffsprings;
                if (P > random.NextDouble())
                    switch (CO)
                    {
                        case 'a':
                            toffsprings = ariphmeticCrossingOver(tparents);
                            break;
                        case '2':
                            toffsprings = twoPointCrossingOver(tparents);
                            break;
                        case 'b':
                            toffsprings = BLXcrossingOver(tparents);
                            break;
                        case '1':
                            toffsprings = onePointCrossingOver(tparents);
                            break;
                        case 't':
                            toffsprings = twoPointCrossingOverBit(tparents);
                            break;
                        case 'u':
                            toffsprings = uniformCrossingOver(tparents);
                            break;
                        default:
                            if (bitsOrNo)
                                toffsprings = twoPointCrossingOverBit(tparents);
                            else
                                toffsprings = twoPointCrossingOver(tparents);
                            break;
                    }
                else
                    toffsprings = tparents;
                if (k + 1 != n)
                {
                    offsprings[k] = toffsprings[0];
                    offsprings[k + 1] = toffsprings[1];
                }
                else if (random.NextDouble() > 0.49)
                    offsprings[k] = toffsprings[0];
                else
                    offsprings[k] = toffsprings[1];
            }
            List<Entity> lparents = parents.ToList();
            lparents.Sort((x1, x2) => x1.adaptability.CompareTo(x2.adaptability));
            parents = lparents.ToArray();
            for (int i = n, j = 0; i < populationCapacity; i++, j++) //most fit parents added to the next population
                offsprings[i] = parents[j];
            return offsprings;
        }
        private Entity[] mutation(Population population) //mutation
        {
            Random random = new Random();
            Entity[] entities = crossBreeding(population);
            for (int i = 0; i < populationCapacity; i++)
                for (int j = 0; j < numberOfArguments; j++)
                {
                    if (bitsOrNo)
                        for (int k = 0; k < bit; k++)
                        {
                            if (Pm > random.NextDouble())
                                entities[i].bgens[j][k] = !entities[i].bgens[j][k];
                        }
                    else if (Pm > random.NextDouble())
                    {
                        double temp = entities[i].gens[j] + random.NextDouble() * 2 * eps - eps;
                        while (entities[i].gens[j] + temp <= leftBorder || entities[i].gens[j] + temp >= rightBorder)
                            temp = random.NextDouble() * 2 * eps - eps;
                        entities[i].gens[j] += temp;
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
                population.entities = mutation(population);
            double min_func = population.entities.Min(x => x.adaptability);
            Entity temp;
            if (bitsOrNo)
                temp = new Entity(numberOfArguments, bit, leftBorder, rightBorder);
            else
                temp = new Entity(numberOfArguments, leftBorder, rightBorder);
            temp = population.entities.ToList().Find(x => x.adaptability == min_func);
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
