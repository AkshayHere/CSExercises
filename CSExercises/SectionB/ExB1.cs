using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            double number = Convert.ToDouble(Console.ReadLine());
            double rootedNumber = SQRT(number);
            Console.WriteLine(rootedNumber);
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            double root = Math.Sqrt(x);
            return root;

        }
    }
}
