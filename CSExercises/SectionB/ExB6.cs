using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter the value of coordinates as x1, y1, x2, y2");
            double[] coordinatesArray =new double[4];
            for (int i = 0; i <= 3; i++)
            {
                coordinatesArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            double distance = CalculateDistance(coordinatesArray[0], coordinatesArray[1], coordinatesArray[2],
                coordinatesArray[3]);
            Console.WriteLine("Distance is " + distance);
            Console.ReadLine();
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            double a = (x2 - x1) * 2;
            double b = (y2 - y1) * 2;
            double c = a + b;
            double final = Math.Sqrt(c);
            return final;
        }
    }
}
