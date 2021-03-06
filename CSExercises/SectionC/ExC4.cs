using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {

            //Your code here
            Console.WriteLine("Enter distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double calculatedFare = CalculateFare(distance);
            Console.WriteLine(calculatedFare);
            Console.ReadLine();
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double distanceMeters = distance * 100;
            double fare=0;
            if (distanceMeters <= 50)
            {
                fare = 2.40;
            }
            else if ((distanceMeters > 50)&&(distanceMeters <= 900))
            {
                fare = 2.40 + ((distanceMeters - 50) * 0.04 / 100);
            }
            else if (distanceMeters>900)
            {
                fare = 2.40 + (85 * 0.04) + (((distanceMeters - 900) * 0.05) / 100);
            }

            return fare;
        }
    }
}