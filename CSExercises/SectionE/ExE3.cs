﻿using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (IsPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

        public static bool IsPrime(int n)
        {
            //YOUR CODE HERE
            bool returner = false;
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    k++;
                }
            }

            if (k == 2)
            {
                returner = true;
            }
            else
            {
                returner = false;
            }

            return returner;
        }
    }
}
