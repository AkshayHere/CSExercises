using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fare = CalculateFare(distance);
            Console.ReadLine();
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double fare = 2.4 + (0.4 * distance);
            Console.WriteLine("Fare is "+Math.Ceiling(fare));
            return 0;

        }
    }
}
