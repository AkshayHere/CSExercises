using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter x");
            double y = Convert.ToDouble(Console.ReadLine());
            double yCalculated = CalculateY(y);
            Console.WriteLine("value is y :"+ yCalculated);
        }

        public static double CalculateY(double x)
        {
            //YOUR CODE HERE
            double y1 = (5 * Math.Pow(x, 2));
            double y2 = y1 - 4 * x;
            double y3 = y2 + 3;
            return y3;
        }
    }
}
