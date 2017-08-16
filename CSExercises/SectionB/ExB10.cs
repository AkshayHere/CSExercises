using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter the value of a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            double c = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(a, b, c);
            Console.WriteLine("Area is "+area);
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}