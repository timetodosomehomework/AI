using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;
using org.mariuszgromada.math.mxparser;

namespace Gentic_Alghorithm
{
    internal class Bee_Alghorithm
    {
        private int numberOfArguments; 
        private int maxIterations; 
        private string expression;
        private double[] leftBorder;
        private double[] rightBorder;
        private int scouts;
        private int elite;
        private int promising;
        private int eliteBees;
        private int promisingBees;
        private double[] eliteR;
        private double[] promisingR;
        private int iter = 0;
        TextBox func;
        public Bee_Alghorithm(int maxIterations, string expression, double[] leftBorder, double[] rightBorder, int scouts, int elite, int promising, int eliteBees, int promisingBees, double[] eliteR, double[] promisingR, TextBox func)
        {
            this.maxIterations = maxIterations;
            this.expression = expression;
            int max = 0;
            for (int i = 0; i < expression.Length; i++) //find out how many arguments in function
                if (expression[i] == 'x')
                    if (Int32.Parse(expression[i + 1].ToString()) > max)
                        max = Int32.Parse(expression[i + 1].ToString());
            numberOfArguments = max;
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.scouts = scouts;
            this.elite = elite;
            this.promising = promising;
            this.eliteBees = eliteBees;
            this.promisingBees = promisingBees;
            this.eliteR = eliteR;
            this.promisingR = promisingR;
            this.func = func;
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
        public void Alghorithm(TextBox y, ListView listView) //bee alghorithm
        {
            Bee[] scouts = new Bee[this.scouts];
            List<Bee> fitness = new List<Bee>();
            for (int i = 0; i < this.scouts; i++) //scouts gather initial information
            {
                scouts[i] = new Bee(leftBorder, rightBorder);
                scouts[i].adaptability = calculate(scouts[i].coordinates);
                fitness.Add(scouts[i]);
            }
            int count = 0;
            while (count < maxIterations) //main cicle
            {
                fitness.Sort((x1, x2) => x1.adaptability.CompareTo(x2.adaptability)); //ascending sort all results to determine new elite and promising regions
                if (count > 0) 
                    fitness.RemoveRange(elite + promising, fitness.Count - (elite + promising)); //remove from list results that are worthless
                Bee[] xs = fitness.ToArray();
                Bee[] recruits;
                for (int i = 0; i < elite + promising; i++) //for every region
                {
                    double[] leftBorder = new double[numberOfArguments];
                    double[] rightBorder = new double[numberOfArguments];
                    for (int j = 0; j < numberOfArguments; j++) //determine borders for region for each argument
                    {
                        if (i < elite - 1)
                        {
                            leftBorder[j] = xs[i].coordinates[j] - eliteR[j];
                            rightBorder[j] = xs[i].coordinates[j] + eliteR[j];
                        }
                        else
                        {
                            leftBorder[j] = xs[i].coordinates[j] - promisingR[j];
                            rightBorder[j] = xs[i].coordinates[j] + promisingR[j];
                        }
                    }
                    if (i < elite - 1)
                        recruits = new Bee[eliteBees];
                    else
                        recruits = new Bee[promisingBees];
                    for (int j = 0; j < recruits.Length; j++) //for every bee
                    {
                        recruits[j] = new Bee(leftBorder, rightBorder);
                        bool flag = false;
                        for (int k = 0; k < numberOfArguments; k++)
                            if (recruits[j].coordinates[k] <= this.leftBorder[k] || recruits[j].coordinates[k] >= this.rightBorder[k]) //if bee is not in the original interval
                                flag = true;
                        if (flag)
                            continue;
                        recruits[j].adaptability = calculate(recruits[j].coordinates);
                        fitness.Add(recruits[j]);
                    }
                }
                count++;
            }
            fitness.Sort((x1, x2) => x1.adaptability.CompareTo(x2.adaptability)); //determine and show result
            Bee min = fitness.ToArray()[0];
            y.Text = min.adaptability.ToString();
            listView.Items.Clear();
            for (int i = 0; i < min.coordinates.Length; i++)
            {
                ListViewItem listViewItem = new ListViewItem("x" + (i + 1));
                listViewItem.SubItems.Add(min.coordinates[i].ToString());
                listView.Items.Add(listViewItem);
            }
        }
    }
}
