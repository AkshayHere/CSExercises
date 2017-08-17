using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter a three digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsArmstrongNumber(number) == true)
            {
                Console.WriteLine("Enter number is Armstrong number.");
            }
            else
            {
                Console.WriteLine("Enter number is not Armstrong number.");
            }
            Console.ReadLine();
        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            int[] nbrArray = new int[3];
            int i1 = n % 10;
            nbrArray[0] = i1;
            int i2 = (n / 10) % 10;
            nbrArray[1] = i2;
            int i3 = (n / 100) % 10;
            nbrArray[2] = i3;

            double sum = 0;
            bool isSum = false;

            for (int i = 0; i < nbrArray.Length; i++)
            {
                sum = sum + Math.Pow(nbrArray[i], nbrArray.Length);
            }

            if (sum == n)
            {
                isSum = true;
            }
            else
            {
                isSum = false;
            }

            return isSum;

            //int sum = 0;
            //int enteredNumber = n;
            //bool isTrue = false;
            //while ( n!=0 )
            //{
            //    int reminder = n % 10;
            //    sum = sum + (reminder * reminder * reminder);
            //    n = n / 10;
            //}

            //if (sum == enteredNumber)
            //{
            //    isTrue = true;
            //}
            //else
            //{
            //    isTrue = false;
            //}
            //return isTrue;
        }
    }
}