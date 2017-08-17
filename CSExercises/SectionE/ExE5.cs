using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.

            bool returner = true;
            
            for (int i = 5; i < 10000; i++)
            {
                int k = 0;
                for (int j = 1; j < 100; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }

                if (k == 2)
                {
                    Console.WriteLine(i);
                }
            }

            

        }
    }
}
